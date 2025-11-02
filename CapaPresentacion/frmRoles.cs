using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmRoles : Form
    {
        cdRoles cd_Roles = new cdRoles();

        public frmRoles()
        {
            InitializeComponent();
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            try
            {
                MtdConsultaRoles();
                mtdLlenarCombos();
                mtdLimpiarCampos();
                lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario Roles:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MtdConsultaRoles()
        {
            try
            {
                DataTable dt = cd_Roles.mtdConsultarTablaRoles();
                dgvRoles.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar roles:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtdLlenarCombos()
        {
            try
            {
                string[] opciones = { "Sí", "No" };
                cboxFormConsul.Items.AddRange(opciones);
                cboxFormAdd.Items.AddRange(opciones);
                cboxFormEdi.Items.AddRange(opciones);
                cboxFormDel.Items.AddRange(opciones);
                cboxAccesoDashboard.Items.AddRange(opciones);
                cboxAccesoReportes.Items.AddRange(opciones);
                cboxAccesoConfiguracion.Items.AddRange(opciones);

                cboxEstado.Items.Add("Activo");
                cboxEstado.Items.Add("Inactivo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar opciones:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ValorBit(string opcion)
        {
            return opcion == "Sí" ? 1 : 0;
        }


        private void mtdLimpiarCampos()
        {
            lblCodigoRol.Text = "";
            txtNombreRol.Text = "";
            cboxFormConsul.Text = "";
            cboxFormAdd.Text = "";
            cboxFormEdi.Text = "";
            cboxFormDel.Text = "";
            cboxAccesoDashboard.Text = "";
            cboxAccesoReportes.Text = "";
            cboxAccesoConfiguracion.Text = "";
            cboxEstado.Text = "";
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreRol.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de rol.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
           }
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                int CodigoRol = int.Parse(lblCodigoRol.Text);
                string Nombre = txtNombreRol.Text;
                int FormConsul = ValorBit(cboxFormConsul.Text);
                int FormAdd = ValorBit(cboxFormAdd.Text);
                int FormEdi = ValorBit(cboxFormEdi.Text);
                int FormDel = ValorBit(cboxFormDel.Text);
                int AccesoDashboard = ValorBit(cboxAccesoDashboard.Text);
                int AccesoReportes = ValorBit(cboxAccesoReportes.Text);
                int AccesoConfiguracion = ValorBit(cboxAccesoConfiguracion.Text);
                string Estado = cboxEstado.Text;
                string UsuarioAuditoria = "Sistema";
                DateTime FechaAuditoria = DateTime.Now;

                cd_Roles.mtdActualizarRol(CodigoRol, Nombre, FormConsul, FormAdd, FormEdi, FormDel,
                    AccesoDashboard, AccesoReportes, AccesoConfiguracion,
                    Estado, UsuarioAuditoria, FechaAuditoria);

                MtdConsultaRoles();
                mtdLimpiarCampos();

                MessageBox.Show("Rol actualizado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar rol:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                string Nombre = txtNombreRol.Text;
                int FormConsul = ValorBit(cboxFormConsul.Text);
                int FormAdd = ValorBit(cboxFormAdd.Text);
                int FormEdi = ValorBit(cboxFormEdi.Text);
                int FormDel = ValorBit(cboxFormDel.Text);
                int AccesoDashboard = ValorBit(cboxAccesoDashboard.Text);
                int AccesoReportes = ValorBit(cboxAccesoReportes.Text);
                int AccesoConfiguracion = ValorBit(cboxAccesoConfiguracion.Text);
                string Estado = cboxEstado.Text;
                string UsuarioAuditoria = "Sistema";
                DateTime FechaAuditoria = DateTime.Now;

                cd_Roles.mtdAgregarRol(Nombre, FormConsul, FormAdd, FormEdi, FormDel,
                    AccesoDashboard, AccesoReportes, AccesoConfiguracion,
                    Estado, UsuarioAuditoria, FechaAuditoria);

                MtdConsultaRoles();
                mtdLimpiarCampos();

                MessageBox.Show("Rol guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar rol:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lblCodigoRol.Text))
                {
                    MessageBox.Show("Debe seleccionar un rol para eliminar.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("¿Está seguro de eliminar este rol?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int CodigoRol = int.Parse(lblCodigoRol.Text);
                    cd_Roles.mtdEliminarRol(CodigoRol);

                    MtdConsultaRoles();
                    mtdLimpiarCampos();

                    MessageBox.Show("Rol eliminado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar rol:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            mtdLimpiarCampos();
        }

        private void dgvRoles_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                lblCodigoRol.Text = dgvRoles.SelectedCells[0].Value.ToString();
                txtNombreRol.Text = dgvRoles.SelectedCells[1].Value.ToString();
                cboxFormConsul.Text = (bool)dgvRoles.SelectedCells[2].Value ? "Sí" : "No";
                cboxFormAdd.Text = (bool)dgvRoles.SelectedCells[3].Value ? "Sí" : "No";
                cboxFormEdi.Text = (bool)dgvRoles.SelectedCells[4].Value ? "Sí" : "No";
                cboxFormDel.Text = (bool)dgvRoles.SelectedCells[5].Value ? "Sí" : "No";
                cboxAccesoDashboard.Text = (bool)dgvRoles.SelectedCells[6].Value ? "Sí" : "No";
                cboxAccesoReportes.Text = (bool)dgvRoles.SelectedCells[7].Value ? "Sí" : "No";
                cboxAccesoConfiguracion.Text = (bool)dgvRoles.SelectedCells[8].Value ? "Sí" : "No";
                cboxEstado.Text = dgvRoles.SelectedCells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar rol:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
