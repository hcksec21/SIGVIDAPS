using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIGVIDAPS_DAT;
using SIGVIDAPS_BLL;

namespace SIGVIDAPS_FORMS
{
    public partial class frmIngresoUsuarios : Form
    {
        public frmIngresoUsuarios()
        {
            InitializeComponent();
        }

        private void frmLoginUsuario_Load(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && mskPassword.Text != "")
            {
                if ((new clsUsuarioBLL()).loggin(txtNombre.Text,ComputeHash(mskPassword.Text)))
                {
                   
                    this.Hide();
                    var menu = new mdiMenu(txtNombre.Text);
                    menu.Closed += (s, args) => this.Close();
                    menu.Show();
                    
                }
                else
                {
                    lblMensaje.Text = "Credenciales Incorrectas";
                }
            }            
        }
    }
}
