using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
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

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string NombreGranja = txtNombreGranja.Text;
            string DireccionGranja = txtDireccionGranja.Text;
            int Telefono = int.Parse(txtTelefonoGranja.Text);
            string CorreoGranja = txtCorreoGranja.Text; 
            int CodigoPostal = int.Parse(txtCodigoPostalGranja.Text);
            string EstadoGranja = cboxEstadoGranja.Text;
            string UsuarioAuditoria = "";
            DateTime FechaAuditoria = DateTime.Now;
            cdgranja.MtdAgregarGranja(NombreGranja, DireccionGranja, Telefono, CorreoGranja, CodigoPostal, EstadoGranja, UsuarioAuditoria, FechaAuditoria);
            mtdConsultarGranjas();
            mtdLimpiarCampos();
            MessageBox.Show("Granja guardada: ", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mtdLimpiarCampos()
        {
            lblCodigoGranja.Text = "";
            txtNombreGranja.Text = "";
            txtDireccionGranja.Text = "";
            txtTelefonoGranja.Text = "";
            txtCorreoGranja.Text = "";
            txtCodigoPostalGranja.Text = "";
            cboxEstadoGranja.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int CodigoGranja = int.Parse(lblCodigoGranja.Text);
                string NombreGranja = txtNombreGranja.Text;
                string DireccionGranja = txtDireccionGranja.Text;
                int Telefono = int.Parse(txtTelefonoGranja.Text);
                string CorreoGranja = txtCorreoGranja.Text;
                int CodigoPostal = int.Parse(txtCodigoPostalGranja.Text);
                string EstadoGranja = cboxEstadoGranja.Text;
                string UsuarioAuditoria = "";
                DateTime FechaAuditoria = DateTime.Now;
                cdgranja.MtdActualizarGranja(CodigoGranja, NombreGranja, DireccionGranja, Telefono, CorreoGranja, CodigoPostal, EstadoGranja, UsuarioAuditoria, FechaAuditoria);
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
                if (lblCodigoGranja.Text == "" && txtNombreGranja.Text == "" && txtDireccionGranja.Text == "" && txtTelefonoGranja.Text == "" && txtCorreoGranja.Text == "" && txtCodigoPostalGranja.Text == "" && cboxEstadoGranja.Text == "")
                    MessageBox.Show("Seleccione una granja para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
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

        private void dgvGranja_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dgvGranja.CurrentRow != null)
            {
                lblCodigoGranja.Text = dgvGranja.CurrentRow.Cells[0].Value.ToString();
                txtNombreGranja.Text = dgvGranja.CurrentRow.Cells[1].Value.ToString();
                txtDireccionGranja.Text = dgvGranja.CurrentRow.Cells[2].Value.ToString();
                txtTelefonoGranja.Text = dgvGranja.CurrentRow.Cells[3].Value.ToString();
                txtCorreoGranja.Text = dgvGranja.CurrentRow.Cells[4].Value.ToString();
                txtCodigoPostalGranja.Text = dgvGranja.CurrentRow.Cells[5].Value.ToString();
                cboxEstadoGranja.Text = dgvGranja.CurrentRow.Cells[6].Value.ToString();
            }
        }

    }
}
