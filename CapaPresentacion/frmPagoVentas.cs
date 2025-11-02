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
            try
            {
                mtdCargarPagos();
                mtdCargarComboVentas();
                lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void mtdCargarPagos()
        {
            try
            {
                dgvPagosVentas.DataSource = cd_PagoVentas.mtdConsultarPagoVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pagos: " + ex.Message);
            }
        }

        private void mtdCargarComboVentas()
        {
            try
            {
                cboVentas.DataSource = cd_PagoVentas.mtdConsultarVentas();
                cboVentas.DisplayMember = "CodigoVentas";
                cboVentas.ValueMember = "CodigoVentas";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message);
            }
        }

        private bool ValidarCampos()
        {
            if (cboVentas.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtMonto.Text) ||
                cboTipoPago.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtNumReferencia.Text) ||
                cboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return false;
            }

            if (!decimal.TryParse(txtMonto.Text, out _))
            {
                MessageBox.Show("Monto inválido.");
                return false;
            }

            if (!int.TryParse(txtNumReferencia.Text, out _))
            {
                MessageBox.Show("Número de referencia inválido.");
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
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

                MessageBox.Show("Pago guardado correctamente.");
                mtdCargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblCodigoPago.Text))
            {
                MessageBox.Show("Seleccione un registro primero.");
                return;
            }

            if (!ValidarCampos()) return;

            try
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

                MessageBox.Show("Pago actualizado correctamente.");
                mtdCargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblCodigoPago.Text))
            {
                MessageBox.Show("Seleccione un registro primero.");
                return;
            }

            if (MessageBox.Show("¿Eliminar este pago?", "CONFIRMAR",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            try
            {
                cd_PagoVentas.mtdEliminarPagoVenta(int.Parse(lblCodigoPago.Text));
                MessageBox.Show("Pago eliminado.");

                mtdCargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar fila: " + ex.Message);
            }
        }
    }
    }

