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
    public partial class frmVentas : Form
    {



        cdVentas cd_Ventas = new cdVentas();
        clVentas cl_Ventas = new clVentas();

        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            lblFechaSistema.Text = DateTime.Now.ToString();
            lblCodigoVenta.Text = "";
            mtdMostrarVentas();
            MtdMostrarListaCodigoClientes();
            MtdMostrarListaCodigoEmpleados();
            mtdMostrarTotalVentaPorCodigo();
        }

       
        private void mtdMostrarVentas()
        {
            dgvVentas.DataSource = cd_Ventas.mtdConsultarConsultarTablaVentas();
        }


        
        private void MtdMostrarListaCodigoClientes()
        {

            var ListaCodigoClientes = cd_Ventas.MtdListaCodigoCliente();

            foreach (var Cliente in ListaCodigoClientes)
            {
                cboxCodigoCliente.Items.Add(Cliente);
            }

            cboxCodigoCliente.DisplayMember = "Text";
            cboxCodigoCliente.ValueMember = "Value";
        }


        private void MtdMostrarListaCodigoEmpleados()
        {

            var ListaCodigoEmpleados = cd_Ventas.MtdListaCodigoEmpleado();

            foreach (var Cliente in ListaCodigoEmpleados)
            {
                cboxCodigoEmpleado.Items.Add(Cliente);
            }

            cboxCodigoEmpleado.DisplayMember = "Text";
            cboxCodigoEmpleado.ValueMember = "Value";
        }

        private void cboxCodigoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {



            if (cboxCodigoEmpleado.SelectedItem != null)
            {
                var propertyInfo = cboxCodigoEmpleado.SelectedItem.GetType().GetProperty("Value");
                if (propertyInfo != null)
                {
                    var value = propertyInfo.GetValue(cboxCodigoEmpleado.SelectedItem);
                    if (value != null && int.TryParse(value.ToString(), out int idEmpleado))
                    {
                        string nombreGranja = cl_Ventas.MtdObtenerNombreGranja(idEmpleado);

                        lblCodigoGranja.Text = nombreGranja;
                    }
                    else
                    {
                        lblCodigoGranja.Text = string.Empty;
                    }
                }
                else
                {
                    lblCodigoGranja.Text = string.Empty;
                }
            }
            else
            {
                lblCodigoGranja.Text = string.Empty;
            }
        }


        private void mtdMostrarTotalVentaPorCodigo()
        {
            if (!string.IsNullOrEmpty(lblCodigoVenta.Text) && int.TryParse(lblCodigoVenta.Text, out int codigoVenta))
            {
                decimal totalVenta = cl_Ventas.MtdObtenerTotalVentaPorCodigo(codigoVenta);
                txtTotalVenta.Text = totalVenta.ToString("C"); 
            }
            else
            {
                txtTotalVenta.Text = "0.00";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int CodigoCliente = int.Parse(cboxCodigoCliente.Text.Split('-')[0].Trim());
            int CodigoEmpleado = int.Parse(cboxCodigoEmpleado.Text.Split('-')[0].Trim());
            DateTime FechaVenta = DateTime.Parse(dtpFechaVenta.Text);
            string TipoVenta = cboxTipoVenta.Text;
            decimal TotalVenta = decimal.Parse(txtTotalVenta.Text);
            string Estado = cboxEstado.Text;
            string UsuarioAuditoria = "";
            DateTime FechaAuditoria = DateTime.Parse(lblFechaSistema.Text);
            cd_Ventas.MtdAgregarVenta(CodigoCliente, CodigoEmpleado, FechaVenta, TipoVenta, TotalVenta, Estado, UsuarioAuditoria, FechaAuditoria);

            mtdMostrarVentas();
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigoVenta.Text = dgvVentas.SelectedCells[0].Value.ToString();
            cboxCodigoCliente.Text = dgvVentas.SelectedCells[1].Value.ToString();
            cboxCodigoEmpleado.Text = dgvVentas.SelectedCells[2].Value.ToString();
            dtpFechaVenta.Text = dgvVentas.SelectedCells[3].Value.ToString();
            cboxTipoVenta.Text = dgvVentas.SelectedCells[4].Value.ToString();
            txtTotalVenta.Text = dgvVentas.SelectedCells[5].Value.ToString();
            cboxEstado.Text = dgvVentas.SelectedCells[6].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int CodigoVentas = int.Parse(lblCodigoVenta.Text);
            int CodigoCliente = int.Parse(cboxCodigoCliente.Text.Split('-')[0].Trim());
            int CodigoEmpleado = int.Parse(cboxCodigoEmpleado.Text.Split('-')[0].Trim());
            DateTime FechaVenta = DateTime.Parse(dtpFechaVenta.Text);
            string TipoVenta = cboxTipoVenta.Text;
            decimal TotalVenta = decimal.Parse(txtTotalVenta.Text);
            string Estado = cboxEstado.Text;
            string UsuarioAuditoria = "";
            DateTime FechaAuditoria = DateTime.Parse(lblFechaSistema.Text.ToString());
            cd_Ventas.MtdActualizarVenta(CodigoVentas, CodigoCliente, CodigoEmpleado, FechaVenta, TipoVenta, TotalVenta, Estado, UsuarioAuditoria, FechaAuditoria);

            mtdMostrarVentas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int CodigoVentas = int.Parse(lblCodigoVenta.Text);
           
            cd_Ventas.MtdEliminarrVenta(CodigoVentas);

            mtdMostrarVentas();
        }

        private void mtdLImpiarCampos()
        {
            lblCodigoVenta.Text = "";
            cboxCodigoCliente.Text = "";
            cboxCodigoEmpleado.Text = "";
            dtpFechaVenta.Text = "";
            cboxTipoVenta.Text = "";
            txtTotalVenta.Text = "";
            txtTotalVenta.Text = "";
            cboxEstado.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mtdLImpiarCampos();
        }
    }
    }


