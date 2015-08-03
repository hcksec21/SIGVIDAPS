using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SIGVIDAPS_BLL;
using SIGVIDAPS_DAT;
using System.Security.Cryptography;

namespace SIGVIDAPS_FORMS
{
    public partial class frmRegistrarUsuario : Form
    {
        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void frmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            cargarEmpleados();
            cargarPerfiles();
            cargarUsuariosDataGridView();
            dgvUsuarios.ClearSelection();
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

        private void button2_Click(object sender, EventArgs e)
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
            if (!ValContraseña.IsMatch(mskTextBox.Text))
            {
                strError += "La contraseña debe tener al menos 6 caracteres y un número\n";
                bolError = true;
            }
            if(mskTextBox.Text == "")
            {
                strError += "La contraseña es obligatoria\n";
                bolError = true;
            }
            if (cmbPerfil.SelectedIndex == -1)
            {
                strError += "El Perfil es obligatorio\n";
                bolError = true;
            }

            if (!bolError)
            {
                if (MessageBox.Show("¿Guardar el usuario?", "Guardar usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    USUARIO usuario = new USUARIO();
                    usuario.NOMBREUSUARIO = txtNombreUsuario.Text;
                    usuario.IDEMP = Convert.ToInt32(cmbEmpleados.SelectedValue);
                    usuario.CONTRASENAUSUARIO = ComputeHash(mskTextBox.Text);
                    usuario.IDPERFIL = (new clsPerfilBLL()).buscarConId(Convert.ToInt32((Object)cmbPerfil.SelectedValue)).IDPERFIL;
                    usuario.ESTUSUARIO = true;

                    (new clsUsuarioBLL()).insertarUsuario(usuario);

                    MessageBox.Show("El usuarios ha sido registrado satisfactoriamente");
                    cargarUsuariosDataGridView();
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
            chkMostrarCon.Checked = false;
        }

        public void cargarUsuariosDataGridView() { 
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
                    cellEmpleado.Value = usuario.EMPLEADO.NOMBREEMP;
                    tempRow.Cells.Add(cellEmpleado);

                    //Empleado
                    DataGridViewCell cellPerfil = new DataGridViewTextBoxCell();
                    cellPerfil.Value = usuario.PERFIL.NOMBREPERFIL;
                    tempRow.Cells.Add(cellPerfil);

                    //Estado
                    DataGridViewCell cellEstado = new DataGridViewTextBoxCell();
                    cellEstado.Value = usuario.ESTUSUARIO == true ? "Activo" : "Inactivo";
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
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
