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
    public partial class frmAnularFormularioAnticipo : Form
    {
        clsFormularioAnticipoBLL formularioBll = new clsFormularioAnticipoBLL();

        public frmAnularFormularioAnticipo()
        {
            InitializeComponent();
        }

        private void frmAnularFormularioAnticipo_Load(object sender, EventArgs e)
        {
            cargarFormulariosAnticipo();
        }

        private void cargarFormulariosAnticipo()
        {
            List<FORMULARIO__ANTICIPO> listaFormularios = formularioBll.buscarFormulariosEmitidosPorFecha();
            try
            {
                dgvFormulariosAnticipo.Rows.Clear();

                foreach(FORMULARIO__ANTICIPO fr in listaFormularios){

                    DataGridViewRow tempRow = new DataGridViewRow();
                    //DIAS
                    DataGridViewCell cellID = new DataGridViewTextBoxCell();
                    cellID.Value = fr.IDFORMANTICIPO;
                    tempRow.Cells.Add(cellID);
                    
                    //DIAS
                    DataGridViewCell cellEstado = new DataGridViewTextBoxCell();
                    cellEstado.Value = fr.ESTADOFORMANTICIPO;
                    tempRow.Cells.Add(cellEstado);

                    //DIAS
                    DataGridViewCell NOMBRECOMPLETO = new DataGridViewTextBoxCell();
                    NOMBRECOMPLETO.Value = fr.EMPLEADO.NOMBRECOMPLETO;
                    tempRow.Cells.Add(NOMBRECOMPLETO);

                    //DIAS
                    DataGridViewCell FECFORMANTICIPO = new DataGridViewTextBoxCell();
                    FECFORMANTICIPO.Value = fr.FECFORMANTICIPO;
                    tempRow.Cells.Add(FECFORMANTICIPO);

                    //DIAS
                    DataGridViewCell MONTOTOTAL = new DataGridViewTextBoxCell();
                    MONTOTOTAL.Value = fr.MONTOTOTAL;
                    tempRow.Cells.Add(MONTOTOTAL);

                    //DIAS
                    DataGridViewCell NOMCOMBINACION = new DataGridViewTextBoxCell();
                    NOMCOMBINACION.Value = fr.COMBINACION_VIATICOS.NOMCOMBINACION;
                    tempRow.Cells.Add(NOMCOMBINACION);

                    //DIAS
                    DataGridViewCell SALIDAFORMANTICIPO = new DataGridViewTextBoxCell();
                    SALIDAFORMANTICIPO.Value = fr.SALIDAFORMANTICIPO;
                    tempRow.Cells.Add(SALIDAFORMANTICIPO);

                    //DIAS
                    DataGridViewCell LLEGADAFORMANTICIPO = new DataGridViewTextBoxCell();
                    LLEGADAFORMANTICIPO.Value = fr.LLEGADAFORMANTICIPO;
                    tempRow.Cells.Add(LLEGADAFORMANTICIPO);

                    //DIAS
                    DataGridViewCell DESCRIPCIONFORMANTICIPO = new DataGridViewTextBoxCell();
                    DESCRIPCIONFORMANTICIPO.Value = fr.DESCRIPCIONFORMANTICIPO;
                    tempRow.Cells.Add(DESCRIPCIONFORMANTICIPO);

                    //DIAS
                    DataGridViewCell BANCOFORMANTICIPO = new DataGridViewTextBoxCell();
                    BANCOFORMANTICIPO.Value = fr.BANCOFORMANTICIPO;
                    tempRow.Cells.Add(BANCOFORMANTICIPO);

                    dgvFormulariosAnticipo.Rows.Add(tempRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvFormulariosAnticipo.SelectedRows.Count > 0){
                if (MessageBox.Show("¿Anular el formulario?", "Anular formulario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FORMULARIO__ANTICIPO formulario = formularioBll.buscarConId(Int32.Parse(dgvFormulariosAnticipo.Rows[dgvFormulariosAnticipo.SelectedRows[0].Index].Cells[0].Value.ToString()));
                    formulario.ESTADOFORMANTICIPO = "ANULADO";
                    formularioBll.actualizarFormulario_anticipo(Int32.Parse(dgvFormulariosAnticipo.Rows[dgvFormulariosAnticipo.SelectedRows[0].Index].Cells[0].Value.ToString()), formulario);
                    MessageBox.Show("El formulario ha sido anulado satisfactoriamente");
                    cargarFormulariosAnticipo();
                }
            }
            else
                MessageBox.Show("Seleccione un registro");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
