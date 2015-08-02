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
    public partial class frmCrearRuta : Form
    {
        public frmCrearRuta()
        {
            InitializeComponent();
        }


        //CARGAR EMPLEADOS EN DATAGRIDVIEW
        private void cargarEmpleadosDataGridView()
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


    }
}
