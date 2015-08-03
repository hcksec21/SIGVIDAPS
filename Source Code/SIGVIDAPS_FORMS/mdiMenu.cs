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
    public partial class mdiMenu : Form
    {
        Form Forma = new Form();
        string user;

        public mdiMenu(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        public mdiMenu()
        {
            // TODO: Complete member initialization
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
            frmRegistrarFormularioAnticipo anticipo = new frmRegistrarFormularioAnticipo();
            ValidarForm(anticipo);
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroEmpleado objEmpleado = new frmRegistroEmpleado();
            ValidarForm(objEmpleado);
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
            MessageBox.Show("Bienvenido al Sistema SIGVIDAPS : " + user);
            disableControls();
        }

        private void disableControls()
        {
            USUARIO user = (new clsUsuarioBLL()).buscarByNombre(this.user);
            List<MENU_PERFIL> listPerfiles = (new clsMenuPerfilBLL()).obtenerTodosLosMenuPerfilesDeUsuario(user);
            foreach(MENU_PERFIL menu_perfil in listPerfiles){
                if (mnuAdministracion.Name == menu_perfil.MENUPERFIL)
                {
                    mnuAdministracion.Enabled = false;
                }
                if (mnuEmpleados.Name == menu_perfil.MENUPERFIL)
                {
                    mnuEmpleados.Enabled = false;
                }
                if (mnuAprobarFormularioAnticipo.Name == menu_perfil.MENUPERFIL)
                {
                    mnuAprobarFormularioAnticipo.Enabled = false;
                }
                if (mnuAprobarFormularioLiquidacion.Name == menu_perfil.MENUPERFIL)
                {
                    mnuAprobarFormularioLiquidacion.Enabled = false;
                }
                if (mnuFormularios.Name == menu_perfil.MENUPERFIL)
                {
                    mnuFormularios.Enabled = false;
                }
                if (mnuRegistrarFormularioAnticipo.Name == menu_perfil.MENUPERFIL)
                {
                    mnuRegistrarFormularioAnticipo.Enabled = false;
                }
                if (mnuRegistrarFormularioLiquidacion.Name == menu_perfil.MENUPERFIL)
                {
                    mnuRegistrarFormularioLiquidacion.Enabled = false;
                }
                if (mnuEditarFormularioLiquidacion.Name == menu_perfil.MENUPERFIL)
                {
                    mnuEditarFormularioLiquidacion.Enabled = false;
                }
            }
        }

        private void sbmnuformAnticipo_Click_1(object sender, EventArgs e)
        {
            frmRegistrarFormularioAnticipo anticipo = new frmRegistrarFormularioAnticipo();
            ValidarForm(anticipo);
        }

        private void sbmnuFormLiquidacion_Click(object sender, EventArgs e)
        {
            frmFormularioLiquidacion liquidacion = new frmFormularioLiquidacion();
            ValidarForm(liquidacion);
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


        private void modificarEliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActualizarUsuario modificarUsuario = new frmActualizarUsuario();
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

        private void registrarCargoDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarCargo registrarCargo = new frmRegistrarCargo();
            ValidarForm(registrarCargo);
        }

        private void editarCargoDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActualizarCargo modificarCargo = new frmActualizarCargo();
            ValidarForm(modificarCargo);
        }

        private void eliminarCargoDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarCargo eliminarCargo = new frmEliminarCargo();
            ValidarForm(eliminarCargo);
        }


        private void registrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarUsuario registrarUsuario = new frmRegistrarUsuario();
            ValidarForm(registrarUsuario);
        }

        private void eliminarEmpleadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmEliminarEmpleado eliminarEmpleado = new frmEliminarEmpleado();
            ValidarForm(eliminarEmpleado);
        }

        private void administrarRutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void editarFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActualizarUsuario actualizarUsuario = new frmActualizarUsuario();
            ValidarForm(actualizarUsuario);
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarUsuario eliminarUsuario = new frmEliminarUsuario();
            ValidarForm(eliminarUsuario);
        }

        private void sbmnuCargo_Click(object sender, EventArgs e)
        {

        }

        private void registrarRutaDeMovilizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCrearRuta frmRuta = new frmCrearRuta();
            ValidarForm(frmRuta);
        }

        private void editarRutaDeMovilizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarRuta frmRuta = new frmModificarRuta();
            ValidarForm(frmRuta);
        }

        private void eliminarRutaDeMovilizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarRuta ruta = new frmEliminarRuta();
            ValidarForm(ruta);
        }

        private void registrarFormularioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFormularioLiquidacion formLiq = new frmFormularioLiquidacion();
            ValidarForm(formLiq);
        }

        private void registrarFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarFormularioAnticipo registrarFormularioAnticipo = new frmRegistrarFormularioAnticipo();
            ValidarForm(registrarFormularioAnticipo);
        }

        private void anularFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnularFormularioAnticipo anularFormularioAnticipo = new frmAnularFormularioAnticipo();
            ValidarForm(anularFormularioAnticipo);
        }

        private void aprobarFormualrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAprobarFormularioAnticipo aprobarFormulario = new frmAprobarFormularioAnticipo();
            ValidarForm(aprobarFormulario);
        }

        private void consultarFormulariosToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            frmConsultarFormularioAnticipo consultarFormulario = new frmConsultarFormularioAnticipo();
            ValidarForm(consultarFormulario);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Show();
            this.Close();
        }
    }
}
