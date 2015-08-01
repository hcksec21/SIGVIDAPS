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
        public mdiMenu()
        {
            InitializeComponent();
        }

        private void ValidarForm(Form forma)
        {
            Cursor.Current = Cursors.WaitCursor;
            Form form = new Form();
            if (!this.MdiChildren.Contains(form))
            {
                form = forma;
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Existe una ventana abierta");
                form.Focus();
            }
            Cursor.Current = Cursors.Default;
        }

        private void sbmnuformAnticipo_Click(object sender, EventArgs e)
        {
            frmFormularioAnticipo anticipo = new frmFormularioAnticipo();
            anticipo.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroEmpleado objEmpleado = new frmRegistroEmpleado();
            ValidarForm(objEmpleado);

        }

        private void sbmnuCargo_Click(object sender, EventArgs e)
        {
            frmCargo objCargo = new frmCargo();
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
            anticipo.Show();
        }

        private void sbmnuFormLiquidacion_Click(object sender, EventArgs e)
        {
            frmFormularioLiquidacion liquidacion = new frmFormularioLiquidacion();
            liquidacion.Show();
        }

        private void cálculoMontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculoMonto calculoMonto = new frmCalculoMonto();
            calculoMonto.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmViatico opcionViatico = new frmViatico();
            opcionViatico.Show();
        }

        private void combinaciónDeViáticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCombinacionViaticos combinacionViatico = new frmCombinacionViaticos();
            combinacionViatico.Show();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroUsuario registroUsuario = new frmRegistroUsuario();
            registroUsuario.Show();

        }

        private void modificarEliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarUsuario modificarUsuario = new frmModificarUsuario();
            modificarUsuario.Show();
        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroEmpleado empleado = new frmRegistroEmpleado();
            empleado.Show();
        }

        private void modificarEliminarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarEmpleado modificarEmpleado = new frmModificarEmpleado();
            modificarEmpleado.Show();
        }

        private void consultaDeFormulariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuConsultas_Click(object sender, EventArgs e)
        {

        }
    }
}
