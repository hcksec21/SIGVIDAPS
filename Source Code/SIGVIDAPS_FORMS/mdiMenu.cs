using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGVIDAPS_FORMS
{
    public partial class mdiMenu : Form
    {
        Form Forma = new Form();

        public mdiMenu()
        {
            InitializeComponent();
        }

        private void ValidarForm(Form forma)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!this.MdiChildren.Contains(Forma))
            {
                Forma = forma;
                Forma.MdiParent = this;
                Forma.Show();
            }
            else
            {
                MessageBox.Show("Existe una ventana abierta");
                Forma.Focus();
            }
            Cursor.Current = Cursors.Default;
        }

        private void sbmnuformAnticipo_Click(object sender, EventArgs e)
        {
            frmFormularioAnticipo anticipo = new frmFormularioAnticipo();
            ValidarForm(anticipo);
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroEmpleado objEmpleado = new frmRegistroEmpleado();
            ValidarForm(objEmpleado);

        }

        private void sbmnuCargo_Click(object sender, EventArgs e)
        {
            frmRegistrarCargo objCargo = new frmRegistrarCargo();
            ValidarForm(objCargo);
        }

        private void sbmnuNivel_Click(object sender, EventArgs e)
        {

        }

        private void facturasDeCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturaCombustible objFactura = new frmFacturaCombustible();
            ValidarForm(objFactura);
        }

        private void facturasDePeajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturaPeaje objFactura = new frmFacturaPeaje();
            ValidarForm(objFactura);
        }

        private void mdiMenu_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
        }

        private void sbmnuformAnticipo_Click_1(object sender, EventArgs e)
        {
            frmFormularioAnticipo anticipo = new frmFormularioAnticipo();
            ValidarForm(anticipo);
        }

        private void sbmnuFormLiquidacion_Click(object sender, EventArgs e)
        {
            frmFormularioLiquidacion liquidacion = new frmFormularioLiquidacion();
            ValidarForm(liquidacion);
        }

        private void cálculoMontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculoMonto calculoMonto = new frmCalculoMonto();
            ValidarForm(calculoMonto);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmViatico opcionViatico = new frmViatico();
            ValidarForm(opcionViatico);
        }

        private void combinaciónDeViáticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCombinacionViaticos combinacionViatico = new frmCombinacionViaticos();
            ValidarForm(combinacionViatico);
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroUsuario registroUsuario = new frmRegistroUsuario();
            ValidarForm(registroUsuario);

        }

        private void modificarEliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarUsuario modificarUsuario = new frmModificarUsuario();
            ValidarForm(modificarUsuario);
        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroEmpleado frmRegistro = new frmRegistroEmpleado();            
            ValidarForm(frmRegistro);
        }

       

        private void modificarEliminarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarEmpleado modificarEmpleado = new frmModificarEmpleado();
            ValidarForm(modificarEmpleado);
        }

        private void consultaDeFormulariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuConsultas_Click(object sender, EventArgs e)
        {

        }

        private void eliminarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarCargoDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarCargo registrarCargo = new frmRegistrarCargo();
            ValidarForm(registrarCargo);
        }

        private void editarCargoDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarCargo modificarCargo = new frmModificarCargo();
            ValidarForm(modificarCargo);
        }

        private void eliminarCargoDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarCargo eliminarCargo = new frmEliminarCargo();
            ValidarForm(eliminarCargo);
        }
    }
}
