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
    public partial class frmEnvio : Form
    {
        cdEnvio cd_Envio = new cdEnvio();
        public frmEnvio()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int CodigoVentas = Convert.ToInt32(cboxCodigoVentas.SelectedValue);
            int CodigoEmpleado = Convert.ToInt32(cboxCodigoEmpleado.SelectedValue);
            int CodigoGranja = Convert.ToInt32(cboxCodigoGranja.SelectedValue);
            DateTime Fecha = dtpFechaEnvio.Value;
            string Direccion = txtDireccion.Text;
            string TipoTransporte = txtTipoTransporte.Text;
            string PlacaTransporte = txtPlacaTransporte.Text;
            string Estado = cboxEstadoEnvio.Text;
            string UsuarioAuditoria = "";
            DateTime FechaAuditoria = DateTime.Now;
            cd_Envio.MtdAgregarEnvio(CodigoVentas, CodigoEmpleado, CodigoGranja, Fecha, Direccion, TipoTransporte, PlacaTransporte, Estado, UsuarioAuditoria, FechaAuditoria);
            MtdLimpiarCampos();
            MtdConsultaDetalleVenta();

        }

        public void MtdLimpiarCampos()
        {
            lblCodigoEnvio.Text = "";
            cboxCodigoVentas.SelectedIndex = -1;
            cboxCodigoEmpleado.SelectedIndex = -1;
            cboxCodigoGranja.SelectedIndex = -1;
            dtpFechaEnvio.Value = DateTime.Now;
            txtDireccion.Text = "";
            txtTipoTransporte.Text = "";
            txtPlacaTransporte.Text = "";
            txtObservacion.Text = "";
            cboxEstadoEnvio.SelectedIndex = -1;
        }
        private void frmEnvio_Load(object sender, EventArgs e)
        {
            
            lblCodigoEnvio.Text = "";
            lblFechaEnvio.Text = DateTime.Now.ToString();
            MtdConsultaDetalleVenta();
            MtdMostrarListaCodigoVentas();
            MtdMostrarListaCodigoEmpleado();
            MtdMostrarListaCodigoGranja();
        }

        private void MtdMostrarListaCodigoVentas()
        {
            var ListaCodigoVentas = cd_Envio.MtdListaCodigoVentas();

            foreach (var venta in ListaCodigoVentas)
            {
                cboxCodigoVentas.Items.Add(venta);
            }

            cboxCodigoVentas.DisplayMember = "Text";
            cboxCodigoVentas.ValueMember = "Value";
        }

        private void MtdMostrarListaCodigoEmpleado()
        {
            var ListaCodigoVentas = cd_Envio.MtdListaCodigoEmpleado();

            foreach (var venta in ListaCodigoVentas)
            {
                cboxCodigoEmpleado.Items.Add(venta);
            }

            cboxCodigoEmpleado.DisplayMember = "Text";
            cboxCodigoEmpleado.ValueMember = "Value";
        }

        private void MtdMostrarListaCodigoGranja()
        {
            var ListaCodigoVentas = cd_Envio.MtdListaCodigoGranja();

            foreach (var venta in ListaCodigoVentas)
            {
                cboxCodigoGranja.Items.Add(venta);
            }

            cboxCodigoGranja.DisplayMember = "Text";
            cboxCodigoGranja.ValueMember = "Value";
        }

        public void MtdConsultaDetalleVenta()
        {

            DataTable dtDetalleVenta = cd_Envio.mtdConsultarTablaEnvios();
            dgvEnvio.DataSource = dtDetalleVenta;


        }

        private void dgvEnvio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigoEnvio.Text = dgvEnvio.CurrentRow.Cells[0].Value.ToString();
            cboxCodigoVentas.Text = dgvEnvio.CurrentRow.Cells[1].Value.ToString();  
            cboxCodigoEmpleado.Text = dgvEnvio.CurrentRow.Cells[2].Value.ToString();
            cboxCodigoGranja.Text = dgvEnvio.CurrentRow.Cells[3].Value.ToString();

            if (DateTime.TryParse(dgvEnvio.CurrentRow.Cells[4].Value?.ToString(), out DateTime fecha))
            {
                dtpFechaEnvio.Value = fecha;
            }
            else
            {

                dtpFechaEnvio.Value = DateTime.Now;
            }

            txtDireccion.Text = dgvEnvio.CurrentRow.Cells[5].Value.ToString();
            txtTipoTransporte.Text = dgvEnvio.CurrentRow.Cells[6].Value.ToString();
            txtPlacaTransporte.Text = dgvEnvio.CurrentRow.Cells[7].Value.ToString();
            txtObservacion.Text = dgvEnvio.CurrentRow.Cells[8].Value.ToString();
            cboxEstadoEnvio.Text = dgvEnvio.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int CodigoEnvio = int.Parse(lblCodigoEnvio.Text);
            int CodigoVentas = Convert.ToInt32(cboxCodigoVentas.SelectedValue);
            int CodigoEmpleado = Convert.ToInt32(cboxCodigoEmpleado.SelectedValue);
            int CodigoGranja = Convert.ToInt32(cboxCodigoGranja.SelectedValue);
            DateTime Fecha = dtpFechaEnvio.Value;
            string Direccion = txtDireccion.Text;
            string TipoTransporte = txtTipoTransporte.Text;
            string PlacaTransporte = txtPlacaTransporte.Text;
            string Estado = cboxEstadoEnvio.Text;
            string UsuarioAuditoria = ""; 
            DateTime FechaAuditoria = DateTime.Now; 
            cd_Envio.MtdEditarEnvio(CodigoEnvio, CodigoVentas, CodigoEmpleado, CodigoGranja, Fecha, Direccion, TipoTransporte, PlacaTransporte, Estado, UsuarioAuditoria, FechaAuditoria);
            MtdLimpiarCampos();
            MtdConsultaDetalleVenta();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int CodigoEnvio = int.Parse(lblCodigoEnvio.Text);
            cd_Envio.MtdEliminarEnvio(CodigoEnvio);
            MtdLimpiarCampos();
            MtdConsultaDetalleVenta();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblCodigoEnvio.Text = "";
            cboxCodigoVentas.SelectedIndex = -1;
            cboxCodigoEmpleado.SelectedIndex = -1;
            cboxCodigoGranja.SelectedIndex = -1;
            dtpFechaEnvio.Value = DateTime.Now;
            txtDireccion.Text = "";
            txtTipoTransporte.Text = "";
            txtPlacaTransporte.Text = "";
            txtObservacion.Text = "";
            cboxEstadoEnvio.SelectedIndex = -1;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
