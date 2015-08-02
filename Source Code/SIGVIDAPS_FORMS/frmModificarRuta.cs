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
    public partial class frmModificarRuta : Form
    {
        public frmModificarRuta()
        {
            InitializeComponent();
            limpiarTodo();
        }

        private void frmModificarRuta_Load(object sender, EventArgs e)
        {
            habilitarControles(false);
            cargarRutasDataGridView();
            limpiarTodo();

        }

        private void habilitarControles(Boolean flag)
        {
            txtLugarLlegada.Enabled = flag;
            txtLugarSalida.Enabled = flag;
        }

        private void limpiarTodo()
        {
            txtLugarLlegada.Text = "";
            txtLugarSalida.Text = "";
            dgvRutas.ClearSelection();
        }

        //CARGAR EMPLEADOS EN DATAGRIDVIEW
        private void cargarRutasDataGridView()
        {
            try
            {
                this.dgvRutas.Rows.Clear();
                List<RUTA> lstRuta = (new clsRutaBLL()).obtenerTodasRutas();

                foreach (RUTA ruta in lstRuta)
                {
                    DataGridViewRow tempRow = new DataGridViewRow();

                    //ID
                    DataGridViewCell cellId = new DataGridViewTextBoxCell();
                    cellId.Value = ruta.IDRUTA;
                    tempRow.Cells.Add(cellId);

                    //CODIGO
                    DataGridViewCell cellCod = new DataGridViewTextBoxCell();
                    cellCod.Value = ruta.CODRUTA;
                    tempRow.Cells.Add(cellCod);

                    //LUGAR SALIDA
                    DataGridViewCell cellLugarSalida = new DataGridViewTextBoxCell();
                    cellLugarSalida.Value = ruta.LUGARSALIDA;
                    tempRow.Cells.Add(cellLugarSalida);

                    //LUGAR LLEGADA
                    DataGridViewCell cellLugarLlegada = new DataGridViewTextBoxCell();
                    cellLugarLlegada.Value = ruta.LUGARLLEGADA;
                    tempRow.Cells.Add(cellLugarLlegada);

                    tempRow.Tag = ruta.IDRUTA;
                    dgvRutas.Rows.Add(tempRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de Rutas\n" + ex.Message);
            }
        }

        private void dgvRutas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRutas.SelectedRows.Count > 0)
            {
                habilitarControles(false);
                txtLugarLlegada.Text = dgvRutas.Rows[dgvRutas.SelectedRows[0].Index].Cells[2].Value.ToString();
                txtLugarSalida.Text = dgvRutas.Rows[dgvRutas.SelectedRows[0].Index].Cells[3].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvRutas.SelectedRows.Count > 0)
                habilitarControles(true);
            else
                MessageBox.Show("Seleccione un registro");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String strError = "";
            Boolean bolError = false;

            if (txtLugarLlegada.Text == "")
            {
                strError += "El lugar de llegada es obligatorio\n";
                bolError = true;
            }
            if (txtLugarSalida.Text == "")
            {
                strError += "El lugar de salida es obligatorio\n";
                bolError = true;
            }

            if (!bolError)
            {
                if (MessageBox.Show("¿Actualizar la Ruta?", "Actualizar Ruta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    RUTA ruta = new RUTA();
                    ruta.IDRUTA = Int32.Parse(dgvRutas.Rows[dgvRutas.SelectedRows[0].Index].Cells[0].Value.ToString());
                    ruta.LUGARLLEGADA = txtLugarLlegada.Text;
                    ruta.LUGARSALIDA = txtLugarSalida.Text;
                    ruta.CODRUTA = txtLugarLlegada.Text.Substring(0, 3) + "-" + txtLugarSalida.Text.Substring(0, 3);
                    (new clsRutaBLL()).actualizarRuta((int) ruta.IDRUTA, ruta);                    

                }

                MessageBox.Show("La ruta ha sido actualizada satisfactoriamente");
                cargarRutasDataGridView();
                limpiarTodo();
                habilitarControles(false);
                //dgvEmpleado.ClearSelection();
            }
            else
            {
                MessageBox.Show(strError);
            }
        }

        

    }
}
