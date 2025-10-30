using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        cdUsuarios cd_Usuarios = new cdUsuarios();

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            MtdConsultaUsuarios();
            mtdLlenarComboRoles();
            mtdLimpiarCampos();
            dtpFechaRegistro.Value = DateTime.Now;
        }

        private void MtdConsultaUsuarios()
        {
            DataTable dt = cd_Usuarios.mtdConsultarTablaUsuarios();
            dgvUsuarios.DataSource = dt;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;
        }

        private void mtdLlenarComboRoles()
        {
            DataTable dt = cd_Usuarios.mtdConsultarRoles();
            cboxRol.DisplayMember = "Nombre";
            cboxRol.ValueMember = "CodigoRol";
            cboxRol.DataSource = dt;

            cboxEstado.Items.Clear();
            cboxEstado.Items.Add("Activo");
            cboxEstado.Items.Add("Inactivo");
        }

      
        private void mtdLimpiarCampos()
        {
            lblCodigoUsuario.Text = "";
            cboxRol.SelectedIndex = -1;
            txtNombre.Clear();
            txtClave.Clear();
            cboxEstado.SelectedIndex = -1;
            dtpFechaRegistro.Value = DateTime.Now;
        }

     


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int CodigoRol = (int)cboxRol.SelectedValue;
                string Nombre = txtNombre.Text;
                string Clave = txtClave.Text;
                DateTime FechaRegistro = dtpFechaRegistro.Value;
                string Estado = cboxEstado.Text;
                string UsuarioAuditoria = "Sistema";
                DateTime FechaAuditoria = DateTime.Now;

                cd_Usuarios.mtdAgregarUsuario(CodigoRol, Nombre, Clave, FechaRegistro, Estado, UsuarioAuditoria, FechaAuditoria);
                MtdConsultaUsuarios();
                mtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblCodigoUsuario.Text))
            {
                MessageBox.Show("Seleccione un usuario para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int CodigoUsuario = int.Parse(lblCodigoUsuario.Text);
                int CodigoRol = (int)cboxRol.SelectedValue;
                string Nombre = txtNombre.Text;
                string Clave = txtClave.Text;
                DateTime FechaRegistro = dtpFechaRegistro.Value;
                string Estado = cboxEstado.Text;
                string UsuarioAuditoria = "Sistema";
                DateTime FechaAuditoria = DateTime.Now;

                cd_Usuarios.mtdActualizarUsuario(CodigoUsuario, CodigoRol, Nombre, Clave, FechaRegistro, Estado, UsuarioAuditoria, FechaAuditoria);
                MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MtdConsultaUsuarios();
                mtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblCodigoUsuario.Text))
            {
                MessageBox.Show("Seleccione un usuario para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int CodigoUsuario = int.Parse(lblCodigoUsuario.Text);
            cd_Usuarios.mtdEliminarUsuario(CodigoUsuario);
            MtdConsultaUsuarios();
            mtdLimpiarCampos();

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            mtdLimpiarCampos();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
                lblCodigoUsuario.Text = fila.Cells[0].Value.ToString();
                cboxRol.Text = fila.Cells[1].Value.ToString();
                txtNombre.Text = fila.Cells[2].Value.ToString();
                txtClave.Text = fila.Cells[3].Value.ToString();
                dtpFechaRegistro.Value = Convert.ToDateTime(fila.Cells[4].Value);
                cboxEstado.Text = fila.Cells[5].Value.ToString();
            }
        }
    }
}
