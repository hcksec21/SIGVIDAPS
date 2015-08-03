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
using System.IO;

namespace SIGVIDAPS_FORMS
{
    public partial class frmFormularioLiquidacion : Form
    {


        private String selectedFileName;
        Double total = 0;


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
                        NUMFORMLIQ=mskNumeroSolicitud.Text,
                        //UNIDADFORMLIQ=txt     dato quemado
                    }

                );


                
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            openFD.Title = "Escoja una factura válida";
            openFD.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFD.FileName = "";
            openFD.Filter = "JPEG Images|*.jpg|All Files|*.*";


            if (openFD.ShowDialog() != DialogResult.Cancel)
            {

                string objString = Microsoft.VisualBasic.Interaction.InputBox("Valor de Factura", "Ingrese valor total de Factura", "", 0, 0);
                double Num;
                bool esCorrecto = double.TryParse(objString, out Num);

                if (esCorrecto)
                {
                    selectedFileName = null;
                    foreach (string fileName in openFD.FileNames)
                    {
                        selectedFileName = fileName;
                        Image img = Image.FromFile(fileName);
                        img.Tag = fileName;
                        imageList1.Images.Add(Path.GetFileName(fileName), img);
                    }

                    lstImgFacturas.Clear();
                    lstImgFacturas.LargeImageList = imageList1;

                    for (int index = 0; index < imageList1.Images.Count; index++)
                    {
                        lstImgFacturas.Items.Add(
                            new ListViewItem()
                            {
                                ImageIndex = index
                            }
                        );
                    }

                    lstImgFacturas.Refresh();
                    txtMonto.Enabled = false;
                    lstImgFacturas.Enabled = true;

                    total += double.Parse(objString);
                    txtMonto.Text = total.ToString();

                }
                else
                {
                    MessageBox.Show("El total ingresado no es correcto");
                }
            }
        }
    }
}
