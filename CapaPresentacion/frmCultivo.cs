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
    public partial class frmCultivo : Form
    {
        cdCultivos cd_Cultivo = new cdCultivos();
        public frmCultivo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int CodigoGranja = int.Parse(cboxCodigoGranja.Text.Split('-')[0].Trim());
            string TipoCultivo = txtTipoCultivo.Text;
            DateTime FechaSiembra = DateTime.Parse(dtpFechaSiembra.Text);
            DateTime FechaCosecha = DateTime.Parse(dtpFechaCosecha.Text);
            decimal CantidadCosecha = decimal.Parse(txtCantidadCosecha.Text);
            decimal PrecioCosecha = decimal.Parse(txtPrecio.Text);
            string Ubicacion = txtUbicacion.Text;
            string Observaciones = txtObservacion.Text;
            string Estado = cboxEstado.Text;
            string UsuarioAuditoria = "";
            DateTime FechaAuditoria = DateTime.Now;
            cd_Cultivo.MtdAgregarCultivo(CodigoGranja, TipoCultivo, FechaSiembra, FechaCosecha, CantidadCosecha, PrecioCosecha, Ubicacion, Observaciones, Estado, UsuarioAuditoria, FechaAuditoria);
            MtdLimpiarCampos();
            mtdConsultaCultivo();
        }

        public void MtdLimpiarCampos()
        {
            lblCodigoCultivo.Text = "";
            txtTipoCultivo.Text = "";
            dtpFechaSiembra.Value = DateTime.Now;
            dtpFechaCosecha.Value = DateTime.Now;
            txtCantidadCosecha.Text = "";
            txtPrecio.Text = "";
            txtUbicacion.Text = "";
            txtObservacion.Text = "";
            cboxEstado.SelectedIndex = -1;
        }
        public void mtdConsultaCultivo()
        {
            DataTable dtCultivo = cd_Cultivo.mtdConsultarTablaProductos();
            dgvCultivos.DataSource = dtCultivo;
        }

        private void MtdMostrarListaCodigoGranja()
        {

            var ListaCodigoGranja = cd_Cultivo.MtdListaCodigoGranja();

            foreach (var Granja in ListaCodigoGranja)
            {
                cboxCodigoGranja.Items.Add(Granja);
            }

            cboxCodigoGranja.DisplayMember = "Text";
            cboxCodigoGranja.ValueMember = "Value";
        }

        private void frmCultivo_Load(object sender, EventArgs e)
        {
            lblCodigoCultivo.Text = "";
            lblFechaProducto.Text = DateTime.Now.ToString();
            mtdConsultaCultivo();
            MtdMostrarListaCodigoGranja();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int CodigoCultivo = int.Parse(lblCodigoCultivo.Text);
            int CodigoGranja = int.Parse(cboxCodigoGranja.Text.Split('-')[0].Trim());
            string TipoCultivo = txtTipoCultivo.Text;
            DateTime FechaSiembra = DateTime.Parse(dtpFechaSiembra.Text);
            DateTime FechaCosecha = DateTime.Parse(dtpFechaCosecha.Text);
            decimal CantidadCosecha = decimal.Parse(txtCantidadCosecha.Text);
            decimal PrecioCosecha = decimal.Parse(txtPrecio.Text);
            string Ubicacion = txtUbicacion.Text;
            string Observaciones = txtObservacion.Text;
            string Estado = cboxEstado.Text;
            string UsuarioAuditoria = "";
            DateTime FechaAuditoria = DateTime.Now;
            cd_Cultivo.MtdActualizarCultivo(CodigoCultivo, CodigoGranja, TipoCultivo, FechaSiembra, FechaCosecha, CantidadCosecha, PrecioCosecha, Ubicacion, Observaciones, Estado, UsuarioAuditoria, FechaAuditoria);
            MtdLimpiarCampos();
            mtdConsultaCultivo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int CodigoCultivo = int.Parse(lblCodigoCultivo.Text);
            cd_Cultivo.MtdEliminarCultivo(CodigoCultivo);
            MtdLimpiarCampos();
            mtdConsultaCultivo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblCodigoCultivo.Text = "";
            cboxCodigoGranja.SelectedIndex = -1;
            txtTipoCultivo.Text = "";
            dtpFechaSiembra.Value = DateTime.Now;
            dtpFechaCosecha.Value = DateTime.Now;
            txtCantidadCosecha.Text = "";
            txtPrecio.Text = "";
            txtUbicacion.Text = "";
            txtObservacion.Text = "";
            cboxEstado.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCultivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigoCultivo.Text = dgvCultivos.CurrentRow.Cells[0].Value.ToString();
            cboxCodigoGranja.Text = dgvCultivos.CurrentRow.Cells[1].Value.ToString();
            txtTipoCultivo.Text = dgvCultivos.CurrentRow.Cells[2].Value.ToString();
            dtpFechaSiembra.Text = dgvCultivos.CurrentRow.Cells[3].Value.ToString();
            dtpFechaCosecha.Text = dgvCultivos.CurrentRow.Cells[4].Value.ToString();
            txtCantidadCosecha.Text = dgvCultivos.CurrentRow.Cells[5].Value.ToString();
            txtPrecio.Text = dgvCultivos.CurrentRow.Cells[6].Value.ToString();
            txtUbicacion.Text = dgvCultivos.CurrentRow.Cells[7].Value.ToString();
            txtObservacion.Text = dgvCultivos.CurrentRow.Cells[8].Value.ToString();
            cboxEstado.Text = dgvCultivos.CurrentRow.Cells[9].Value.ToString();
        }
    }
}
