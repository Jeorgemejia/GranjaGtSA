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
            try
            {
                ConfigurarDGV();
                mtdCargarUsuarios();
                mtdCargarRoles();
                mtdLimpiarCampos();
                lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                dgvUsuarios.DataSource = cd_Usuarios.mtdConsultarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtdCargarRoles()
        {
            try
            {
                cboRol.DataSource = cd_Usuarios.mtdConsultarRoles();
                cboRol.DisplayMember = "Nombre";
                cboRol.ValueMember = "CodigoRol";
                cboRol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private bool ValidarCampos()
        {
            if (cboRol.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un rol.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Ingrese una contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un estado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                cd_Usuarios.mtdAgregarUsuario(
                   int.Parse(cboRol.SelectedValue.ToString()),
                   txtNombre.Text,
                   txtContraseña.Text,
                   dtpFechaRegistro.Value,
                   cboEstado.Text
               );
                mtdCargarUsuarios();
                mtdLimpiarCampos();
                MessageBox.Show("Usuario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar usuario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lblCodigoUsuario.Text))
                    return;

                if (!ValidarCampos()) return;

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
                MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar usuario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lblCodigoUsuario.Text))
                    return;

                if (MessageBox.Show("¿Seguro que desea eliminar el usuario?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cd_Usuarios.mtdEliminarUsuario(int.Parse(lblCodigoUsuario.Text));
                    mtdCargarUsuarios();
                    mtdLimpiarCampos();
                    MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            mtdLimpiarCampos();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar usuario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

