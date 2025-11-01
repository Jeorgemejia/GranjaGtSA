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
    public partial class frmPagoVentas : Form
    {
        cdPagoVentas cd_PagoVentas = new cdPagoVentas();

        public frmPagoVentas()
        {
            InitializeComponent();
        }

        private void frmPagoVentas_Load(object sender, EventArgs e)
        {
            mtdCargarPagos();
            mtdCargarComboVentas();
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void mtdCargarPagos()
        {
            dgvPagosVentas.DataSource = cd_PagoVentas.mtdConsultarPagoVentas();
        }

        private void mtdCargarComboVentas()
        {
            cboVentas.DataSource = cd_PagoVentas.mtdConsultarVentas();
            cboVentas.DisplayMember = "CodigoVentas"; 
            cboVentas.ValueMember = "CodigoVentas";
        }

      
       
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cd_PagoVentas.mtdAgregarPagoVenta(
               Convert.ToInt32(cboVentas.SelectedValue),
               decimal.Parse(txtMonto.Text),
               cboTipoPago.Text,
               int.Parse(txtNumReferencia.Text),
               dtpFechaPago.Value,
               cboEstado.Text,
               "Sistema",
               DateTime.Now
           );
            mtdCargarPagos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cd_PagoVentas.mtdActualizarPagoVenta(
              int.Parse(lblCodigoPago.Text),
              Convert.ToInt32(cboVentas.SelectedValue),
              decimal.Parse(txtMonto.Text),
              cboTipoPago.Text,
              int.Parse(txtNumReferencia.Text),
              dtpFechaPago.Value,
              cboEstado.Text,
              "Sistema",
              DateTime.Now
          );
            mtdCargarPagos();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            cd_PagoVentas.mtdEliminarPagoVenta(int.Parse(lblCodigoPago.Text));
            mtdCargarPagos();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            lblCodigoPago.Text = "";
            cboVentas.SelectedIndex = -1;
            txtMonto.Text = "";
            cboTipoPago.SelectedIndex = -1;
            txtNumReferencia.Text = "";
            dtpFechaPago.Value = DateTime.Now;
            cboEstado.SelectedIndex = -1;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvPagosVentas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvPagosVentas.Rows[e.RowIndex];

                lblCodigoPago.Text = fila.Cells["CodigoPago"].Value.ToString();
                cboVentas.SelectedValue = fila.Cells["CodigoVentas"].Value;
                txtMonto.Text = fila.Cells["Monto"].Value.ToString();
                cboTipoPago.Text = fila.Cells["TipoPago"].Value.ToString();
                txtNumReferencia.Text = fila.Cells["NumReferencia"].Value.ToString();
                dtpFechaPago.Value = Convert.ToDateTime(fila.Cells["FechaPago"].Value);
                cboEstado.Text = fila.Cells["Estado"].Value.ToString();
            }
        }
    }
}
