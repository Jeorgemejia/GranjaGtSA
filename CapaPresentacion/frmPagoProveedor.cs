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
    public partial class frmPagoProveedor : Form
    {

        cdPagoProveedores cd_PagoProveedores = new cdPagoProveedores();
        public frmPagoProveedor()
        {
            InitializeComponent();
        }

        private void lblCodigoProveedor_Click(object sender, EventArgs e)
        {

        }

        private void frmPagoProveedor_Load(object sender, EventArgs e)
        {



            lblCodigoPagoProveedor.Text = "";
            lblFechaSistema.Text = DateTime.Now.ToString();
            mtdConsultaPagoProveedores();
            MtdMostrarListaCodigoProveedores();
        }

        public void mtdConsultaPagoProveedores()
        {

            DataTable dtPagoProveedor = cd_PagoProveedores.mtdConsultarTablaPagoProveedores();
            dgvPagoProveedores.DataSource = dtPagoProveedor;

        }


        private void MtdMostrarListaCodigoProveedores()
        {

            var ListaCodigoProveedores = cd_PagoProveedores.MtdListaCodigoProveedores();

            foreach (var Proveedor in ListaCodigoProveedores)
            {
                cboxCodigoProveedor.Items.Add(Proveedor);
            }

            cboxCodigoProveedor.DisplayMember = "Text";
            cboxCodigoProveedor.ValueMember = "Value";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int CodigoProveedor = int.Parse(cboxCodigoProveedor.Text.Split('-')[0].Trim());
            DateTime FechaPago = DateTime.Parse(dtpFechaPago.Text);
            decimal Monto = decimal.Parse(txtMontoPago.Text);
            string Metodo = cboxMetodoPago.Text;
            string Descripcion = txtDescripcionPago.Text;
            string Estado = cboxEstadoPago.Text;
            string UsuarioAuditoria = "";
            DateTime FechaAuditoria = DateTime.Parse(lblFechaSistema.Text.ToString());
            cd_PagoProveedores.mtdAgregarPagoProveedor(CodigoProveedor, FechaPago, Monto, Metodo, Descripcion, Estado, UsuarioAuditoria, FechaAuditoria);
            mtdLimpiarCampos();
            mtdConsultaPagoProveedores();
            
        }

        private void dgvPagoProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigoPagoProveedor.Text = dgvPagoProveedores.SelectedCells[0].Value.ToString();
            cboxCodigoProveedor.Text = dgvPagoProveedores.SelectedCells[1].Value.ToString();
            dtpFechaPago.Text = dgvPagoProveedores.SelectedCells[2].Value.ToString();
            txtMontoPago.Text = dgvPagoProveedores.SelectedCells[3].Value.ToString();
            cboxMetodoPago.Text = dgvPagoProveedores.SelectedCells[4].Value.ToString();
            txtDescripcionPago.Text = dgvPagoProveedores.SelectedCells[5].Value.ToString();
            cboxEstadoPago.Text = dgvPagoProveedores.SelectedCells[6].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int CodigoPago = int.Parse(lblCodigoPagoProveedor.Text);
            int CodigoProveedor = int.Parse(cboxCodigoProveedor.Text.Split('-')[0].Trim());
            DateTime FechaPago = DateTime.Parse(dtpFechaPago.Text);
            decimal Monto = decimal.Parse(txtMontoPago.Text);
            string Metodo = cboxMetodoPago.Text;
            string Descripcion = txtDescripcionPago.Text;
            string Estado = cboxEstadoPago.Text;
            string UsuarioAuditoria = "";
            DateTime FechaAuditoria = DateTime.Parse(lblFechaSistema.Text.ToString());
            cd_PagoProveedores.mtdActualizarPagoProveedor(CodigoPago, CodigoProveedor, FechaPago, Monto, Metodo, Descripcion, Estado, UsuarioAuditoria, FechaAuditoria);
            mtdLimpiarCampos();
            mtdConsultaPagoProveedores();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int CodigoPago = int.Parse(lblCodigoPagoProveedor.Text);
           
            cd_PagoProveedores.mtdEliminarPagoProveedor(CodigoPago);
            mtdLimpiarCampos();
            mtdConsultaPagoProveedores();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblCodigoPagoProveedor.Text = "";
            cboxCodigoProveedor.Text = "";
            dtpFechaPago.Text = "";
            txtMontoPago.Text = "";
            cboxMetodoPago.Text = "";
            txtDescripcionPago.Text = "";
            cboxEstadoPago.Text = "";
        }

        public void mtdLimpiarCampos()
        {
            lblCodigoPagoProveedor.Text = "";
            cboxCodigoProveedor.Text = "";
            dtpFechaPago.Text = "";
            txtMontoPago.Text = "";
            cboxMetodoPago.Text = "";
            txtDescripcionPago.Text = "";
            cboxEstadoPago.Text = "";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
