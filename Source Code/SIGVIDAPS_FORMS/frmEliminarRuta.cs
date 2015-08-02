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
    public partial class frmEliminarRuta : Form
    {

        int? indice = null;

        public frmEliminarRuta()
        {
            InitializeComponent();
        }

        private void frmEliminarRuta_Load(object sender, EventArgs e)
        {
            cargarRutasDataGridView();

        }

        //CARGAR RUTAS EN DATAGRIDVIEW
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
            if (dgvRutas.SelectedRows.Count != 0)
            {
                indice = Convert.ToInt32(dgvRutas.Rows[dgvRutas.SelectedRows[0].Index].Cells[0].Value.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (indice != null)
            {
                if (MessageBox.Show("¿Eliminar el registro de ruta?", "Eliminar ruta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    clsRutaBLL objRutaBLL = new clsRutaBLL();

                    if (!objRutaBLL.verificarDependencias(indice))
                    {
                        objRutaBLL.eliminarRuta(indice);
                        MessageBox.Show("Ruta ha sido eliminada satisfactoriamente");
                        cargarRutasDataGridView();
                    }
                    else
                    {
                        if (MessageBox.Show("La ruta a eliminar tiene dependencias en otros formularios. ¿Desea inhabilitarlo?", "Dependencias encontradas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int indice1 = (int)indice;
                            RUTA objRutaENT = objRutaBLL.buscarConId(indice1);
                            objRutaENT.ESTRUTA = false;
                            objRutaBLL.actualizarRuta(indice1, objRutaENT);
                            MessageBox.Show("La ruta ha sido inhabilitada");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("La ruta no se ha eliminado");
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

    }
}
