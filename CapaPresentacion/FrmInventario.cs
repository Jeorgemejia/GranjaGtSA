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
    public partial class FrmInventario : Form
    {

        cdInventario cd_Inventario = new cdInventario();
        clInventario cl_Inventario = new clInventario();
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            lblFechaSistema.Text = DateTime.Now.ToString();
            MtdConsultaInventario();
            MtdMostrarListaCodigoGranja();
            MtdMostrarListaCodigoInsumo();
        }

        public void MtdConsultaInventario()
        {

            DataTable dtInventario = cd_Inventario.mtdConsultarTablaInventario();
            dgvInventario.DataSource = dtInventario;


        }


        private void MtdMostrarListaCodigoGranja()
        {

            var ListaCodigoGranja = cd_Inventario.MtdListaCodigoGranja();

            foreach (var Proveedor in ListaCodigoGranja)
            {
                cboxCodigoGranja.Items.Add(Proveedor);
            }

            cboxCodigoGranja.DisplayMember = "Text";
            cboxCodigoGranja.ValueMember = "Value";
        }

        private void MtdMostrarListaCodigoInsumo()
        {

            var ListaCodigoInsumo = cd_Inventario.MtdListaCodigoInsumo();

            foreach (var Insumo in ListaCodigoInsumo)
            {
                cboxCodigoInsumo.Items.Add(Insumo);
            }

            cboxCodigoInsumo.DisplayMember = "Text";
            cboxCodigoInsumo.ValueMember = "Value";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int CodigoGranja = int.Parse(cboxCodigoGranja.Text.Split('-')[0].Trim());
            int CodigoInsumo = int.Parse(cboxCodigoInsumo.Text.Split('-')[0].Trim());
            int CantidadDisponible = int.Parse(txtCantidadDisponible.Text);
            decimal CostoUnitario = decimal.Parse(txtCostoUnitarioInventario.Text);
            decimal CostoTotal = cl_Inventario.mtdTotalCosto(int.Parse(txtCantidadDisponible.Text), decimal.Parse(txtCostoUnitarioInventario.Text));
            CostoTotal=decimal.Parse(lblTotalCosto.Text);
            DateTime FechaRegistro = DateTime.Parse(dtpFechaRegistroInventario.Text);
            string Estado = cboxEstadoInventario.Text;
            string UsuarioAuditoria = "";
            DateTime FechaAuditoria = DateTime.Parse(lblFechaSistema.Text);
            cd_Inventario.mtdAgregarInventario(CodigoGranja, CodigoInsumo, CantidadDisponible, CostoUnitario, CostoTotal, FechaRegistro, Estado, UsuarioAuditoria, FechaAuditoria);

            MtdConsultaInventario();
        }

        private void btnCalcularCostoTotal_Click(object sender, EventArgs e)
        {
            lblTotalCosto.Text = cl_Inventario.mtdTotalCosto(decimal.Parse(txtCantidadDisponible.Text), decimal.Parse(txtCostoUnitarioInventario.Text)).ToString();
        }
    }
}
