﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIGVIDAPS_BLL;
using SIGVIDAPS_DAT;

namespace SIGVIDAPS_FORMS
{
    public partial class frmModificarEmpleado : Form
    {
        public frmModificarEmpleado()
        {
            InitializeComponent();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void frmModificarEmpleado_Load(object sender, EventArgs e)
        {
            habilitarControles(false);
            
            cargarEmpleadosDataGridView();
            cargarCargosEmpleado();

            cmbCargos.SelectedIndex = -1;
            dgvEmpleado.ClearSelection();
        }

        //CARGAR EMPLEADOS EN DATAGRIDVIEW
        private void cargarEmpleadosDataGridView()
        {
            try
            {
                this.dgvEmpleado.Rows.Clear();
                List<EMPLEADO> lstEmpleados = (new clsEmpleadoBLL()).obtenerTodosEmpleados();

                foreach (EMPLEADO empleado in lstEmpleados)
                {
                    DataGridViewRow tempRow = new DataGridViewRow();

                    //ID
                    DataGridViewCell cellId = new DataGridViewTextBoxCell();
                    cellId.Value = empleado.IDEMP;
                    tempRow.Cells.Add(cellId);

                    //NOMBRE
                    DataGridViewCell cellNombre = new DataGridViewTextBoxCell();
                    cellNombre.Value = empleado.NOMBREEMP;
                    tempRow.Cells.Add(cellNombre);

                    //APELLIDO
                    DataGridViewCell cellApellido = new DataGridViewTextBoxCell();
                    cellApellido.Value = empleado.APELLIDOEMP;
                    tempRow.Cells.Add(cellApellido);

                    //CÉDULA
                    DataGridViewCell cellCedula = new DataGridViewTextBoxCell();
                    cellCedula.Value = empleado.CEDULAEMP;
                    tempRow.Cells.Add(cellCedula);

                    //NIVEL
                    CARGO objCargo = (new clsCargoBLL()).buscarConId(Convert.ToInt32(empleado.IDCARGO));
                    DataGridViewCell cellNivel = new DataGridViewTextBoxCell();
                    cellNivel.Value = objCargo.IDNIVEL;
                    tempRow.Cells.Add(cellNivel);

                    //CARGO                    
                    DataGridViewCell cellCargo = new DataGridViewTextBoxCell();
                    cellCargo.Value = objCargo.NOMCARGO;
                    tempRow.Cells.Add(cellCargo);

                    //DIRECCION
                    DataGridViewCell cellDireccion = new DataGridViewTextBoxCell();
                    cellDireccion.Value = empleado.DIREMP;
                    tempRow.Cells.Add(cellDireccion);

                    //TELEFONO
                    DataGridViewCell cellTelefono = new DataGridViewTextBoxCell();
                    cellTelefono.Value = empleado.TELEMP;
                    tempRow.Cells.Add(cellTelefono);

                    tempRow.Tag = empleado.IDEMP;
                    dgvEmpleado.Rows.Add(tempRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de Empleados\n" + ex.Message);
            }
        }

        private void dgvEmpleado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleado.SelectedRows.Count != 0)
            {
                txtNombres.Text = dgvEmpleado.Rows[dgvEmpleado.SelectedRows[0].Index].Cells[1].Value.ToString();
                txtApellidos.Text = dgvEmpleado.Rows[dgvEmpleado.SelectedRows[0].Index].Cells[2].Value.ToString();
                txtCedula.Text = dgvEmpleado.Rows[dgvEmpleado.SelectedRows[0].Index].Cells[3].Value.ToString();
                lblNivel.Text = dgvEmpleado.Rows[dgvEmpleado.SelectedRows[0].Index].Cells[4].Value.ToString();
                cmbCargos.Text = dgvEmpleado.Rows[dgvEmpleado.SelectedRows[0].Index].Cells[5].Value.ToString();
                txtDireccion.Text = dgvEmpleado.Rows[dgvEmpleado.SelectedRows[0].Index].Cells[6].Value.ToString();
                txtTelefono.Text = dgvEmpleado.Rows[dgvEmpleado.SelectedRows[0].Index].Cells[7].Value.ToString();
            }




        }

        private void habilitarControles(Boolean flag)
        {
            txtNombres.Enabled = flag;
            txtApellidos.Enabled = flag;
            txtCedula.Enabled = flag;
            txtDireccion.Enabled = flag;
            txtTelefono.Enabled = flag;
            cmbCargos.Enabled = flag;
        }

        //METODO PARA OBTENER LOS CARGOS
        public void cargarCargosEmpleado()
        {
            try
            {
                List<CARGO> lstCargos = (new clsCargoBLL()).obtenerTodosCargos();
                cmbCargos.ValueMember = "IDCARGO";
                cmbCargos.DisplayMember = "NOMCARGO";
                cmbCargos.DataSource = lstCargos;
                cmbCargos.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los cargos. " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            habilitarControles(true);
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            String strError = "";
            Boolean bolError = false;

            if (txtNombres.Text == "")
            {
                strError += "El nombre es obligatorio\n";
                bolError = true;
            }
            if (txtApellidos.Text == "")
            {
                strError += "El apellido es obligatorio\n";
                bolError = true;
            }
            if (txtCedula.Text == "")
            {
                strError += "La cédula es obligatoria\n";
                bolError = true;
            }
            if (cmbCargos.SelectedIndex == -1)
            {
                strError += "El cargo es obligatorio\n";
                bolError = true;
            }
            if (txtDireccion.Text == "")
            {
                strError += "La dirección es obligatoria\n";
                bolError = true;
            }
            if (txtTelefono.Text == "")
            {
                strError += "El teléfono es obligatorio\n";
                bolError = true;
            }

            if (!bolError)
            {
                if (MessageBox.Show("¿Actualizar el registro de empleado?", "Actualizar empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EMPLEADO empleado = new EMPLEADO();
                    empleado.APELLIDOEMP = txtApellidos.Text;
                    empleado.IDCARGO = (new clsCargoBLL()).buscarConNombreCargo(cmbCargos.SelectedItem.ToString()).IDCARGO;
                    empleado.CEDULAEMP = txtCedula.Text;
                    empleado.DIREMP = txtDireccion.Text;
                    empleado.ESTEMP = (cmbEstado.SelectedItem == "ACTIVO") ? true : false;
                    empleado.NOMBREEMP = txtNombres.Text;
                    empleado.TELEMP = txtTelefono.Text;

                    (new clsEmpleadoBLL()).actualizarEmpleado(Int32.Parse(dgvEmpleado.Rows[dgvEmpleado.SelectedRows[0].Index].Cells[0].Value.ToString()), empleado);

                }

                MessageBox.Show("El empleado ha sido registrado satisfactoriamente");
                cargarEmpleadosDataGridView();
            }
            else
            {
                MessageBox.Show(strError);
            }
        }

    }
}
