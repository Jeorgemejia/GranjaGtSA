using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class frmGranja : Form
    {
        
        cdConexiones cdconexiones = new cdConexiones();
        cdGranja cdgranja = new cdGranja();
        public frmGranja()
        {
            InitializeComponent();
        }

        private void frmGranja_Load(object sender, EventArgs e)
        {
            lblFechaGranja.Text = DateTime.Now.ToString();
            lblCodigoGranja.Text = "";
            mtdConsultarGranjas();
        }
        public void mtdConsultarGranjas()
        {
            DataTable dtGranja = cdgranja.MtdConsultarGranja();
            dgvGranja.DataSource = dtGranja;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void mtdLimpiarCampos()
        {
            txtNombreGranja.Text = "";
            txtDireccionGranja.Text = "";
            txtTelefonoGranja.Text = "";
            txtCorreoGranja.Text = "";
            txtCodigoPostalGranja.Text = "";
            cboxEstadoGranja.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string NombreGranja = txtNombreGranja.Text;
            string Direccion = txtDireccionGranja.Text;
            int Telefono = int.Parse(txtTelefonoGranja.Text);
            string Correo = txtCorreoGranja.Text;
            int CodigoPostal = int.Parse(txtCodigoPostalGranja.Text);
            string Estado = cboxEstadoGranja.Text;
            string UsuarioAuditoria = "";
            DateTime FechaAuditoria = DateTime.Now;
            cdgranja.MtdAgregarGranja(NombreGranja, Direccion, Telefono, Correo, CodigoPostal, Estado, UsuarioAuditoria, FechaAuditoria);
            mtdConsultarGranjas();
            mtdLimpiarCampos();
            MessageBox.Show("Granja guardada: ", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
                {
                int CodigoGranja = int.Parse(lblCodigoGranja.Text);
                string NombreGranja = txtNombreGranja.Text;
                string Direccion = txtDireccionGranja.Text;
                int Telefono = int.Parse(txtTelefonoGranja.Text);
                string Correo = txtCorreoGranja.Text;
                int CodigoPostal = int.Parse(txtCodigoPostalGranja.Text);
                string Estado = cboxEstadoGranja.Text;
                string UsuarioAuditoria = "";
                DateTime FechaAuditoria = DateTime.Now;
                cdgranja.MtdActualizarGranja(CodigoGranja, NombreGranja, Direccion, Telefono, Correo, CodigoPostal, Estado, UsuarioAuditoria, FechaAuditoria);
                mtdConsultarGranjas();
                mtdLimpiarCampos();
                MessageBox.Show("Granja editada: ", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar la granja: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
                {
                int CodigoGranja = int.Parse(lblCodigoGranja.Text);
                cdgranja.MtdEliminarGranja(CodigoGranja);
                mtdConsultarGranjas();
                mtdLimpiarCampos();
                MessageBox.Show("Granja eliminada: ", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la granja: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mtdLimpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGranja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvGranja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigoGranja.Text = dgvGranja.SelectedCells[0].Value.ToString();
            txtNombreGranja.Text = dgvGranja.SelectedCells[1].Value.ToString();
            txtDireccionGranja.Text = dgvGranja.SelectedCells[2].Value.ToString();
            txtTelefonoGranja.Text = dgvGranja.SelectedCells[3].Value.ToString();
            txtCorreoGranja.Text = dgvGranja.SelectedCells[4].Value.ToString();
            txtCodigoPostalGranja.Text = dgvGranja.SelectedCells[5].Value.ToString();
            cboxEstadoGranja.Text = dgvGranja.SelectedCells[6].Value.ToString();
        }
    }
}
