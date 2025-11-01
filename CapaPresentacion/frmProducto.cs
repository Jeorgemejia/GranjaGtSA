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
    public partial class frmProducto : Form
    {
        cdProductos cd_Productos = new cdProductos();

        public frmProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int CodigoGranja = int.Parse(cboxCodigoGranja.Text.Split('-')[0].Trim());
            string Nombre = txtNombreProducto.Text;
            string Tipo = txtTipoProducto.Text;
            decimal Precio = decimal.Parse(txtPrecioProducto.Text);
            int Stock = int.Parse(txtStockProducto.Text);
            DateTime FechaIngreso = DateTime.Parse(dtpFechaIngresoProducto.Text);
            DateTime FechaVencimiento = DateTime.Parse(dtpFechaVencimientoProducto.Text);
            string Estado = cboxEstadoProducto.Text;
            string UsuarioAuditoria = "";
            DateTime FechaAuditoria = DateTime.Now;
            cd_Productos.MtdAgregarProducto(CodigoGranja, Nombre, Tipo, Precio, Stock, FechaIngreso, FechaVencimiento, Estado, UsuarioAuditoria, FechaAuditoria);
            MtdLimpiarCampos();
            mtdConsultaProducto();


        }

        public void MtdLimpiarCampos()
        {
            lblCodigoProducto.Text = "";
            txtNombreProducto.Text = "";
            txtTipoProducto.Text = "";
            txtPrecioProducto.Text = "";
            txtStockProducto.Text = "";
            dtpFechaIngresoProducto.Value = DateTime.Now;
            dtpFechaVencimientoProducto.Value = DateTime.Now;
            cboxEstadoProducto.SelectedIndex = -1;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            lblCodigoProducto.Text = "";
            lblFechaProducto.Text = DateTime.Now.ToString();
            mtdConsultaProducto();
            MtdMostrarListaCodigoGranja();
        }
        public void mtdConsultaProducto()
        {
            DataTable dtPagoProducto = cd_Productos.mtdConsultarTablaProductos();
            dgvProductos.DataSource = dtPagoProducto;
        }

        private void MtdMostrarListaCodigoGranja()
        {
            
            var ListaCodigoProveedores = cd_Productos.MtdListaCodigoGranja();

            foreach (var Proveedor in ListaCodigoProveedores)
            {
                cboxCodigoGranja.Items.Add(Proveedor);
            }

            cboxCodigoGranja.DisplayMember = "Text";
            cboxCodigoGranja.ValueMember = "Value";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int CodigoProducto = int.Parse(lblCodigoProducto.Text);
            int CodigoGranja = int.Parse(cboxCodigoGranja.Text.Split('-')[0].Trim());
            string Nombre = txtNombreProducto.Text;
            string Tipo = txtTipoProducto.Text;
            decimal Precio = decimal.Parse(txtPrecioProducto.Text);
            int Stock = int.Parse(txtStockProducto.Text);
            DateTime FechaIngreso = DateTime.Parse(dtpFechaIngresoProducto.Text);
            DateTime FechaVencimiento = DateTime.Parse(dtpFechaVencimientoProducto.Text);
            string Estado = cboxEstadoProducto.Text;
            string UsuarioAuditoria = "";
            DateTime FechaAuditoria = DateTime.Parse(lblFechaProducto.Text.ToString());
            cd_Productos.MtdActualizarProducto(CodigoProducto, CodigoGranja, Nombre, Tipo, Precio, Stock, FechaIngreso, FechaVencimiento, Estado, UsuarioAuditoria, FechaAuditoria);
            MtdLimpiarCampos();
            mtdConsultaProducto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int CodigoProducto = int.Parse(lblCodigoProducto.Text);
            cd_Productos.MtdEliminarProducto(CodigoProducto);
            MtdLimpiarCampos();
            mtdConsultaProducto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblCodigoProducto.Text = "";
            cboxCodigoGranja.SelectedIndex = -1;
            txtNombreProducto.Text = "";
            txtTipoProducto.Text = "";
            txtPrecioProducto.Text = "";
            txtStockProducto.Text = "";
            dtpFechaIngresoProducto.Value = DateTime.Now;
            dtpFechaVencimientoProducto.Value = DateTime.Now;
            cboxEstadoProducto.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
