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
    public partial class frmModificarEmpleado : Form
    {
        public frmModificarEmpleado()
        {
            InitializeComponent();
            limpiarTodo();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void frmModificarEmpleado_Load(object sender, EventArgs e)
        {
            habilitarControles(false);

            cargarEmpleadosDataGridView();
            cargarCargosEmpleado();

            cmbCargos.SelectedIndex = -1;
            dgvEmpleado.ClearSelection();
            limpiarTodo();
        }

        //CARGAR EMPLEADOS EN DATAGRIDVIEW
        private void cargarEmpleadosDataGridView()
        {
            try
            {
                this.dgvEmpleado.Rows.Clear();
                List<EMPLEADO> lstEmpleados = (new clsEmpleadoBLL()).obtenerTodosEmpleados();

                foreach (EMPLEADO empleado in lstEmpleados)
                {
                    DataGridViewRow tempRow = new DataGridViewRow();

                    //ID
                    DataGridViewCell cellId = new DataGridViewTextBoxCell();
                    cellId.Value = empleado.IDEMP;
                    tempRow.Cells.Add(cellId);

                    //NOMBRE
                    DataGridViewCell cellNombre = new DataGridViewTextBoxCell();
                    cellNombre.Value = empleado.NOMBREEMP;
                    tempRow.Cells.Add(cellNombre);

                    //APELLIDO
                    DataGridViewCell cellApellido = new DataGridViewTextBoxCell();
                    cellApellido.Value = empleado.APELLIDOEMP;
                    tempRow.Cells.Add(cellApellido);

                    //CÉDULA
                    DataGridViewCell cellCedula = new DataGridViewTextBoxCell();
                    cellCedula.Value = empleado.CEDULAEMP;
                    tempRow.Cells.Add(cellCedula);

                    //NIVEL
                    CARGO objCargo = (new clsCargoBLL()).buscarConId(Convert.ToInt32(empleado.IDCARGO));
                    DataGridViewCell cellNivel = new DataGridViewTextBoxCell();
                    cellNivel.Value = objCargo.IDNIVEL;
                    tempRow.Cells.Add(cellNivel);

                    //CARGO                    
                    DataGridViewCell cellCargo = new DataGridViewTextBoxCell();
                    cellCargo.Value = objCargo.NOMCARGO;
                    tempRow.Cells.Add(cellCargo);

                    //DIRECCION
                    DataGridViewCell cellDireccion = new DataGridViewTextBoxCell();
                    cellDireccion.Value = empleado.DIREMP;
                    tempRow.Cells.Add(cellDireccion);

                    //TELEFONO
                    DataGridViewCell cellTelefono = new DataGridViewTextBoxCell();
                    cellTelefono.Value = empleado.TELEMP;
                    tempRow.Cells.Add(cellTelefono);

                    //ESTADO
                    DataGridViewCell cellEstado = new DataGridViewTextBoxCell();
                    cellEstado.Value = ((Boolean)empleado.ESTEMP) ? "ACTIVO" : "INACTIVO";
                    tempRow.Cells.Add(cellEstado);

                    tempRow.Tag = empleado.IDEMP;
                    dgvEmpleado.Rows.Add(tempRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de Empleados\n" + ex.Message);
            }
        }

        private void dgvEmpleado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleado.SelectedRows.Count != 0)
            {
                txtNombres.Text = dgvEmpleado.Rows[dgvEmpleado.SelectedRows[0].Index].Cells[1].Value.ToString();
                txtApellidos.Text = dgvEmpleado.Rows[dgvEmpleado.SelectedRows[0].Index].Cells[2].Value.ToString();
                txtCedula.Text = dgvEmpleado.Rows[dgvEmpleado.SelectedRows[0].Index].Cells[3].Value.ToString();
                lblNivel.Text = dgvEmpleado.Rows[dgvEmpleado.SelectedRows[0].Index].Cells[4].Value.ToString();
                cmbCargos.Text = dgvEmpleado.Rows[dgvEmpleado.SelectedRows[0].Index].Cells[5].Value.ToString();
                txtDireccion.Text = dgvEmpleado.Rows[dgvEmpleado.SelectedRows[0].Index].Cells[6].Value.ToString();
                txtTelefono.Text = dgvEmpleado.Rows[dgvEmpleado.SelectedRows[0].Index].Cells[7].Value.ToString();
                cmbEstado.Text = dgvEmpleado.Rows[dgvEmpleado.SelectedRows[0].Index].Cells[8].Value.ToString();
            }
        }

        private void habilitarControles(Boolean flag)
        {
            txtNombres.Enabled = flag;
            txtApellidos.Enabled = flag;
            txtCedula.Enabled = flag;
            txtDireccion.Enabled = flag;
            txtTelefono.Enabled = flag;
            cmbCargos.Enabled = flag;
            cmbEstado.Enabled = flag;
        }

        //METODO PARA OBTENER LOS CARGOS
        public void cargarCargosEmpleado()
        {
            try
            {
                List<CARGO> lstCargos = (new clsCargoBLL()).obtenerTodosCargos();
                cmbCargos.ValueMember = "IDCARGO";
                cmbCargos.DisplayMember = "NOMCARGO";
                cmbCargos.DataSource = lstCargos;
                cmbCargos.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los cargos. " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvEmpleado.SelectedRows.Count > 0)
                habilitarControles(true);
            else
                MessageBox.Show("Seleccione un registro");
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            String strError = "";
            Boolean bolError = false;

            if (txtNombres.Text == "")
            {
                strError += "El nombre es obligatorio\n";
                bolError = true;
            }
            if (txtApellidos.Text == "")
            {
                strError += "El apellido es obligatorio\n";
                bolError = true;
            }
            if (txtCedula.Text == "")
            {
                strError += "La cédula es obligatoria\n";
                bolError = true;
            }
            if (cmbCargos.SelectedIndex == -1)
            {
                strError += "El cargo es obligatorio\n";
                bolError = true;
            }
            if (txtDireccion.Text == "")
            {
                strError += "La dirección es obligatoria\n";
                bolError = true;
            }
            if (txtTelefono.Text == "")
            {
                strError += "El teléfono es obligatorio\n";
                bolError = true;
            }
            if (!VerificarCedula(txtCedula.Text))
            {
                strError += "La cédula no es válida\n";
                bolError = true;
            }

            if (!bolError)
            {
                if (MessageBox.Show("¿Actualizar el registro de empleado?", "Actualizar empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EMPLEADO empleado = new EMPLEADO();
                    empleado.APELLIDOEMP = txtApellidos.Text;

                    object id = cmbCargos.SelectedValue;
                    int selectedId = Convert.ToInt32(id);

                    empleado.IDCARGO = (new clsCargoBLL()).buscarConId(selectedId).IDCARGO;
                    empleado.CEDULAEMP = txtCedula.Text;
                    empleado.DIREMP = txtDireccion.Text;
                    empleado.ESTEMP = ((string)cmbEstado.SelectedItem == "ACTIVO") ? true : false;
                    empleado.NOMBREEMP = txtNombres.Text;
                    empleado.TELEMP = txtTelefono.Text;
                    empleado.IDEMP = Int32.Parse(dgvEmpleado.Rows[dgvEmpleado.SelectedRows[0].Index].Cells[0].Value.ToString());

                    (new clsEmpleadoBLL()).actualizarEmpleado((int)empleado.IDEMP, empleado);

                }

                MessageBox.Show("El empleado ha sido registrado satisfactoriamente");
                cargarEmpleadosDataGridView();
                limpiarTodo();
                habilitarControles(false);
                dgvEmpleado.ClearSelection();
            }
            else
            {
                MessageBox.Show(strError);
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;

            if (txtCedula.Text.Length == 10)
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
        }


        public bool VerificarCedula(String ced)
        {
            long isNumeric;
            var total = 0;
            const int tamanoLongitudCedula = 10;
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            const int numeroProvincias = 24;
            const int tercerDigito = 6;

            if (long.TryParse(ced, out isNumeric) && ced.Length == tamanoLongitudCedula)
            {
                var provincia = Convert.ToInt32(string.Concat(ced[0], ced[1], string.Empty));
                var digitoTres = Convert.ToInt32(ced[2] + string.Empty);
                if ((provincia > 0 && provincia <= numeroProvincias) && digitoTres < tercerDigito)
                {
                    var digitoVerificadorRecibido = Convert.ToInt32(ced[9] + string.Empty);
                    for (var k = 0; k < coeficientes.Length; k++)
                    {
                        var valor = Convert.ToInt32(coeficientes[k] + string.Empty) *
                            Convert.ToInt32(ced[k] + string.Empty);
                        total = valor >= 10 ? total + (valor - 9) : total + valor;
                    }
                    var digitoVerificadorObtenido = total >= 10 ? (total % 10) != 0 ?
                        10 - (total % 10) : (total % 10) : total;

                    return digitoVerificadorObtenido == digitoVerificadorRecibido;
                }

                return false;
            }

            return false;
        }

        private void limpiarTodo()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtCedula.Text = "";
            cmbCargos.SelectedIndex = -1;
            lblNivel.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            cmbEstado.SelectedIndex = -1;
        }

        private void cmbCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCargos.SelectedIndex >= 0)
            {
                String strId = cmbCargos.SelectedValue.ToString();
                int idCargo = Int32.Parse(strId.ToString());

                CARGO objCargo = (new clsCargoBLL()).buscarConId(idCargo);
                NIVEL objNivel = (new clsNivelBLL()).buscarConId((int)objCargo.IDNIVEL);

                lblNivel.Text = objNivel.COD_NIVEL;
            }
        }



    }
}
