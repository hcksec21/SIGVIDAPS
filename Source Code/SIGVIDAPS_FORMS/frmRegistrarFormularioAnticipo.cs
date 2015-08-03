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
    public partial class frmRegistrarFormularioAnticipo : Form
    {
        List<DETALLE_FORMULARIO> listaDetalleFormulario = new List<DETALLE_FORMULARIO>();
        public frmRegistrarFormularioAnticipo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void frmRegistrarFormularioAnticipo_Load(object sender, EventArgs e)
        {
            cargarEmpleados();
            cargarTipoTransporte();
            cargarRutas();
            cargarCombinacionViaticos();
            cmbEmpleados.SelectedIndex = -1;
            lblCargo.Text = "";
        }

        private void cargarEmpleados()
        {
            try
            {
                List<EMPLEADO> lstEmpleados = (new clsEmpleadoBLL()).obtenerTodosEmpleados();
                cmbEmpleados.ValueMember = "IDEMP";
                cmbEmpleados.DisplayMember = "NOMBRECOMPLETO";
                cmbEmpleados.DataSource = lstEmpleados;
                cmbEmpleados.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los Empleados. " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cargarTipoTransporte()
        {
            try
            {
                List<TIPO_TRANSPORTE> lstTipoTransporte = (new clsTipoTransporteBLL()).obtenerTodasTipoTrasnportes();
                cmbTipoTransporte.ValueMember = "IDTIPOTRANSPORTE";
                cmbTipoTransporte.DisplayMember = "TIPOTRANSPORTE";
                cmbTipoTransporte.DataSource = lstTipoTransporte;
                cmbTipoTransporte.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los Tipos de Transporte. " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cargarRutas()
        {
            try
            {
                List<RUTA> lstRutas = (new clsRutaBLL()).obtenerTodasRutas();
                cmbRuta.ValueMember = "IDRUTA";
                cmbRuta.DisplayMember = "RUTACOMPLETA";
                cmbRuta.DataSource = lstRutas;
                cmbRuta.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las Rutas. " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cargarCombinacionViaticos()
        {
            try
            {
                List<COMBINACION_VIATICOS> lstCombinacionViaticos = (new clsCombinacionViaticosBLL()).obtenerCombinacionViaticos();
                cmbCombinacionViaticos.ValueMember = "IDCOMBINACION";
                cmbCombinacionViaticos.DisplayMember = "NOMCOMBINACION";
                cmbCombinacionViaticos.DataSource = lstCombinacionViaticos;
                cmbCombinacionViaticos.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las Combinaciones. " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Form frmAbout = new frmCalculoMontoAnticipo();
            frmAbout.Show(this);

            String strError = "";
            Boolean bolError = false;

            if (mskNumeroSolicitud.Text == "")
            {
                strError += "El numero de Solicitud es obligatorio\n";
                bolError = true;
            }
            if (DateTime.Compare(dtpFechaSolicitud.Value, DateTime.Now) > 0)
            {
                strError += "La Fecha de Solicitud no es Valida\n";
                bolError = true;
            }
            if (txtCiudad.Text == "")
            {
                strError += "La Ciudad es Obligatoria\n";
                bolError = true;
            }
            if (txtDetalleActividades.Text == "")
            {
                strError += "El Detalle es Obligatorio\n";
                bolError = true;
            }
            if (txtNombreBanco.Text == "")
            {
                strError += "El Nombre del Banco es Obligatorio\n";
                bolError = true;
            }
            if (txtNumCuenta.Text == "")
            {
                strError += "El Numero de Cuenta es Obligatorio\n";
                bolError = true;
            }
            if (cmbEmpleados.SelectedIndex == -1)
            {
                strError += "El Tipo de Cuenta es Obligatoria\n";
                bolError = true;
            }
            if (DateTime.Compare(dtpFechaSalidaGen.Value, dtpFechaSolicitud.Value) < 0)
            {
                strError += "La Fecha de Salida no es Valida\n";
                bolError = true;
            }
            if (DateTime.Compare(dtpFechaLlegadaGen.Value, dtpFechaSalidaGen.Value) < 0)
            {
                strError += "La Fecha de Llegada no es Valida\n";
                bolError = true;
            }

            if (!bolError)
            {
                if (MessageBox.Show("¿Guardar el Formulario de Anticipo?", "Guardar Formulario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FORMULARIO__ANTICIPO formularioAnticipo = new FORMULARIO__ANTICIPO();
                    formularioAnticipo.BANCOFORMANTICIPO = txtNombreBanco.Text;
                    formularioAnticipo.CIUDADFORMANTICIPO = txtCiudad.Text;
                    formularioAnticipo.IDCOMBINACION = Convert.ToInt32(cmbCombinacionViaticos.SelectedValue);
                    formularioAnticipo.DESCRIPCIONFORMANTICIPO = txtDetalleActividades.Text;
                    formularioAnticipo.IDEMP = Convert.ToInt32(cmbEmpleados.SelectedValue);
                    formularioAnticipo.NUMCUENTAFORMANTICIPO = txtNumCuenta.Text;
                    formularioAnticipo.NUMFORMANTICIPO = mskNumeroSolicitud.Text;
                    formularioAnticipo.TIPOCUENTAFORMANTICIPO = cmbTipoCuenta.DisplayMember;
                    formularioAnticipo.UNIDADFORMANTICIPO = cmbUnidad.DisplayMember;
                    formularioAnticipo.ESTADOFORMANTICIPO = "EMITIDO";
                    formularioAnticipo.FECFORMANTICIPO = dtpFechaSolicitud.Value;

                    DateTime llegada = dtpFechaLlegadaGen.Value.Date + dtpHoraLlegadaGen.Value.TimeOfDay;
                    formularioAnticipo.LLEGADAFORMANTICIPO = llegada;

                    DateTime salida = dtpFechaSalidaGen.Value.Date + dtpHoraSalidaGen.Value.TimeOfDay;
                    formularioAnticipo.SALIDAFORMANTICIPO = salida;

                    if (listaDetalleFormulario.Any())
                    {                        
                        formularioAnticipo.DETALLE_FORMULARIO = listaDetalleFormulario;
                        MessageBox.Show("El formulario ha sido registrado satisfactoriamente {0}" + formularioAnticipo.IDFORMANTICIPO);
                    }

                    (new clsFormularioAnticipo()).insertarFormulario_anticipo(formularioAnticipo);

                    MessageBox.Show("El formulario ha sido registrado satisfactoriamente {0}" + formularioAnticipo.IDFORMANTICIPO);
                }
            }
            else
            {
                MessageBox.Show(strError);
            }
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpleados.SelectedIndex >= 0)
            {
                String strId = cmbEmpleados.SelectedValue.ToString();
                int idEmp = Int32.Parse(strId.ToString());

                EMPLEADO objEmpleado = (new clsEmpleadoBLL()).buscarConId(idEmp);

                lblCargo.Text = objEmpleado.CARGO.NOMCARGO;
            }
        }

        private void btnNuevoTrans_Click(object sender, EventArgs e)
        {
            String strError = "";
            Boolean bolError = false;

            if (txtNombreTransporte.Text == "")
            {
                strError += "El Nombre de Transporte es obligatorio\n";
                bolError = true;
            }
            if (cmbTipoTransporte.SelectedIndex == -1)
            {
                strError += "El tipo de Transport es Obligatorio\n";
                bolError = true;
            }
            if (cmbRuta.SelectedIndex == -1)
            {
                strError += "La Ruta es Obligatorio\n";
                bolError = true;
            }
            if (DateTime.Compare(dtpFechaLlegadaTrans.Value, dtpFechaSalidaTrans.Value) < 0)
            {
                strError += "La fechas de transporte no son Validas\n";
                bolError = true;
            }
            if (!bolError)
            {
                DateTime llegada = dtpFechaLlegadaTrans.Value.Date + dtpHoraLlegadaTrans.Value.TimeOfDay;
                DateTime salida = dtpFechaSalidaTrans.Value.Date + dtpHoraSalidaTrans.Value.TimeOfDay; 
                listaDetalleFormulario.Add(new DETALLE_FORMULARIO
                {                                       
                    IDRUTA = Convert.ToInt32(cmbRuta.SelectedValue),
                    IDTIPOTRANSPORTE = Convert.ToInt32(cmbTipoTransporte.SelectedValue),
                    LLEGADATRANSPORTE = llegada,
                    NOMBRETRANSPORTE = txtNombreTransporte.Text,
                    SALIDATRANSPORTE = salida                    
                });
                var lastItem = listaDetalleFormulario.LastOrDefault();
                addListaDetalleFormulario((DETALLE_FORMULARIO) lastItem);
                limpiarTransporte();
            }
            else
            {
                MessageBox.Show(strError);
            }
        }

        private void limpiarTransporte()
        {
            txtNombreTransporte.Text = "";
            cmbTipoTransporte.SelectedIndex = -1;
            cmbRuta.SelectedIndex = -1;
            dtpFechaLlegadaTrans.Value = DateTime.Now;
            dtpFechaSalidaTrans.Value = DateTime.Now;
            dtpHoraLlegadaTrans.Value = DateTime.Now;
            dtpHoraSalidaTrans.Value = DateTime.Now;
        }


        private void addListaDetalleFormulario(DETALLE_FORMULARIO detalle)
        {
            DataGridViewRow tempRow = new DataGridViewRow();

            //ID
            DataGridViewCell cellTransporte = new DataGridViewTextBoxCell();
            cellTransporte.Value = detalle.NOMBRETRANSPORTE;
            tempRow.Cells.Add(cellTransporte);

            //NOMBRE
            TIPO_TRANSPORTE tipo = (new clsTipoTransporteBLL()).buscarConId(Convert.ToInt32(detalle.IDTIPOTRANSPORTE));
            DataGridViewCell cellTipoTrans = new DataGridViewTextBoxCell();
            cellTipoTrans.Value = tipo.TIPOTRANSPORTE;
            tempRow.Cells.Add(cellTipoTrans);

            //Ruta
            RUTA ruta = (new clsRutaBLL()).buscarConId(Convert.ToInt32(detalle.IDRUTA));
            DataGridViewCell cellRuta = new DataGridViewTextBoxCell();
            cellRuta.Value = ruta.RUTACOMPLETA;
            tempRow.Cells.Add(cellRuta);

            //NIVEL
            DataGridViewCell cellSalida = new DataGridViewTextBoxCell();
            cellSalida.Value = detalle.SALIDATRANSPORTE;
            tempRow.Cells.Add(cellSalida);

            //NIVEL
            DataGridViewCell cellLlegada = new DataGridViewTextBoxCell();
            cellLlegada.Value = detalle.LLEGADATRANSPORTE;
            tempRow.Cells.Add(cellLlegada);

            tempRow.Tag = detalle.IDDETFORM;
            dtgTransporte.Rows.Add(tempRow);
        }

        private void dtpFechaLlegadaTrans_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarTrans_Click(object sender, EventArgs e)
        {
            if (dtgTransporte.SelectedRows.Count > 0)
            {
                listaDetalleFormulario.RemoveAt(dtgTransporte.CurrentCell.RowIndex);
                dtgTransporte.Rows.RemoveAt(dtgTransporte.CurrentCell.RowIndex);
            }
            else
                MessageBox.Show("Seleccione un registro");

        }
    }
}
