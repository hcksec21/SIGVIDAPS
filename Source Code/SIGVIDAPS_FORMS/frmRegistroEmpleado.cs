using System;
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
    public partial class frmRegistroEmpleado : Form
    {
        public frmRegistroEmpleado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            cargarCargosEmpleado();
            cargarEmpleadosDataGridView();

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
                    CARGO objCargo = (new clsCargoBLL()).BuscarConId(Convert.ToInt32(empleado.IDCARGO));
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




        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
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
            if (cmbCargos.SelectedIndex==-1)
            {
                strError += "El cargo es obligatorio\n";
                bolError = true;
            }
            if (txtDireccion.Text=="")
            {
                strError += "La dirección es obligatoria\n";
                bolError = true;
            }
            if (txtTelefono.Text=="")
            {
                strError += "El teléfono es obligatorio\n";
                bolError = true;
            }

            if(!bolError)
            {
                if (MessageBox.Show("¿Guardar el registro de empleado?", "Guardar empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new clsEmpleadoBLL().insertarEmpleado(
                        new EMPLEADO
                        {
                            IDCARGO = Convert.ToInt32(cmbCargos.SelectedValue),
                            CEDULAEMP = txtCedula.Text,
                            ESTEMP = true,
                            NOMBREEMP = this.txtNombres.Text,
                            APELLIDOEMP = this.txtApellidos.Text,
                            DIREMP = this.txtDireccion.Text,
                            TELEMP = this.txtTelefono.Text
                        }
                    );
                }

                MessageBox.Show("El empleado ha sido registrado satisfactoriamente");
                cargarEmpleadosDataGridView();
            }
            else
            {
                MessageBox.Show(strError);
            }






            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombres_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;

            if (txtCedula.Text.Length == 10)
                e.Handled = true;
            else
                e.Handled = false;


        }

        private void txtDireccion_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
        }

        private void cmbCargos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbCargos.SelectedIndex >= 1)
            {
                String strId = cmbCargos.SelectedValue.ToString();
                int idCargo = Int32.Parse(strId.ToString());

                CARGO objCargo = (new clsCargoBLL()).BuscarConId(idCargo);
                NIVEL objNivel = (new clsNivelBLL()).BuscarConId((int)objCargo.IDNIVEL);

                lblNivel.Text = objNivel.COD_NIVEL;
            }


        }


    }
}
