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
            ConfigurarDGV();
            mtdCargarUsuarios();
            mtdCargarRoles();
            mtdLimpiarCampos();
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void ConfigurarDGV()
        {
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.RowHeadersVisible = false;
        }

        private void mtdCargarUsuarios()
        {
            dgvUsuarios.DataSource = cd_Usuarios.mtdConsultarUsuarios();
        }

        private void mtdCargarRoles()
        {
            cboRol.DataSource = cd_Usuarios.mtdConsultarRoles();
            cboRol.DisplayMember = "Nombre";
            cboRol.ValueMember = "CodigoRol";
            cboRol.SelectedIndex = -1;
        }

        private void mtdLimpiarCampos()
        {
            lblCodigoUsuario.Text = "";
            cboRol.SelectedIndex = -1;
            txtNombre.Text = "";
            txtContraseña.Text = "";
            dtpFechaRegistro.Value = DateTime.Now;
            cboEstado.SelectedIndex = -1;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            cd_Usuarios.mtdAgregarUsuario(
               int.Parse(cboRol.SelectedValue.ToString()),
               txtNombre.Text,
               txtContraseña.Text,
               dtpFechaRegistro.Value,
               cboEstado.Text
           );
            mtdCargarUsuarios();
            mtdLimpiarCampos();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblCodigoUsuario.Text)) return;

            cd_Usuarios.mtdActualizarUsuario(
                int.Parse(lblCodigoUsuario.Text),
                int.Parse(cboRol.SelectedValue.ToString()),
                txtNombre.Text,
                txtContraseña.Text,
                dtpFechaRegistro.Value,
                cboEstado.Text
            );
            mtdCargarUsuarios();
            mtdLimpiarCampos();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblCodigoUsuario.Text)) return;

            cd_Usuarios.mtdEliminarUsuario(int.Parse(lblCodigoUsuario.Text));
            mtdCargarUsuarios();
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
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

            lblCodigoUsuario.Text = fila.Cells["CodigoUsuario"].Value.ToString();
            cboRol.SelectedValue = fila.Cells["CodigoRol"].Value;
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtContraseña.Text = fila.Cells["Clave"].Value.ToString();
            dtpFechaRegistro.Value = Convert.ToDateTime(fila.Cells["FechaRegistro"].Value);
            cboEstado.Text = fila.Cells["Estado"].Value.ToString();
        }
    }
}
