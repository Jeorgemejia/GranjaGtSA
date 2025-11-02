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
    public partial class frmPago : Form
    {
        cdPago cd_Pago = new cdPago();

        public frmPago()
        {
            InitializeComponent();
        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            try
            {
                mtdCargarPagos();
                mtdCargarCombos();
                mtdLimpiarCampos();
                lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar formulario: " + ex.Message);
            }

        }

        private void mtdCargarPagos()
        {
            try
            {
                dgvPagos.DataSource = cd_Pago.mtdConsultarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pagos: " + ex.Message);
            }
        }

        private void mtdCargarCombos()
        {
            try
            {
                cboEmpleado.DataSource = new cdEmpleados().mtdConsultarTablaEmpleados();
                cboEmpleado.DisplayMember = "Nombre";
                cboEmpleado.ValueMember = "CodigoEmpleado";

                cboGranja.DataSource = new cdEmpleados().mtdConsultarGranjas();
                cboGranja.DisplayMember = "Nombre";
                cboGranja.ValueMember = "CodigoGranja";

                cboEstado.Items.Clear();
                cboEstado.Items.Add("Pagado");
                cboEstado.Items.Add("Pendiente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combos: " + ex.Message);
            }
        }

        private void mtdLimpiarCampos()
        {
            lblCodigoPago.Text = "";
            cboEmpleado.SelectedIndex = -1;
            cboGranja.SelectedIndex = -1;
            txtSalarioBase.Text = "";
            txtHorasExtras.Text = "";
            txtBonos.Text = "";
            txtDescuentos.Text = "";
            txtSalarioFinal.Text = "";
            dtpFechaPago.Value = DateTime.Now;
            cboEstado.SelectedIndex = -1;
        }
        private bool ValidarCampos()
        {
            if (cboEmpleado.SelectedIndex == -1 ||
                cboGranja.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtSalarioBase.Text) ||
                string.IsNullOrWhiteSpace(txtHorasExtras.Text) ||
                string.IsNullOrWhiteSpace(txtBonos.Text) ||
                string.IsNullOrWhiteSpace(txtDescuentos.Text) ||
                string.IsNullOrWhiteSpace(txtSalarioFinal.Text) ||
                cboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return false;
            }

            if (!decimal.TryParse(txtSalarioBase.Text, out _))
            {
                MessageBox.Show("Salario base inválido.");
                return false;
            }

            if (!int.TryParse(txtHorasExtras.Text, out _))
            {
                MessageBox.Show("Horas extras inválidas.");
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                cd_Pago.mtdAgregarPago(
                    int.Parse(cboEmpleado.SelectedValue.ToString()),
                    int.Parse(cboGranja.SelectedValue.ToString()),
                    decimal.Parse(txtSalarioBase.Text),
                    int.Parse(txtHorasExtras.Text),
                    decimal.Parse(txtBonos.Text),
                    decimal.Parse(txtDescuentos.Text),
                    decimal.Parse(txtSalarioFinal.Text),
                    dtpFechaPago.Value,
                    cboEstado.Text,
                    "Sistema",
                    DateTime.Now
                );
                MessageBox.Show("Pago guardado correctamente.");
                mtdCargarPagos();
                mtdLimpiarCampos();
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
                MessageBox.Show("Seleccione un pago primero.");
                return;
            }

            if (!ValidarCampos()) return;

            try
            {
                cd_Pago.mtdActualizarPago(
                    int.Parse(lblCodigoPago.Text),
                    int.Parse(cboEmpleado.SelectedValue.ToString()),
                    int.Parse(cboGranja.SelectedValue.ToString()),
                    decimal.Parse(txtSalarioBase.Text),
                    int.Parse(txtHorasExtras.Text),
                    decimal.Parse(txtBonos.Text),
                    decimal.Parse(txtDescuentos.Text),
                    decimal.Parse(txtSalarioFinal.Text),
                    dtpFechaPago.Value,
                    cboEstado.Text,
                    "Sistema",
                    DateTime.Now
                );
                MessageBox.Show("Pago actualizado exitosamente.");
                mtdCargarPagos();
                mtdLimpiarCampos();
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
                MessageBox.Show("Seleccione un pago primero.");
                return;
            }

            if (MessageBox.Show("¿Eliminar este pago?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            try
            {
                cd_Pago.mtdEliminarPago(int.Parse(lblCodigoPago.Text));
                MessageBox.Show("Pago eliminado.");
                mtdCargarPagos();
                mtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            mtdLimpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvPagos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                DataGridViewRow fila = dgvPagos.Rows[e.RowIndex];

                lblCodigoPago.Text = fila.Cells["codigoPago"].Value.ToString();
                cboEmpleado.SelectedValue = fila.Cells["CodigoEmpleado"].Value;
                cboGranja.SelectedValue = fila.Cells["CodigoGranja"].Value;
                txtSalarioBase.Text = fila.Cells["SalarioBase"].Value.ToString();
                txtHorasExtras.Text = fila.Cells["HorasExtras"].Value.ToString();
                txtBonos.Text = fila.Cells["Bonos"].Value.ToString();
                txtDescuentos.Text = fila.Cells["Descuentos"].Value.ToString();
                txtSalarioFinal.Text = fila.Cells["SalarioFinal"].Value.ToString();
                dtpFechaPago.Value = Convert.ToDateTime(fila.Cells["FechaPago"].Value);
                cboEstado.Text = fila.Cells["Estado"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar fila: " + ex.Message);
            }
        }

        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboEmpleado.SelectedValue == null) return;

                int codigoEmpleado;

                if (cboEmpleado.SelectedValue is DataRowView drv)
                    codigoEmpleado = Convert.ToInt32(drv["CodigoEmpleado"]);
                else
                    codigoEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);

                decimal salarioBase = cd_Pago.mtdObtenerSalarioBase(codigoEmpleado);
                txtSalarioBase.Text = salarioBase.ToString("0.00");

                CalcularSalarioFinal();
            }
            catch (Exception)
            {
               
            }
        }

        private void txtHorasExtras_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtHorasExtras.Text, out decimal value) && value < 0)
                txtHorasExtras.Text = "0";
            CalcularSalarioFinal();
        }

        private void txtBonos_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtBonos.Text, out decimal value) && value < 0)
                txtBonos.Text = "0";
            CalcularSalarioFinal();
        }

        private void txtDescuentos_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDescuentos.Text, out decimal value) && value < 0)
                txtDescuentos.Text = "0";
            CalcularSalarioFinal();
        }

        private void CalcularSalarioFinal()
        {
            try
            {
                decimal salarioBase = string.IsNullOrEmpty(txtSalarioBase.Text) ? 0 : Convert.ToDecimal(txtSalarioBase.Text);
                decimal horasExtras = string.IsNullOrEmpty(txtHorasExtras.Text) ? 0 : Convert.ToDecimal(txtHorasExtras.Text);
                decimal bonos = string.IsNullOrEmpty(txtBonos.Text) ? 0 : Convert.ToDecimal(txtBonos.Text);
                decimal descuentos = string.IsNullOrEmpty(txtDescuentos.Text) ? 0 : Convert.ToDecimal(txtDescuentos.Text);

                txtSalarioFinal.Text = (salarioBase + horasExtras + bonos - descuentos).ToString("0.00");
            }
            catch { }
        }

    }
}
