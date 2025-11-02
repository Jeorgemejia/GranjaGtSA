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
    public partial class frmClientes : Form
    {
        cdConexiones cdConexiones = new cdConexiones();
        cdClientes cdClientes = new cdClientes();
        public frmClientes()
        {
            InitializeComponent();
        }

        public void MtdLimpiarCampos()
        {
            lblCodigoCliente.Text = "";
            txtNombreCliente.Text = "";
            txtTipoCliente.Text = "";
            txtTelefonoCliente.Text = "";
            txtCorreoCliente.Text = "";
            txtDireccionCliente.Text = "";
            cboxEstadoCliente.SelectedIndex = -1;
        }
        public void mtdConsultaClientes()
        {
            DataTable dtClientes = cdClientes.MtdConsultarClientes();
            dgvClientes.DataSource = dtClientes;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string NombreCliente =  txtNombreCliente.Text;
            string TipoCliente = txtTipoCliente.Text;
            int Telefono = int.Parse( txtTelefonoCliente.Text);
            string CorreoCliente = txtCorreoCliente.Text;
            string DireccionCliente = txtDireccionCliente.Text;
            string EstadoCliente = cboxEstadoCliente.Text;
            string UsuarioAuditoria = "";
            DateTime FechaAuditoria = DateTime.Now;
            cdClientes.MtdAgregarCliente(NombreCliente, TipoCliente, Telefono, CorreoCliente, DireccionCliente, EstadoCliente, UsuarioAuditoria, FechaAuditoria);
            mtdConsultaClientes();
            MtdLimpiarCampos();
            MessageBox.Show("Cliente guardado: ", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            lblCodigoCliente.Text = DateTime.Now.ToString();
            lblCodigoCliente.Text = "";
            mtdConsultaClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int CodigoCliente = int.Parse(lblCodigoCliente.Text);
                string NombreCliente = txtNombreCliente.Text;
                string TipoCliente = txtTipoCliente.Text;
                int Telefono = int.Parse(txtTelefonoCliente.Text);
                string CorreoCliente = txtCorreoCliente.Text;
                string DireccionCliente = txtDireccionCliente.Text;
                string EstadoCliente = cboxEstadoCliente.Text;
                string UsuarioAuditoria = "";
                DateTime FechaAuditoria = DateTime.Now;
                cdClientes.MtdActualizarCliente(CodigoCliente, NombreCliente, TipoCliente, Telefono, CorreoCliente, DireccionCliente, EstadoCliente, UsuarioAuditoria, FechaAuditoria);
                mtdConsultaClientes();
                MtdLimpiarCampos();
                MessageBox.Show("Cliente actualizado: ", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int CodigoCliente = int.Parse(lblCodigoCliente.Text);
                cdClientes.MtdEliminarCliente(CodigoCliente);
                mtdConsultaClientes();
                MtdLimpiarCampos();
                MessageBox.Show("Cliente eliminado: ", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (lblCodigoCliente.Text == "" && txtNombreCliente.Text == "" && txtTipoCliente.Text == "" && txtTelefonoCliente.Text == "" && txtCorreoCliente.Text == "" && txtDireccionCliente.Text == "" && cboxEstadoCliente.Text == "")
                    MessageBox.Show("Seleccione una granja para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Error al eliminar la granja: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
                lblCodigoCliente.Text = fila.Cells["CodigoCliente"].Value.ToString();
                txtNombreCliente.Text = fila.Cells["Nombre"].Value.ToString();
                txtTipoCliente.Text = fila.Cells["Tipo"].Value.ToString();
                txtTelefonoCliente.Text = fila.Cells["Telefono"].Value.ToString();
                txtCorreoCliente.Text = fila.Cells["Correo"].Value.ToString();
                txtDireccionCliente.Text = fila.Cells["Dirección"].Value.ToString();
                cboxEstadoCliente.Text = fila.Cells["Estado"].Value.ToString();
            }
        }
    }
}
