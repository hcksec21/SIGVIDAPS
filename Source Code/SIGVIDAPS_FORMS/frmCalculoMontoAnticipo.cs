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
    public partial class frmCalculoMontoAnticipo : Form
    {

        FORMULARIO__ANTICIPO formularioAnticipo;
        int diasViatico { get; set; }
        int nivelEmpleado { get; set; }
        int opcionViatico { get; set; }
        decimal? subtotal { get; set; }
        decimal? total { get; set; }

        clsOpcionesViaticosBLL opcionesViaticosBLL = new clsOpcionesViaticosBLL();
        clsEmpleadoBLL empleadoBLL = new clsEmpleadoBLL();
        clsOpcionNivelBLL opcionesNivelBLL = new clsOpcionNivelBLL();
        clsCalculoBLL calculoBLL = new clsCalculoBLL();
        clsDetalleCalculoBLL detalleCalculo = new clsDetalleCalculoBLL();
        clsFormularioAnticipoBLL formularioAnticipoBLL = new clsFormularioAnticipoBLL();

        CALCULO calculo = new CALCULO();
        DETALLE_CALCULO detalle = new DETALLE_CALCULO();
        List<DETALLE_CALCULO> listDetalle = new List<DETALLE_CALCULO>();
        List<CALCULO> listCalculo = new List<CALCULO>();

        public frmCalculoMontoAnticipo(FORMULARIO__ANTICIPO formulario)
        {
            InitializeComponent();
            this.formularioAnticipo = formulario;
        }

        private void frmCalculoMontoAnticipo_Load(object sender, EventArgs e)
        {
            calcularMontoViatico();
        }

        private void calcularMontoViatico()
        {
            int opcion = Convert.ToInt32(formularioAnticipo.IDCOMBINACION);
            diasViatico = Convert.ToInt32((((DateTime)formularioAnticipo.LLEGADAFORMANTICIPO) - ((DateTime)formularioAnticipo.SALIDAFORMANTICIPO)).TotalDays);
            //diasViatico = ((Int32)((DateTime)formularioAnticipo.LLEGADAFORMANTICIPO).Subtract((DateTime)formularioAnticipo.SALIDAFORMANTICIPO).TotalDays);
            nivelEmpleado = empleadoBLL.buscarConId(Convert.ToInt32(formularioAnticipo.IDEMP)).CARGO.NIVEL.NIVEL1;

            switch (opcion)
            {
                case 1:
                    cargarSubsistencia();
                    break;
                case 2:
                    cargarSubsistenciaMovilizacion();
                    break;
                case 3:
                    cargarViaticoSubsistencia();
                    break;
                case 4:
                    cargarViaticoSubsistenciaMovilizacion();
                    break;
                case 5:
                    cargarAlimentacion();
                    break;
                case 6:
                    cargarAlimentacionMovilizacion();
                    break;
            }

        }

        private void cargarSubsistencia()
        {
            try
            {
                this.dgvMonto.Rows.Clear();
                opcionViatico = Convert.ToInt32(opcionesViaticosBLL.buscarConId(2).IDOPCION);

                DataGridViewRow tempRow = new DataGridViewRow();

                //TipoViatico
                DataGridViewCell cellTipoViatico = new DataGridViewTextBoxCell();
                cellTipoViatico.Value = opcionesViaticosBLL.buscarConId(2).NOMBREOPCION;
                tempRow.Cells.Add(cellTipoViatico);

                //Nivel
                DataGridViewCell cellNivel = new DataGridViewTextBoxCell();
                cellNivel.Value = empleadoBLL.buscarConId(Convert.ToInt32(formularioAnticipo.IDEMP)).CARGO.NOMCARGO;
                tempRow.Cells.Add(cellNivel);

                //DIAS
                DataGridViewCell cellDias = new DataGridViewTextBoxCell();
                cellDias.Value = diasViatico;
                tempRow.Cells.Add(cellDias);

                //Subtotal
                DataGridViewCell cellSubtotal = new DataGridViewTextBoxCell();
                subtotal = opcionesNivelBLL.buscarConOpcionNivel(opcionViatico, nivelEmpleado).VALOROPCION;
                cellSubtotal.Value = subtotal;
                tempRow.Cells.Add(cellSubtotal);

                detalle.IDOPCIONN = opcionesNivelBLL.buscarConOpcionNivel(opcionViatico, nivelEmpleado).IDOPCIONN;
                detalle.SUBTOTALMONTO = subtotal;

                listDetalle.Add(detalle);

                calculo.MONTOCALCULO = detalle.SUBTOTALMONTO;
                calculo.DETALLE_CALCULO = listDetalle;
                listCalculo.Add(calculo);

                formularioAnticipo.CALCULOes = listCalculo;
                formularioAnticipo.MONTOTOTAL = calculo.MONTOCALCULO;

                lblTotal.Text = calculo.MONTOCALCULO.ToString();

                dgvMonto.Rows.Add(tempRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        private void cargarSubsistenciaMovilizacion()
        {
            try
            {
                this.dgvMonto.Rows.Clear();
                {
                    opcionViatico = Convert.ToInt32(opcionesViaticosBLL.buscarConId(2).IDOPCION);
                    DataGridViewRow tempRow = new DataGridViewRow();

                    //TipoViatico
                    DataGridViewCell cellTipoViatico = new DataGridViewTextBoxCell();
                    cellTipoViatico.Value = opcionesViaticosBLL.buscarConId(2).NOMBREOPCION;
                    tempRow.Cells.Add(cellTipoViatico);

                    //Nivel
                    DataGridViewCell cellNivel = new DataGridViewTextBoxCell();
                    cellNivel.Value = empleadoBLL.buscarConId(Convert.ToInt32(formularioAnticipo.IDEMP)).CARGO.NOMCARGO;
                    tempRow.Cells.Add(cellNivel);

                    //DIAS
                    DataGridViewCell cellDias = new DataGridViewTextBoxCell();
                    cellDias.Value = diasViatico;
                    tempRow.Cells.Add(cellDias);

                    //Subtotal
                    DataGridViewCell cellSubtotal = new DataGridViewTextBoxCell();
                    subtotal = opcionesNivelBLL.buscarConOpcionNivel(opcionViatico, nivelEmpleado).VALOROPCION;
                    cellSubtotal.Value = subtotal;
                    tempRow.Cells.Add(cellSubtotal);

                    listDetalle.Add(new DETALLE_CALCULO()
                    {
                        IDOPCIONN = opcionesNivelBLL.buscarConOpcionNivel(opcionViatico, nivelEmpleado).IDOPCIONN,
                        SUBTOTALMONTO = subtotal
                    });

                    calculo.MONTOCALCULO = subtotal;
                    dgvMonto.Rows.Add(tempRow);
                }
                {
                    opcionViatico = Convert.ToInt32(opcionesViaticosBLL.buscarConId(4).IDOPCION);
                    foreach (DETALLE_FORMULARIO d in formularioAnticipo.DETALLE_FORMULARIO)
                    {
                        DataGridViewRow tempRow = new DataGridViewRow();

                        //TipoViatico
                        DataGridViewCell cellTipoViatico = new DataGridViewTextBoxCell();
                        cellTipoViatico.Value = opcionesViaticosBLL.buscarConId(4).NOMBREOPCION;
                        tempRow.Cells.Add(cellTipoViatico);

                        //Nivel
                        DataGridViewCell cellNivel = new DataGridViewTextBoxCell();
                        cellNivel.Value = empleadoBLL.buscarConId(Convert.ToInt32(formularioAnticipo.IDEMP)).CARGO.NOMCARGO;
                        tempRow.Cells.Add(cellNivel);

                        //DIAS
                        DataGridViewCell cellDias = new DataGridViewTextBoxCell();
                        cellDias.Value = diasViatico;
                        tempRow.Cells.Add(cellDias);

                        //Subtotal
                        DataGridViewCell cellSubtotal = new DataGridViewTextBoxCell();
                        subtotal = d.MONTOTRANSPORTE;
                        cellSubtotal.Value = subtotal;
                        tempRow.Cells.Add(cellSubtotal);

                        listDetalle.Add(new DETALLE_CALCULO()
                        {
                            IDOPCIONN = opcionesNivelBLL.buscarConOpcionNivel(opcionViatico, nivelEmpleado).IDOPCIONN,
                            SUBTOTALMONTO = subtotal
                        });

                        calculo.MONTOCALCULO += subtotal;
                        dgvMonto.Rows.Add(tempRow);
                    }

                    calculo.DETALLE_CALCULO = listDetalle;
                    listCalculo.Add(calculo);
                }

                formularioAnticipo.CALCULOes = listCalculo;
                formularioAnticipo.MONTOTOTAL = calculo.MONTOCALCULO;

                lblTotal.Text = calculo.MONTOCALCULO.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        private void cargarViaticoSubsistencia()
        {
            try
            {
                this.dgvMonto.Rows.Clear();
                {
                    opcionViatico = Convert.ToInt32(opcionesViaticosBLL.buscarConId(2).IDOPCION);
                    DataGridViewRow tempRow = new DataGridViewRow();

                    //TipoViatico
                    DataGridViewCell cellTipoViatico = new DataGridViewTextBoxCell();
                    cellTipoViatico.Value = opcionesViaticosBLL.buscarConId(2).NOMBREOPCION;
                    tempRow.Cells.Add(cellTipoViatico);

                    //Nivel
                    DataGridViewCell cellNivel = new DataGridViewTextBoxCell();
                    cellNivel.Value = empleadoBLL.buscarConId(Convert.ToInt32(formularioAnticipo.IDEMP)).CARGO.NOMCARGO;
                    tempRow.Cells.Add(cellNivel);

                    //DIAS
                    DataGridViewCell cellDias = new DataGridViewTextBoxCell();
                    cellDias.Value = diasViatico;
                    tempRow.Cells.Add(cellDias);

                    //Subtotal
                    DataGridViewCell cellSubtotal = new DataGridViewTextBoxCell();
                    subtotal = opcionesNivelBLL.buscarConOpcionNivel(opcionViatico, nivelEmpleado).VALOROPCION;
                    cellSubtotal.Value = subtotal;
                    tempRow.Cells.Add(cellSubtotal);

                    listDetalle.Add(new DETALLE_CALCULO()
                    {
                        IDOPCIONN = opcionesNivelBLL.buscarConOpcionNivel(opcionViatico, nivelEmpleado).IDOPCIONN,
                        SUBTOTALMONTO = subtotal
                    });

                    calculo.MONTOCALCULO = subtotal;
                    dgvMonto.Rows.Add(tempRow);
                }
                {
                    opcionViatico = Convert.ToInt32(opcionesViaticosBLL.buscarConId(1).IDOPCION);
                    DataGridViewRow tempRow = new DataGridViewRow();

                    //TipoViatico
                    DataGridViewCell cellTipoViatico = new DataGridViewTextBoxCell();
                    cellTipoViatico.Value = opcionesViaticosBLL.buscarConId(1).NOMBREOPCION;
                    tempRow.Cells.Add(cellTipoViatico);

                    //Nivel
                    DataGridViewCell cellNivel = new DataGridViewTextBoxCell();
                    cellNivel.Value = empleadoBLL.buscarConId(Convert.ToInt32(formularioAnticipo.IDEMP)).CARGO.NOMCARGO;
                    tempRow.Cells.Add(cellNivel);

                    //DIAS
                    DataGridViewCell cellDias = new DataGridViewTextBoxCell();
                    cellDias.Value = diasViatico;
                    tempRow.Cells.Add(cellDias);

                    //Subtotal
                    DataGridViewCell cellSubtotal = new DataGridViewTextBoxCell();
                    subtotal = (diasViatico)*opcionesNivelBLL.buscarConOpcionNivel(opcionViatico, nivelEmpleado).VALOROPCION;
                    cellSubtotal.Value = subtotal;
                    tempRow.Cells.Add(cellSubtotal);

                    listDetalle.Add(new DETALLE_CALCULO()
                    {
                        IDOPCIONN = opcionesNivelBLL.buscarConOpcionNivel(opcionViatico, nivelEmpleado).IDOPCIONN,
                        SUBTOTALMONTO = subtotal
                    });

                    calculo.MONTOCALCULO += subtotal;
                    dgvMonto.Rows.Add(tempRow);

                }
                calculo.DETALLE_CALCULO = listDetalle;
                listCalculo.Add(calculo);

                formularioAnticipo.CALCULOes = listCalculo;
                formularioAnticipo.MONTOTOTAL = calculo.MONTOCALCULO;

                lblTotal.Text = calculo.MONTOCALCULO.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        private void cargarViaticoSubsistenciaMovilizacion()
        {
            try
            {
                this.dgvMonto.Rows.Clear();
                {
                    opcionViatico = Convert.ToInt32(opcionesViaticosBLL.buscarConId(2).IDOPCION);
                    DataGridViewRow tempRow = new DataGridViewRow();

                    //TipoViatico
                    DataGridViewCell cellTipoViatico = new DataGridViewTextBoxCell();
                    cellTipoViatico.Value = opcionesViaticosBLL.buscarConId(2).NOMBREOPCION;
                    tempRow.Cells.Add(cellTipoViatico);

                    //Nivel
                    DataGridViewCell cellNivel = new DataGridViewTextBoxCell();
                    cellNivel.Value = empleadoBLL.buscarConId(Convert.ToInt32(formularioAnticipo.IDEMP)).CARGO.NOMCARGO;
                    tempRow.Cells.Add(cellNivel);

                    //DIAS
                    DataGridViewCell cellDias = new DataGridViewTextBoxCell();
                    cellDias.Value = diasViatico;
                    tempRow.Cells.Add(cellDias);

                    //Subtotal
                    DataGridViewCell cellSubtotal = new DataGridViewTextBoxCell();
                    subtotal = opcionesNivelBLL.buscarConOpcionNivel(opcionViatico, nivelEmpleado).VALOROPCION;
                    cellSubtotal.Value = subtotal;
                    tempRow.Cells.Add(cellSubtotal);

                    listDetalle.Add(new DETALLE_CALCULO()
                    {
                        IDOPCIONN = opcionesNivelBLL.buscarConOpcionNivel(opcionViatico, nivelEmpleado).IDOPCIONN,
                        SUBTOTALMONTO = subtotal
                    });

                    calculo.MONTOCALCULO = subtotal;
                    dgvMonto.Rows.Add(tempRow);
                }
                {
                    opcionViatico = Convert.ToInt32(opcionesViaticosBLL.buscarConId(1).IDOPCION);
                    DataGridViewRow tempRow = new DataGridViewRow();

                    //TipoViatico
                    DataGridViewCell cellTipoViatico = new DataGridViewTextBoxCell();
                    cellTipoViatico.Value = opcionesViaticosBLL.buscarConId(1).NOMBREOPCION;
                    tempRow.Cells.Add(cellTipoViatico);

                    //Nivel
                    DataGridViewCell cellNivel = new DataGridViewTextBoxCell();
                    cellNivel.Value = empleadoBLL.buscarConId(Convert.ToInt32(formularioAnticipo.IDEMP)).CARGO.NOMCARGO;
                    tempRow.Cells.Add(cellNivel);

                    //DIAS
                    DataGridViewCell cellDias = new DataGridViewTextBoxCell();
                    cellDias.Value = diasViatico;
                    tempRow.Cells.Add(cellDias);

                    //Subtotal
                    DataGridViewCell cellSubtotal = new DataGridViewTextBoxCell();
                    subtotal = (diasViatico) * opcionesNivelBLL.buscarConOpcionNivel(opcionViatico, nivelEmpleado).VALOROPCION;
                    cellSubtotal.Value = subtotal;
                    tempRow.Cells.Add(cellSubtotal);

                    listDetalle.Add(new DETALLE_CALCULO()
                    {
                        IDOPCIONN = opcionesNivelBLL.buscarConOpcionNivel(opcionViatico, nivelEmpleado).IDOPCIONN,
                        SUBTOTALMONTO = subtotal
                    });

                    calculo.MONTOCALCULO += subtotal;
                    dgvMonto.Rows.Add(tempRow);

                }
                {
                    opcionViatico = Convert.ToInt32(opcionesViaticosBLL.buscarConId(4).IDOPCION);
                    foreach (DETALLE_FORMULARIO d in formularioAnticipo.DETALLE_FORMULARIO)
                    {
                        DataGridViewRow tempRow = new DataGridViewRow();

                        //TipoViatico
                        DataGridViewCell cellTipoViatico = new DataGridViewTextBoxCell();
                        cellTipoViatico.Value = opcionesViaticosBLL.buscarConId(4).NOMBREOPCION;
                        tempRow.Cells.Add(cellTipoViatico);

                        //Nivel
                        DataGridViewCell cellNivel = new DataGridViewTextBoxCell();
                        cellNivel.Value = empleadoBLL.buscarConId(Convert.ToInt32(formularioAnticipo.IDEMP)).CARGO.NOMCARGO;
                        tempRow.Cells.Add(cellNivel);

                        //DIAS
                        DataGridViewCell cellDias = new DataGridViewTextBoxCell();
                        cellDias.Value = diasViatico;
                        tempRow.Cells.Add(cellDias);

                        //Subtotal
                        DataGridViewCell cellSubtotal = new DataGridViewTextBoxCell();
                        subtotal = d.MONTOTRANSPORTE;
                        cellSubtotal.Value = subtotal;
                        tempRow.Cells.Add(cellSubtotal);

                        listDetalle.Add(new DETALLE_CALCULO()
                        {
                            IDOPCIONN = opcionesNivelBLL.buscarConOpcionNivel(opcionViatico, nivelEmpleado).IDOPCIONN,
                            SUBTOTALMONTO = subtotal
                        });

                        calculo.MONTOCALCULO += subtotal;
                        dgvMonto.Rows.Add(tempRow);
                    }

                    calculo.DETALLE_CALCULO = listDetalle;
                    listCalculo.Add(calculo);
                }
                calculo.DETALLE_CALCULO = listDetalle;
                listCalculo.Add(calculo);

                formularioAnticipo.CALCULOes = listCalculo;
                formularioAnticipo.MONTOTOTAL = calculo.MONTOCALCULO;

                lblTotal.Text = calculo.MONTOCALCULO.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }


        }

        private void cargarAlimentacion()
        {
            try
            {
                this.dgvMonto.Rows.Clear();
                opcionViatico = Convert.ToInt32(opcionesViaticosBLL.buscarConId(3).IDOPCION);

                DataGridViewRow tempRow = new DataGridViewRow();

                //TipoViatico
                DataGridViewCell cellTipoViatico = new DataGridViewTextBoxCell();
                cellTipoViatico.Value = opcionesViaticosBLL.buscarConId(3).NOMBREOPCION;
                tempRow.Cells.Add(cellTipoViatico);

                //Nivel
                DataGridViewCell cellNivel = new DataGridViewTextBoxCell();
                cellNivel.Value = empleadoBLL.buscarConId(Convert.ToInt32(formularioAnticipo.IDEMP)).CARGO.NOMCARGO;
                tempRow.Cells.Add(cellNivel);

                //DIAS
                DataGridViewCell cellDias = new DataGridViewTextBoxCell();
                cellDias.Value = diasViatico;
                tempRow.Cells.Add(cellDias);

                //Subtotal
                DataGridViewCell cellSubtotal = new DataGridViewTextBoxCell();
                subtotal = opcionesNivelBLL.buscarConOpcionNivel(opcionViatico, nivelEmpleado).VALOROPCION;
                cellSubtotal.Value = subtotal;
                tempRow.Cells.Add(cellSubtotal);

                listDetalle.Add(new DETALLE_CALCULO()
                {
                    IDOPCIONN = opcionesNivelBLL.buscarConOpcionNivel(opcionViatico, nivelEmpleado).IDOPCIONN,
                    SUBTOTALMONTO = subtotal
                });

                calculo.MONTOCALCULO = detalle.SUBTOTALMONTO;
                calculo.DETALLE_CALCULO = listDetalle;
                listCalculo.Add(calculo);

                formularioAnticipo.CALCULOes = listCalculo;
                formularioAnticipo.MONTOTOTAL = calculo.MONTOCALCULO;

                lblTotal.Text = calculo.MONTOCALCULO.ToString();

                dgvMonto.Rows.Add(tempRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        private void cargarAlimentacionMovilizacion()
        {
            try
            {                
                {
                    this.dgvMonto.Rows.Clear();
                    opcionViatico = Convert.ToInt32(opcionesViaticosBLL.buscarConId(3).IDOPCION);

                    DataGridViewRow tempRow = new DataGridViewRow();

                    //TipoViatico
                    DataGridViewCell cellTipoViatico = new DataGridViewTextBoxCell();
                    cellTipoViatico.Value = opcionesViaticosBLL.buscarConId(3).NOMBREOPCION;
                    tempRow.Cells.Add(cellTipoViatico);

                    //Nivel
                    DataGridViewCell cellNivel = new DataGridViewTextBoxCell();
                    cellNivel.Value = empleadoBLL.buscarConId(Convert.ToInt32(formularioAnticipo.IDEMP)).CARGO.NOMCARGO;
                    tempRow.Cells.Add(cellNivel);

                    //DIAS
                    DataGridViewCell cellDias = new DataGridViewTextBoxCell();
                    cellDias.Value = diasViatico;
                    tempRow.Cells.Add(cellDias);

                    //Subtotal
                    DataGridViewCell cellSubtotal = new DataGridViewTextBoxCell();
                    subtotal = opcionesNivelBLL.buscarConOpcionNivel(opcionViatico, nivelEmpleado).VALOROPCION;
                    cellSubtotal.Value = subtotal;
                    tempRow.Cells.Add(cellSubtotal);

                    listDetalle.Add(new DETALLE_CALCULO()
                    {
                        IDOPCIONN = opcionesNivelBLL.buscarConOpcionNivel(opcionViatico, nivelEmpleado).IDOPCIONN,
                        SUBTOTALMONTO = subtotal
                    });

                    calculo.MONTOCALCULO = subtotal;
                    dgvMonto.Rows.Add(tempRow);
                }
                {
                    opcionViatico = Convert.ToInt32(opcionesViaticosBLL.buscarConId(4).IDOPCION);
                    foreach (DETALLE_FORMULARIO d in formularioAnticipo.DETALLE_FORMULARIO)
                    {
                        DataGridViewRow tempRow = new DataGridViewRow();
                        //TipoViatico
                        DataGridViewCell cellTipoViatico = new DataGridViewTextBoxCell();
                        cellTipoViatico.Value = opcionesViaticosBLL.buscarConId(4).NOMBREOPCION;
                        tempRow.Cells.Add(cellTipoViatico);

                        //Nivel
                        DataGridViewCell cellNivel = new DataGridViewTextBoxCell();
                        cellNivel.Value = empleadoBLL.buscarConId(Convert.ToInt32(formularioAnticipo.IDEMP)).CARGO.NOMCARGO;
                        tempRow.Cells.Add(cellNivel);

                        //DIAS
                        DataGridViewCell cellDias = new DataGridViewTextBoxCell();
                        cellDias.Value = diasViatico;
                        tempRow.Cells.Add(cellDias);

                        //Subtotal
                        DataGridViewCell cellSubtotal = new DataGridViewTextBoxCell();
                        subtotal = d.MONTOTRANSPORTE;
                        cellSubtotal.Value = subtotal;
                        tempRow.Cells.Add(cellSubtotal);

                        listDetalle.Add(new DETALLE_CALCULO()
                        {
                            IDOPCIONN = opcionesNivelBLL.buscarConOpcionNivel(opcionViatico, nivelEmpleado).IDOPCIONN,
                            SUBTOTALMONTO = subtotal
                        });

                        calculo.MONTOCALCULO += subtotal;
                        dgvMonto.Rows.Add(tempRow);
                    }

                    calculo.DETALLE_CALCULO = listDetalle;
                    listCalculo.Add(calculo);
                }

                formularioAnticipo.CALCULOes = listCalculo;
                formularioAnticipo.MONTOTOTAL = calculo.MONTOCALCULO;

                lblTotal.Text = calculo.MONTOCALCULO.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Guardar Todo?", "Guardar Formulario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                formularioAnticipo.ESTADOFORMANTICIPO = "EMITIDO";
                formularioAnticipoBLL.insertarFormulario_anticipo(formularioAnticipo);                                
                this.Close();
                base.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
