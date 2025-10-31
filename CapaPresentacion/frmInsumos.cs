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
    public partial class frmInsumos : Form
    {
        cdInsumos cd_Insumos = new cdInsumos();
        public frmInsumos()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void MtdConsultaInsumos()
        {

            DataTable dtInsumos = cd_Insumos.mtdConsultarTablaInsumos();
            dgvInsumos.DataSource = dtInsumos;


        }



        private void MtdMostrarListaCodigoProveedores()
        {

            var ListaCodigoProveedores = cd_Insumos.MtdListaCodigoProveedores();

            foreach (var Proveedor in ListaCodigoProveedores)
            {
                cboxProveedor.Items.Add(Proveedor);
            }

            cboxProveedor.DisplayMember = "Text";
            cboxProveedor.ValueMember = "Value";
        }

        private void frmInsumos_Load(object sender, EventArgs e)
        {
            MtdConsultaInsumos();
            MtdMostrarListaCodigoProveedores();
            DateTime fechahoy = DateTime.Now;
            lblFechaSistema.Text = fechahoy.ToString();
            mtdLimpiarcammpos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int CodigoProveedor = int.Parse(cboxProveedor.Text.Split('-')[0].Trim());
            string Nombre = txtNombreInsumo.Text;
            string Tipo = cboxtipoInsumo.Text;
            decimal CostoUnitario = decimal.Parse(txtCostoUnitarioInsumo.Text);
            string UnidadMedida = (txtUnidadMedidaInsumo.Text);
            decimal Peso = decimal.Parse(txtPeso.Text.ToString());
            string Observacion = txtObservacion.Text;
            string Estado = cboxEstadoInsumo.Text;
            string UsuarioAuditoria = "";
            DateTime FechaAuditoria = DateTime.Parse(lblFechaSistema.Text.ToString());
            cd_Insumos.mtdAgregarInsumos(CodigoProveedor, Nombre, Tipo, CostoUnitario, UnidadMedida, Peso, Observacion, Estado, UsuarioAuditoria, FechaAuditoria);

            MtdConsultaInsumos();
            mtdLimpiarcammpos();
        }


        

        private void dgvInsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigoInsumo.Text = dgvInsumos.SelectedCells[0].Value.ToString();
            cboxProveedor.Text = dgvInsumos.SelectedCells[1].Value.ToString();
            txtNombreInsumo.Text = dgvInsumos.SelectedCells[2].Value.ToString();
            cboxtipoInsumo.Text = dgvInsumos.SelectedCells[3].Value.ToString();
            txtCostoUnitarioInsumo.Text = dgvInsumos.SelectedCells[4].Value.ToString();
            txtUnidadMedidaInsumo.Text = dgvInsumos.SelectedCells[5].Value.ToString();
            txtPeso.Text = dgvInsumos.SelectedCells[6].Value.ToString();
            txtObservacion.Text = dgvInsumos.SelectedCells[7].Value.ToString();
            cboxEstadoInsumo.Text = dgvInsumos.SelectedCells[8].Value.ToString();



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int CodigoInsumo = int.Parse(lblCodigoInsumo.Text);
            int CodigoProveedor = int.Parse(cboxProveedor.Text.Split('-')[0].Trim());
            string Nombre = txtNombreInsumo.Text;
            string Tipo = cboxtipoInsumo.Text;
            decimal CostoUnitario = decimal.Parse(txtCostoUnitarioInsumo.Text);
            string UnidadMedida = (txtUnidadMedidaInsumo.Text);
            decimal Peso = decimal.Parse(txtPeso.Text.ToString());
            string Observacion = txtObservacion.Text;
            string Estado = cboxEstadoInsumo.Text;
            string UsuarioAuditoria = "";
            DateTime FechaAuditoria = DateTime.Parse(lblFechaSistema.Text.ToString());
            cd_Insumos.mtdActualizarInsumos(CodigoInsumo, CodigoProveedor, Nombre, Tipo, CostoUnitario, UnidadMedida, Peso, Observacion, Estado, UsuarioAuditoria, FechaAuditoria);

            MtdConsultaInsumos();
            mtdLimpiarcammpos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int CodigoInsumo = int.Parse(lblCodigoInsumo.Text);

            cd_Insumos.mtdEliminarnInsumos(CodigoInsumo);

            MtdConsultaInsumos();
            mtdLimpiarcammpos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblCodigoInsumo.Text = "";
            cboxProveedor.Text = "";
            txtNombreInsumo.Text = "";
            cboxtipoInsumo.Text = "";
            txtCostoUnitarioInsumo.Text = "";
            txtUnidadMedidaInsumo.Text = "";
            txtPeso.Text = "";
            txtObservacion.Text = "";
            cboxEstadoInsumo.Text = "";
        }
    

    public void mtdLimpiarcammpos()
        {
            lblCodigoInsumo.Text = "";
            cboxProveedor.Text = "";
            txtNombreInsumo.Text = "";
            cboxtipoInsumo.Text = "";
            txtCostoUnitarioInsumo.Text = "";
            txtUnidadMedidaInsumo.Text = "";
            txtPeso.Text = "";
            txtObservacion.Text = "";
            cboxEstadoInsumo.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}