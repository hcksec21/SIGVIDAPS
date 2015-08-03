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
    public partial class frmEliminarUsuario : Form
    {
        public frmEliminarUsuario()
        {
            InitializeComponent();
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

                    tempRow.Tag = usuario.IDUSUARIO;
                    dgvUsuarios.Rows.Add(tempRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de Cargos\n" + ex.Message);
            }
        }

        private void frmEliminarUsuario_Load(object sender, EventArgs e)
        {
            cargarUsuariosDataGridView();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar el usuario?", "Eliminar usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                (new clsUsuarioBLL()).eliminarUsuario(Int32.Parse(dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells[0].Value.ToString()));

                MessageBox.Show("El usuario ha sido eliminado satisfactoriamente");
                cargarUsuariosDataGridView();
            }
        }
    }
}
