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
            cargarEmpleados();

        }

        //METODO PARA OBTENER LOS CARGOS
        public void cargarCargosEmpleado()
        {
            try
            {
                List<CARGO> lstCargos = (new clsCargoBLL()).obtenerTodosCargos();
                cmbCargos.DataSource = lstCargos;
                cmbCargos.DisplayMember = "NOMCARGO";
                cmbCargos.ValueMember = "IDCARGO";
                cmbCargos.SelectedIndex = -1;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los cargos. " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        //CARGAR EMPLEADOS EN DATAGRIDVIEW
        private void cargarEmpleados()
        {
            try
            {
                this.dgvEmpleado.Rows.Clear();
                List<EMPLEADO> lstEmpleados = (new clsEmpleadoBLL()).obtenerTodosEmpleados();


                foreach (EMPLEADO empleado in lstEmpleados)
                {
                    DataGridViewRow tempRow = new DataGridViewRow();

                    //NOMBRE
                    DataGridViewCell cellNombre = new DataGridViewTextBoxCell();
                    cellNombre.Value = empleado.NOMBREEMP;
                    tempRow.Cells.Add(cellNombre);

                    //NIVEL
                    DataGridViewCell cellNivel = new DataGridViewTextBoxCell();
                    cellNivel.Value = empleado.IDNIVEL;
                    tempRow.Cells.Add(cellNivel);

                    //CARGO
                    CARGO objCargo = (new clsCargoBLL()).BuscarConId(Convert.ToInt32(empleado.IDCARGO));
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
                MessageBox.Show("Error en la carga de cajas\n" + ex.Message);
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar el registro?", "Guardar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                new clsEmpleadoBLL().insertarEmpleado(
                    new EMPLEADO
                    {
                        IDNIVEL = Convert.ToInt32(this.txtNivel.Value),
                        IDCARGO = Convert.ToInt32(cmbCargos.SelectedValue),
                        CODEMP = "EMP",
                        NOMBREEMP = this.txtNombres.Text + " " + this.txtApellidos.Text,
                        DIREMP = this.txtDireccion.Text,
                        TELEMP = this.txtTelefono.Text
                    }
                );
            }

            MessageBox.Show("Elemento registrado satisfactoriamente");
            cargarEmpleados();
                

            

        }
    }
}
