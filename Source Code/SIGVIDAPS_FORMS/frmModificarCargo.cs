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
    public partial class frmModificarCargo : Form
    {
        public frmModificarCargo()
        {
            InitializeComponent();
        }

        private void habilitarControles(Boolean flag)
        {
            txbNombreCargo.Enabled = flag;
            cmbNivel.Enabled = flag;
            btnGuardar.Enabled = flag;
        }

        private void dgvCargos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCargos.SelectedRows.Count != 0)
            {
                txbNombreCargo.Text = dgvCargos.Rows[dgvCargos.SelectedRows[0].Index].Cells[1].Value.ToString();
                cmbNivel.Text = dgvCargos.Rows[dgvCargos.SelectedRows[0].Index].Cells[2].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitarControles(true);
        }

        private void frmModificarCargo_Load(object sender, EventArgs e)
        {
            habilitarControles(false);
            cargarNivel();
            cargarCargosDataGridView();

            cmbNivel.SelectedIndex = -1;
            dgvCargos.ClearSelection();
        }

        //Cargar lista de Niveles
        private void cargarNivel()
        {
            try
            {
                List<NIVEL> lstNivel = (new clsNivelBLL()).obtenerTodosNiveles();
                cmbNivel.ValueMember = "IDNIVEL";
                cmbNivel.DisplayMember = "IDNIVEL";
                cmbNivel.DataSource = lstNivel;
                cmbNivel.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los Niveles. " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Editar el cargo seleccionado
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String strError = "";
            Boolean bolError = false;

            if (txbNombreCargo.Text == "")
            {
                strError += "El nombre es obligatorio\n";
                bolError = true;
            }
            if (cmbNivel.SelectedIndex == -1)
            {
                strError += "El Nivel es obligatorio\n";
                bolError = true;
            }

            if (!bolError)
            {
                if (MessageBox.Show("¿Actualizar el registro de empleado?", "Actualizar empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CARGO cargo = new CARGO();
                    cargo.NOMCARGO = txbNombreCargo.Text;
                    cargo.IDNIVEL = (new clsNivelBLL()).buscarConId(Convert.ToInt32((Object)cmbNivel.SelectedValue)).IDNIVEL;

                    (new clsCargoBLL()).actualizarCargo(Int32.Parse(dgvCargos.Rows[dgvCargos.SelectedRows[0].Index].Cells[0].Value.ToString()), cargo);
                    
                    MessageBox.Show("El empleado ha sido registrado satisfactoriamente");
                    cargarCargosDataGridView();
                }                
            }
            else
            {
                MessageBox.Show(strError);
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
    }
}
