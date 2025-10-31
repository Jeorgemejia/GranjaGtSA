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
    public partial class FrmInventario : Form
    {

        cdInventario cd_Inventario = new cdInventario();
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            MtdConsultaInventario();
            MtdMostrarListaCodigoGranja();
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
    }
}
