using CapaSeguridad;
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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

            try
            {
                AbrirFormulario<frmRoles>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el menú principal:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            try
            {
                Form formulario = panelMenu.Controls.OfType<MiForm>().FirstOrDefault();

                if (formulario == null)
                {
                    formulario = new MiForm();
                    formulario.TopLevel = false;
                    formulario.FormBorderStyle = FormBorderStyle.None;
                    formulario.Dock = DockStyle.Fill;
                    panelMenu.Controls.Add(formulario);
                    panelMenu.Tag = formulario;
                    formulario.Show();
                    formulario.BringToFront();
                }
                else
                {
                    formulario.Show();
                    formulario.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

               

        private void btnRoles_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<frmRoles>();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmUsuarios>();
        }

        private void btnPagoVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmPagoVentas>();
        }

        private void btnPagoEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmPago>();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEmpleado>();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmInventario>();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmProveedores>();
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmInsumos>();
        }

        private void btnPagoProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmPagoProveedor>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAnimales>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmClientes>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCultivo>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmDetalleVenta>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEnvio>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmGranja>();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmProducto>();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmVentas>();
        }
    }
}
    