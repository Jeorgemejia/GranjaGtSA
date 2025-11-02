using CapaDatos;
using CapaLogica;
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
    public partial class frmDetalleVenta : Form
    {

        cdDetalleVenta cd_DetalleVenta = new cdDetalleVenta();
        clDetalleVenta cl_DetalleVenta = new clDetalleVenta();
        public frmDetalleVenta()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            MtdMostrarListaCodigoVentas();
            MtdMostrarListaCodigoanimal();
            MtdMostrarListaCodigoCultivo();
            MtdMostrarListaCodigoProducto();
            MtdConsultaDetalleVenta();
            lblFechaSistema.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void MtdMostrarListaCodigoVentas()
        {

            var ListaCodigoVentas = cd_DetalleVenta.MtdListaCodigoVentas();

            foreach (var venta in ListaCodigoVentas)
            {
                cboxCodigoVenta.Items.Add(venta);
            }

            cboxCodigoVenta.DisplayMember = "Text";
            cboxCodigoVenta.ValueMember = "Value";
        }

        public void MtdConsultaDetalleVenta()
        {

            DataTable dtDetalleVenta = cd_DetalleVenta.mtdConsultarConsultarTablaDetalleVentas();
            dgvDetalleVentas.DataSource = dtDetalleVenta;


        }


        private void MtdMostrarListaCodigoanimal()
        {

            var ListaCodigoAnimal = cd_DetalleVenta.MtdListaCodigoAnimal();

            foreach (var Animal in ListaCodigoAnimal)
            {
                cboxCodigoAnimal.Items.Add(Animal);
            }

            cboxCodigoAnimal.DisplayMember = "Text";
            cboxCodigoAnimal.ValueMember = "Value";
        }

        private void MtdMostrarListaCodigoCultivo()
        {

            var ListaCodigoCultivo = cd_DetalleVenta.MtdListaCodigoCultivo();

            foreach (var Cultivo in ListaCodigoCultivo)
            {
                cboxCodigoCultivo.Items.Add(Cultivo);
            }

            cboxCodigoCultivo.DisplayMember = "Text";
            cboxCodigoCultivo.ValueMember = "Value";
        }

        private void MtdMostrarListaCodigoProducto()
        {

            var ListaCodigoProducto = cd_DetalleVenta.MtdListaCodigoProducto();

            foreach (var Producto in ListaCodigoProducto)
            {
                cboxCodigoProducto.Items.Add(Producto);
            }

            cboxCodigoProducto.DisplayMember = "Text";
            cboxCodigoProducto.ValueMember = "Value";
        }

        private void dgvDetalleVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigoDetalleVenta.Text = dgvDetalleVentas.SelectedCells[0].Value.ToString();
            cboxCodigoVenta.Text = dgvDetalleVentas.SelectedCells[1].Value.ToString();
            cboxCodigoAnimal.Text = dgvDetalleVentas.SelectedCells[2].Value.ToString();
            cboxCodigoCultivo.Text = dgvDetalleVentas.SelectedCells[3].Value.ToString();
            cboxCodigoProducto.Text = dgvDetalleVentas.SelectedCells[4].Value.ToString();
            txtTotal.Text = dgvDetalleVentas.SelectedCells[7].Value.ToString();
            cboxDescuento.Text = dgvDetalleVentas.SelectedCells[8].Value.ToString();
            txtImpuesto.Text = dgvDetalleVentas.SelectedCells[9].Value.ToString();
            txtTotalVenta.Text = dgvDetalleVentas.SelectedCells[10].Value.ToString();
            cboxEstado.Text = dgvDetalleVentas.SelectedCells[11].Value.ToString();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int CodigoVentas;
            if (!int.TryParse(cboxCodigoVenta.Text.Split('-')[0].Trim(), out CodigoVentas))
            {
                MessageBox.Show("Por favor, seleccione un Código de Venta válido.");
                return; 
            }

            int? CodigoAnimal = null;
            int? CodigoCultivo = null;
            int? CodigoProducto = null;
            int tempID; 

            // Animal
            string animal = cboxCodigoAnimal.Text.Split('-')[0].Trim();
            if (!string.IsNullOrEmpty(animal) && int.TryParse(animal, out tempID))
            {
                CodigoAnimal = tempID;
            }

          
            string cultivoText = cboxCodigoCultivo.Text.Split('-')[0].Trim();
            if (!string.IsNullOrEmpty(cultivoText) && int.TryParse(cultivoText, out tempID))
            {
                CodigoCultivo = tempID;
            }

            string productoText = cboxCodigoProducto.Text.Split('-')[0].Trim();
            if (!string.IsNullOrEmpty(productoText) && int.TryParse(productoText, out tempID))
            {
                CodigoProducto = tempID;
            }

          

            int Cantidad;
            if (!int.TryParse(txtCantAnimal.Text, out Cantidad))
            {
                MessageBox.Show("Por favor, ingrese una Cantidad válida.");
                return;
            }

            decimal PrecioUnitario;
            if (!decimal.TryParse(txtPrecioUnitAnimal.Text, out PrecioUnitario))
            {
                MessageBox.Show("Por favor, ingrese un Precio Unitario válido.");
                return;
            }

           

            decimal Total;
            if (!decimal.TryParse(txtTotal.Text, out Total))
            {
                MessageBox.Show("El Total no es válido. Presione 'Calcular' primero.");
                return;
            }

            
            decimal MontoDescuento = cl_DetalleVenta.mtdDescuento(Total, decimal.Parse(cboxDescuento.Text));

            decimal Impuesto;
            if (!decimal.TryParse(txtImpuesto.Text, out Impuesto))
            {
                MessageBox.Show("El Impuesto no es válido. Presione 'Calcular' primero.");
                return;
            }

            decimal TotalVenta;
            if (!decimal.TryParse(txtTotalVenta.Text, out TotalVenta))
            {
                MessageBox.Show("El Total Venta no es válido. Presione 'Calcular' primero.");
                return;
            }

        
            string Estado = cboxEstado.Text;
            string UsuarioAuditoria = "Sistema";
            DateTime FechaAuditoria = DateTime.Parse(lblFechaSistema.Text);

            cd_DetalleVenta.MtdAgregarDetalleVenta(CodigoVentas, CodigoAnimal, CodigoCultivo, CodigoProducto, Cantidad, PrecioUnitario, Total, MontoDescuento, Impuesto, TotalVenta, Estado, UsuarioAuditoria, FechaAuditoria);
    
            MtdConsultaDetalleVenta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal subtotalGeneral = 0;

            int cantidad = 0;
            decimal precio = 0;

            
            if (int.TryParse(txtCantAnimal.Text, out cantidad) && decimal.TryParse(txtPrecioUnitAnimal.Text, out precio))
            {
                subtotalGeneral += cantidad * precio;
            }

          
            if (int.TryParse(txtCantCultivo.Text, out cantidad) && decimal.TryParse(txtPrecioUnitProducto.Text, out precio))
            {
                subtotalGeneral += cantidad * precio;
            }

           
            if (int.TryParse(txtCantProducto.Text, out cantidad) && decimal.TryParse(txtPrecioUnitProducto.Text, out precio))
            {
                subtotalGeneral += cantidad * precio;
            }

          
            // 'F2' formatea el número a 2 decimales
            txtTotal.Text = subtotalGeneral.ToString("F2");

            decimal impuesto = cl_DetalleVenta.MtdImpuesto(subtotalGeneral);
            txtImpuesto.Text = impuesto.ToString("F2");

           
            decimal porcentajeDescuento = 0;
            decimal.TryParse(cboxDescuento.Text, out porcentajeDescuento); 

            decimal montoDescuento = cl_DetalleVenta.mtdDescuento(subtotalGeneral, porcentajeDescuento);

            txtTotalVenta.Text = cl_DetalleVenta.MtdTotalVenta(
                subtotalGeneral,
                montoDescuento, 
                impuesto
            ).ToString("F2");
        }
    }
}