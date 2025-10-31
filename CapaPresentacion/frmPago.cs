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
        }

        private void mtdCargarPagos()
        {
            dgvPagos.DataSource = cd_Pago.mtdConsultarPagos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
        }

        private void btnActualizar_Click(object sender, EventArgs e)
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cd_Pago.mtdEliminarPago(int.Parse(lblCodigoPago.Text));
            mtdCargarPagos();
        }
    }
}
