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
            lblFechaSistema.Text = DateTime.Now.ToString();
            mtdConsultaPagoProveedores();
        }

        public void mtdConsultaPagoProveedores()
        {

            DataTable dtPagoProveedor = cd_PagoProveedores.mtdConsultarTablaPagoProveedores();
            dgvPagoProveedores.DataSource = dtPagoProveedor;

        }
    }
}
