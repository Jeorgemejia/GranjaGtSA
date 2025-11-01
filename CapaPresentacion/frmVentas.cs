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
            lblCodigoVenta.Text = "";
            MostrarVentas();
        }


        private void MostrarVentas()
        {
            dgvVentas.DataSource = cd_Ventas.mtdConsultarConsultarTablaVentas();
        }

    }
}
