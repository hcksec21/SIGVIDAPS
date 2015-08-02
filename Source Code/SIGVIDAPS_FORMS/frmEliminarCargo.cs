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
        public frmEliminarCargo()
        {
            InitializeComponent();
        }

        private void dgvCargos_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar el cargo?", "Eliminar cargo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                (new clsCargoBLL()).eliminarCargo(Int32.Parse(dgvCargos.Rows[dgvCargos.SelectedRows[0].Index].Cells[0].Value.ToString()));

                MessageBox.Show("El cargo ha sido eliminado satisfactoriamente");
                cargarCargosDataGridView();
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
