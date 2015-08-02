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
    public partial class frmRegistrarCargo : Form
    {
        public frmRegistrarCargo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCargo_Load(object sender, EventArgs e)
        {
            cargarNivel();
            cargarCargosDataGridView();
        }

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
                if (MessageBox.Show("¿Guardar el registro de cargo?", "Guardar empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new clsCargoBLL().insertarCargo(
                        new CARGO
                        {
                            IDNIVEL = Convert.ToInt32(cmbNivel.SelectedValue), 
                            NOMCARGO = txbNombreCargo.Text
                            
                        }
                    );
                }

                MessageBox.Show("El cargo ha sido registrado satisfactoriamente");
                cargarCargosDataGridView();
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
