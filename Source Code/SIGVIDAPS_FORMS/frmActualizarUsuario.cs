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
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace SIGVIDAPS_FORMS
{
    public partial class frmActualizarUsuario : Form
    {
        private bool cambioContraseña;
        public frmActualizarUsuario()
        {
            InitializeComponent();
        }

        private void habilitarControles(Boolean flag)
        {
            txtNombreUsuario.Enabled = flag;
            cmbEmpleados.Enabled = flag;
            cmbPerfil.Enabled = flag;
            btnGuardar.Enabled = flag;
            chkCambiarContraseña.Enabled = flag;
            chkMostrarCon.Enabled = flag;
            cmbEstado.Enabled = flag;
        }

        private void frmActualizarUsuario_Load(object sender, EventArgs e)
        {
            habilitarControles(false);
            mskTextBox.Enabled = false;
            cargarEmpleados();
            cargarPerfiles();
            dgvUsuarios.ClearSelection();
            cargarUsuariosDataGridView();
            limpiarInfo();
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
                MessageBox.Show("Error al obtener los Niveles. " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cargarPerfiles()
        {
            try
            {
                List<PERFIL> lstPerfiles = (new clsPerfilBLL()).obtenerTodosPerfiles();
                cmbPerfil.ValueMember = "IDPERFIL";
                cmbPerfil.DisplayMember = "NOMBREPERFIL";
                cmbPerfil.DataSource = lstPerfiles;
                cmbPerfil.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los Perfiles. " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void cargarUsuariosDataGridView()
        {
            try
            {
                this.dgvUsuarios.Rows.Clear();
                List<USUARIO> lstUsuario = (new clsUsuarioBLL()).obtenerTodosLosUsuarios();

                foreach (USUARIO usuario in lstUsuario)
                {
                    DataGridViewRow tempRow = new DataGridViewRow();

                    //ID
                    DataGridViewCell cellId = new DataGridViewTextBoxCell();
                    cellId.Value = usuario.IDUSUARIO;
                    tempRow.Cells.Add(cellId);

                    //NOMBRE
                    DataGridViewCell cellNombreUsuario = new DataGridViewTextBoxCell();
                    cellNombreUsuario.Value = usuario.NOMBREUSUARIO;
                    tempRow.Cells.Add(cellNombreUsuario);

                    //Empleado
                    DataGridViewCell cellEmpleado = new DataGridViewTextBoxCell();
                    cellEmpleado.Value = usuario.EMPLEADO.NOMBRECOMPLETO;
                    tempRow.Cells.Add(cellEmpleado);

                    //Empleado
                    DataGridViewCell cellPerfil = new DataGridViewTextBoxCell();
                    cellPerfil.Value = usuario.PERFIL.NOMBREPERFIL;
                    tempRow.Cells.Add(cellPerfil);

                    //ESTADO
                    DataGridViewCell cellEstado = new DataGridViewTextBoxCell();
                    cellEstado.Value = usuario.ESTUSUARIO == true ? "ACTIVO" : "INACTIVO";
                    tempRow.Cells.Add(cellEstado);

                    tempRow.Tag = usuario.IDUSUARIO;
                    dgvUsuarios.Rows.Add(tempRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de Cargos\n" + ex.Message);
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count != 0)
            {
                txtNombreUsuario.Text = dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells[1].Value.ToString();
                cmbEmpleados.Text = dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells[2].Value.ToString();
                cmbPerfil.Text = dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells[3].Value.ToString();
                cmbEstado.Text = dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells[4].Value.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
                habilitarControles(true);
            else
                MessageBox.Show("Seleccione un registro");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            String strError = "";
            Boolean bolError = false;

            Regex Val = new Regex(@"^[a-zA-Z0-9_]*$");
            if (!Val.IsMatch(txtNombreUsuario.Text))
            {
                strError += "El nombre de Usuario debe tener solo letras y números, sin espacios\n";
                bolError = true;
            }
            if (txtNombreUsuario.Text == "")
            {
                strError += "El nombre es obligatorio\n";
                bolError = true;
            }
            if (cmbEmpleados.SelectedIndex == -1)
            {
                strError += "Empleado es obligatrio\n";
                bolError = true;
            }
            Regex ValContraseña = new Regex(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,12})$");
            if (!ValContraseña.IsMatch(mskTextBox.Text) && cambioContraseña)
            {
                strError += "La contraseña debe tener al menos 6 caracteres y un número\n";
                bolError = true;
            }
            if (cmbEstado.SelectedIndex == -1)
            {
                strError += "El Estado es obligatorio\n";
                bolError = true;
            }
            if (cmbPerfil.SelectedIndex == -1)
            {
                strError += "El Perfil es obligatorio\n";
                bolError = true;
            }

            if (!bolError)
            {
                if (MessageBox.Show("¿Actualizar el usuario?", "Guardar usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    USUARIO usuario = new USUARIO();
                    usuario.NOMBREUSUARIO = txtNombreUsuario.Text;
                    usuario.IDEMP = Convert.ToInt32(cmbEmpleados.SelectedValue);
                    usuario.CONTRASENAUSUARIO = ComputeHash(mskTextBox.Text);
                    usuario.IDPERFIL = (new clsPerfilBLL()).buscarConId(Convert.ToInt32((Object)cmbPerfil.SelectedValue)).IDPERFIL;
                    usuario.ESTUSUARIO = ((string)cmbEstado.SelectedItem == "ACTIVO") ? true : false;
                    (new clsUsuarioBLL()).actualizarUsuario(Int32.Parse(dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells[0].Value.ToString()), usuario);

                    MessageBox.Show("El usuario ha sido actualizado satisfactoriamente");
                    cargarUsuariosDataGridView();
                    habilitarControles(false);
                    mskTextBox.Enabled = false;
                    limpiarInfo();
                }
            }
            else
            {
                MessageBox.Show(strError);
            }
        }

        private void limpiarInfo()
        {
            txtNombreUsuario.Text = "";
            cmbEmpleados.SelectedIndex = -1;
            cmbPerfil.SelectedIndex = -1;
            mskTextBox.Text = "";
            chkCambiarContraseña.Checked = false;
            chkMostrarCon.Checked = false;
            cmbEstado.SelectedIndex = -1;
            dgvUsuarios.ClearSelection();
        }

        public string ComputeHash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private void chkCambiarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCambiarContraseña.Checked)
            {
                mskTextBox.Enabled = true;
                cambioContraseña = true;
            }
            else
            {
                mskTextBox.Enabled = false;
                cambioContraseña = false;
            }

        }

        private void chkMostrarCon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarCon.Checked)
            {
                mskTextBox.PasswordChar = '\0';
            }
            else
            {
                mskTextBox.PasswordChar = '*';
            }
        }
    }
}
