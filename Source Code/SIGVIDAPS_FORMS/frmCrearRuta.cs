﻿using System;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String strError = "";
            Boolean bolError = false;

            if (txtLugarLlegada.Text == "")
            {
                strError += "El lugar de llegada es obligatorio\n";
                bolError = true;
            }
            if (txtLugarSalida.Text == "")
            {
                strError += "El lugar de salida es obligatorio\n";
                bolError = true;
            }


            if (!bolError)
            {
                if (MessageBox.Show("¿Guardar nueva Ruta?", "Guardar Ruta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {                    
                    new clsRutaBLL().insertarRuta(
                        new RUTA
                        {
                            
                            CODRUTA = txtLugarLlegada.Text.Substring(0,3) + "-" + txtLugarSalida.Text.Substring(0,3),
                            LUGARLLEGADA = txtLugarLlegada.Text,
                            LUGARSALIDA = txtLugarSalida.Text
                        }
                    );
                }

                MessageBox.Show("La ruta ha sido registrada satisfactoriamente");
                cargarRutasDataGridView();
                limpiarTodo();
            }
            else
            {
                MessageBox.Show(strError);
            }
        }

        private void limpiarTodo()
        {
            txtLugarLlegada.Text = "";
            txtLugarSalida.Text = "";
            dgvRutas.ClearSelection();
        }


    }
}
