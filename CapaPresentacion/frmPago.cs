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
            mtdCargarPagos();
            mtdCargarCombos();
            mtdLimpiarCampos();


            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy"); 
           
        
        }

        private void mtdCargarPagos()
        {
            dgvPagos.DataSource = cd_Pago.mtdConsultarPagos();
        }

        private void mtdCargarCombos()
        {
            // Combo de empleados
            cboEmpleado.DataSource = new cdEmpleados().mtdConsultarTablaEmpleados();
            cboEmpleado.DisplayMember = "Nombre";
            cboEmpleado.ValueMember = "CodigoEmpleado";

            // Combo de granjas
            cboGranja.DataSource = new cdEmpleados().mtdConsultarGranjas();
            cboGranja.DisplayMember = "Nombre";
            cboGranja.ValueMember = "CodigoGranja";

            // Estado
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Pagado");
            cboEstado.Items.Add("Pendiente");
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

        private void btnGuardar_Click(object sender, EventArgs e)
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
            mtdCargarPagos();
            mtdLimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
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
            mtdCargarPagos();
            mtdLimpiarCampos();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            cd_Pago.mtdEliminarPago(int.Parse(lblCodigoPago.Text));
            mtdCargarPagos();
            mtdLimpiarCampos();
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

        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedValue != null)
            {
                int codigoEmpleado;

                // Evitar el error InvalidCastException
                if (cboEmpleado.SelectedValue is DataRowView drv)
                {
                    codigoEmpleado = Convert.ToInt32(drv["CodigoEmpleado"]);
                }
                else
                {
                    codigoEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);
                }

                // Obtener Salario Base desde la BD
                decimal salarioBase = cd_Pago.mtdObtenerSalarioBase(codigoEmpleado);
                txtSalarioBase.Text = salarioBase.ToString("0.00");

                // Recalcular Salario Final
                CalcularSalarioFinal();
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
            decimal salarioBase = string.IsNullOrEmpty(txtSalarioBase.Text) ? 0 : Convert.ToDecimal(txtSalarioBase.Text);
            decimal horasExtras = string.IsNullOrEmpty(txtHorasExtras.Text) ? 0 : Convert.ToDecimal(txtHorasExtras.Text);
            decimal bonos = string.IsNullOrEmpty(txtBonos.Text) ? 0 : Convert.ToDecimal(txtBonos.Text);
            decimal descuentos = string.IsNullOrEmpty(txtDescuentos.Text) ? 0 : Convert.ToDecimal(txtDescuentos.Text);

            txtSalarioFinal.Text = (salarioBase + horasExtras + bonos - descuentos).ToString("0.00");
        }

    }
}
