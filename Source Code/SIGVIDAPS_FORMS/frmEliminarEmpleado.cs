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
    public partial class frmEliminarEmpleado : Form
    {

        int? indice = null;

        public frmEliminarEmpleado()
        {
            InitializeComponent();

        }

        private void frmEliminarEmpleado_Load(object sender, EventArgs e)
        {
            cargarEmpleadosDataGridView();
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

                    //ESTADO
                    DataGridViewCell cellEstado = new DataGridViewTextBoxCell();
                    cellEstado.Value = ((Boolean)empleado.ESTEMP) ? "ACTIVO" : "INACTIVO";
                    tempRow.Cells.Add(cellEstado);

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
                indice = Convert.ToInt32(dgvEmpleado.Rows[dgvEmpleado.SelectedRows[0].Index].Cells[0].Value.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (indice != null)
            {
                if (MessageBox.Show("¿Eliminar el registro de empleado?", "Eliminar empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    clsEmpleadoBLL objEmpleadoBLL = new clsEmpleadoBLL();

                    if (!objEmpleadoBLL.verificarDependencias(indice))
                    {
                        objEmpleadoBLL.eliminarEmpleado(indice);
                        MessageBox.Show("Empleado ha sido eliminado satisfactoriamente");
                        cargarEmpleadosDataGridView();
                    }
                    else
                    {
                        if (MessageBox.Show("El empleado a eliminar tiene dependencias en otros formularios. ¿Desea inhabilitarlo?", "Dependencias encontradas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int indice1 = (int)indice;
                            EMPLEADO objEmpleadoENT = objEmpleadoBLL.buscarConId(indice1);
                            objEmpleadoENT.ESTEMP = false;
                            objEmpleadoBLL.actualizarEmpleado(indice1, objEmpleadoENT);
                            MessageBox.Show("El empleado ha sido inhabilitado");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("El empleado no se ha eliminado");
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }




        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
