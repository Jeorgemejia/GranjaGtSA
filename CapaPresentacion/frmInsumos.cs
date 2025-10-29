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

            var ListaCodigoProveedores= cd_Insumos.MtdListaCodigoProveedores();

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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int CodigoProveedor = int.Parse(cboxProveedor.Text.Split('-')[0].Trim());
            string Nombre = txtNombreInsumo.Text;
            string Tipo = cboxtipoInsumo.Text;
            decimal CostoUnitario= decimal.Parse(txtCostoUnitarioInsumo.Text.ToString());
            decimal UnidadMedida = decimal.Parse(txtUnidadMedidaInsumo.Text.ToString());
            decimal Peso = decimal.Parse(txtPeso.Text.ToString());
            string Observacion = txtObservacion.Text;
            string Estado = cboxEstadoInsumo.Text;
            string UsuarioAuditoria="";
            DateTime FechaAuditoria = DateTime.Parse(lblFechaSistema.Text.ToString());
            cd_Insumos.mtdAgregarInsumos(CodigoProveedor,  Nombre,  Tipo,  CostoUnitario,  UnidadMedida,  Peso,  Observacion,  Estado,  UsuarioAuditoria,  FechaAuditoria);

            MtdConsultaInsumos();
        }


        private void mtdLimpiarCampos()
        { 
        
        }
    }
}
