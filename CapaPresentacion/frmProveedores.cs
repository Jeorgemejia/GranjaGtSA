using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class frmProveedores : Form
    {
        cdConexiones cdconexiones = new cdConexiones();
        cdProveedores cd_Proveedores = new cdProveedores ();
        
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            lblFechaSistema.Text = DateTime.Now.ToString();
            lblCodigoProveedor.Text = "";
            mtdConsultarProveedores();
        }

        public void mtdConsultarProveedores()
        {
            
            DataTable dtProveedores = cd_Proveedores.MtdConsultarProveedores();
            dgvProveedores.DataSource = dtProveedores;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
                string Nombre = txtNombreProveedor.Text;
                int Telefono = int.Parse(txtTelefonoProveedor.Text);
                string Correo = txtCorreoProveedor.Text;
                string Direccion = txtDireccionProveedor.Text;
                string Estado = cboxEstadoProveedor.Text;
                string UsuarioAuditoria = "";
                DateTime FechaAuditoria = DateTime.Now;
                cd_Proveedores.MtdAgregarProveedores( Nombre,  Telefono,  Correo,  Direccion,  Estado,  UsuarioAuditoria,  FechaAuditoria);
                mtdConsultarProveedores();
                mtdLimpiarCampos();
                MessageBox.Show("Proveedor guardado: ", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            

           

            
        }

        private void mtdLimpiarCampos()
        {
            txtNombreProveedor.Text="";
            txtTelefonoProveedor.Text="";
            txtCorreoProveedor.Text="";
            txtDireccionProveedor.Text = "";
            cboxEstadoProveedor.Text = "";

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int CodigoProveedor = int.Parse(lblCodigoProveedor.Text);
                string Nombre = txtNombreProveedor.Text;
                int Telefono = int.Parse(txtTelefonoProveedor.Text);
                string Correo = txtCorreoProveedor.Text;
                string Direccion = txtDireccionProveedor.Text;
                string Estado = cboxEstadoProveedor.Text;
                string UsuarioAuditoria = "";
                DateTime FechaAuditoria = DateTime.Parse(lblFechaSistema.Text);
                cd_Proveedores.MtdActualizarProveedores(CodigoProveedor, Nombre, Telefono, Correo, Direccion, Estado, UsuarioAuditoria, FechaAuditoria);
                mtdConsultarProveedores();
                mtdLimpiarCampos();
                MessageBox.Show("Proveedor actualizado: ", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                int CodigoMenu = int.Parse(lblCodigoProveedor.Text);
                cd_Proveedores.MtdEliminarProveedores(CodigoMenu);
                mtdConsultarProveedores();
                mtdLimpiarCampos();
                MessageBox.Show("Proveedor eliminado Correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception ex)
            {

                if (lblCodigoProveedor.Text == "" && txtNombreProveedor.Text == "" && txtDireccionProveedor.Text == "" && txtCorreoProveedor.Text == "" && txtTelefonoProveedor.Text == "" && cboxEstadoProveedor.Text == "")


                    MessageBox.Show("Seleccione un menú", "Tonto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mtdLimpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigoProveedor.Text = dgvProveedores.SelectedCells[0].Value.ToString();
            txtNombreProveedor.Text = dgvProveedores.SelectedCells[1].Value.ToString();
            txtTelefonoProveedor.Text = dgvProveedores.SelectedCells[2].Value.ToString();
            txtDireccionProveedor.Text = dgvProveedores.SelectedCells[3].Value.ToString();
            txtCorreoProveedor.Text = dgvProveedores.SelectedCells[4].Value.ToString();
            cboxEstadoProveedor.Text = dgvProveedores.SelectedCells[5].Value.ToString();

        }
    }
}
