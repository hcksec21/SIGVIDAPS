using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIGVIDAPS_DAT;
using SIGVIDAPS_BLL;

namespace SIGVIDAPS_FORMS
{
    public partial class frmFormularioLiquidacion : Form
    {
        public frmFormularioLiquidacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarTrans_Click(object sender, EventArgs e)
        {

        }

        private void frmFormularioLiquidacion_Load(object sender, EventArgs e)
        {
            //dtpFechaSolicitud.Format = DateTimePickerFormat.Custom;
            //dtpFechaSolicitud.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            //dtpFechaSolicitud.Value.TimeOfDay;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("time: " + dtpHoraSalidaInf.Value.ToShortTimeString());
            if (MessageBox.Show("¿Guardar el Formulario?", "Guardar formulario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                (new clsFormLiquidacionBLL()).crearFormulario(

                    new FORMULARIO_LIQUIDACION
                    {
                        CIUDADFORMLIQ=txtCiudad.Text,
                        ESTADOFORMLIQ="EMITIDO",
                        FECHAFORMLIQ= dtpFechaSolicitud.Value.Date,
                        LLEGADAITINFORMLIQ=dtpFechaLlegadaInf.Value.Date,
                        SALIDAITINFORMLIQ=dtpFechaSalidaInf.Value.Date,
                        //HORALLEGADAITINFORMLIQ=dtpHoraLlegadaInf.Value.ToShortTimeString(),
                        //SALIDAITINFORMLIQ=dtpHoraSalidaInf.Value,
                        NUMFORMLIQ=txtNumeroSolicitud.Text,
                        //UNIDADFORMLIQ=txt     dato quemado
                    }

                );


                
            }
        }
    }
}
