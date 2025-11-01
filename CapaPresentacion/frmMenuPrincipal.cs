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
          
            AbrirFormulario<frmRoles>();
        }

        
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
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
                formulario.Show();          // mostrar por primera vez
                formulario.BringToFront();
            }
            else
            {
                formulario.Show();          // mostrar si estaba oculto
                formulario.BringToFront();  // traer al frente
            }
        }

        
        

        private void btnRoles_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<frmRoles>();
        }
    }
}
    