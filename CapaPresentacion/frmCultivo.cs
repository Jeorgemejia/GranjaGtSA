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
    public partial class frmCultivo : Form
    {
        cdAnimales cd_Animales = new cdAnimales();
        public frmCultivo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int CodigoGranja = int.Parse(cboxCodigoGranja.Text.Split('-')[0].Trim());
            string 
        }
    }
}
