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
    public partial class frmEliminarCargo : Form
    {
        private int? indice = null;

        public frmEliminarCargo()
        {
            InitializeComponent();
        }

        private void dgvCargos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCargos.SelectedRows.Count != 0)
            {
                indice = Convert.ToInt32(dgvCargos.Rows[dgvCargos.SelectedRows[0].Index].Cells[0].Value.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (indice != null)
            {
                if (MessageBox.Show("¿Eliminar el Cargo?", "Eliminar cargo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    clsCargoBLL objCargoBLL = new clsCargoBLL();

                    if (!objCargoBLL.verificarDependencias(indice))
                    {
                        objCargoBLL.eliminarCargo(indice);
                        MessageBox.Show("Empleado ha sido eliminado satisfactoriamente");
                        cargarCargosDataGridView();
                    }
                    else
                    {
                        if (MessageBox.Show("El cargo a eliminar tiene dependencias en otros formularios. ¿Desea inhabilitarlo?", "Dependencias encontradas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int indice1 = (int)indice;
                            CARGO objCargoENT = objCargoBLL.buscarConId(indice1);
                            objCargoENT.ESTCARGO = false;
                            objCargoBLL.actualizarCargo(indice1, objCargoENT);
                            MessageBox.Show("El cargo ha sido inhabilitado");
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

        //CARGAR CARGOS EN DATAGRIDVIEW
        private void cargarCargosDataGridView()
        {
            try
            {
                this.dgvCargos.Rows.Clear();
                List<CARGO> lstCargo = (new clsCargoBLL()).obtenerTodosCargos();

                foreach (CARGO cargo in lstCargo)
                {
                    DataGridViewRow tempRow = new DataGridViewRow();

                    //ID
                    DataGridViewCell cellId = new DataGridViewTextBoxCell();
                    cellId.Value = cargo.IDCARGO;
                    tempRow.Cells.Add(cellId);

                    //NOMBRE
                    DataGridViewCell cellNombreCargo = new DataGridViewTextBoxCell();
                    cellNombreCargo.Value = cargo.NOMCARGO;
                    tempRow.Cells.Add(cellNombreCargo);

                    //NIVEL
                    DataGridViewCell cellNivel = new DataGridViewTextBoxCell();
                    cellNivel.Value = cargo.NIVEL.IDNIVEL;
                    tempRow.Cells.Add(cellNivel);

                    //Estado
                    DataGridViewCell cellEstado = new DataGridViewTextBoxCell();
                    cellEstado.Value = cargo.ESTCARGO == true ? "ACTIVO" : "INACTIVO";
                    tempRow.Cells.Add(cellEstado);

                    tempRow.Tag = cargo.IDCARGO;
                    dgvCargos.Rows.Add(tempRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de Cargos\n" + ex.Message);
            }
        }

        private void frmEliminarCargo_Load(object sender, EventArgs e)
        {
            cargarCargosDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
