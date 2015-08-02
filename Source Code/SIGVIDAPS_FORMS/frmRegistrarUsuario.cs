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

            if (!bolError)
            {
                if (MessageBox.Show("¿Guardar el empleado?", "Guardar empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    USUARIO usuario = new USUARIO();
                    usuario.NOMBREUSUARIO = txtNombreUsuario.Text;
                    usuario.IDEMP = Convert.ToInt32(cmbEmpleados.SelectedValue);
                    usuario.CONTRASENAUSUARIO = ComputeHash(mskTextBox.Text, "MD5", null);
                    usuario.IDPERFIL = (new clsPerfilBLL()).buscarConId(Convert.ToInt32((Object)cmbPerfil.SelectedValue)).IDPERFIL;

                    (new clsUsuarioBLL()).insertarUsuario(usuario);

                    MessageBox.Show("El empleado ha sido registrado satisfactoriamente");
                    cargarUsuariosDataGridView();
                }
            }
            else
            {
                MessageBox.Show(strError);
            }
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

                    tempRow.Tag = usuario.IDUSUARIO;
                    dgvUsuarios.Rows.Add(tempRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de Cargos\n" + ex.Message);
            }        
        }
            

        public static string ComputeHash(string plainText,
                                     string hashAlgorithm,
                                     byte[] saltBytes)
        {
            // If salt is not specified, generate it on the fly.
            if (saltBytes == null)
            {
                // Define min and max salt sizes.
                int minSaltSize = 4;
                int maxSaltSize = 8;

                // Generate a random number for the size of the salt.
                Random random = new Random();
                int saltSize = random.Next(minSaltSize, maxSaltSize);

                // Allocate a byte array, which will hold the salt.
                saltBytes = new byte[saltSize];

                // Initialize a random number generator.
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

                // Fill the salt with cryptographically strong byte values.
                rng.GetNonZeroBytes(saltBytes);
            }

            // Convert plain text into a byte array.
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            // Allocate array, which will hold plain text and salt.
            byte[] plainTextWithSaltBytes =
                    new byte[plainTextBytes.Length + saltBytes.Length];

            // Copy plain text bytes into resulting array.
            for (int i = 0; i < plainTextBytes.Length; i++)
                plainTextWithSaltBytes[i] = plainTextBytes[i];

            // Append salt bytes to the resulting array.
            for (int i = 0; i < saltBytes.Length; i++)
                plainTextWithSaltBytes[plainTextBytes.Length + i] = saltBytes[i];

            // Because we support multiple hashing algorithms, we must define
            // hash object as a common (abstract) base class. We will specify the
            // actual hashing algorithm class later during object creation.
            HashAlgorithm hash;

            // Make sure hashing algorithm name is specified.
            if (hashAlgorithm == null)
                hashAlgorithm = "";

            // Initialize appropriate hashing algorithm class.
            switch (hashAlgorithm.ToUpper())
            {
                case "SHA1":
                    hash = new SHA1Managed();
                    break;

                case "SHA256":
                    hash = new SHA256Managed();
                    break;

                case "SHA384":
                    hash = new SHA384Managed();
                    break;

                case "SHA512":
                    hash = new SHA512Managed();
                    break;

                default:
                    hash = new MD5CryptoServiceProvider();
                    break;
            }

            // Compute hash value of our plain text with appended salt.
            byte[] hashBytes = hash.ComputeHash(plainTextWithSaltBytes);

            // Create array which will hold hash and original salt bytes.
            byte[] hashWithSaltBytes = new byte[hashBytes.Length +
                                                saltBytes.Length];

            // Copy hash bytes into resulting array.
            for (int i = 0; i < hashBytes.Length; i++)
                hashWithSaltBytes[i] = hashBytes[i];

            // Append salt bytes to the result.
            for (int i = 0; i < saltBytes.Length; i++)
                hashWithSaltBytes[hashBytes.Length + i] = saltBytes[i];

            // Convert result into a base64-encoded string.
            string hashValue = Convert.ToBase64String(hashWithSaltBytes);

            // Return the result.
            return hashValue;
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
    }
}
