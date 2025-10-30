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
    public partial class frmRoles : Form
    {
        cdRoles cd_Roles = new cdRoles();

        public frmRoles()
        {
            InitializeComponent();
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            MtdConsultaRoles();
            mtdLlenarCombos();
            mtdLimpiarCampos();
        }

        private void MtdConsultaRoles()
        {
            DataTable dt = cd_Roles.mtdConsultarTablaRoles();
            dgvRoles.DataSource = dt;
        }

        private void mtdLlenarCombos()
        {
            string[] opciones = { "Sí", "No" };
            cboxFormConsul.Items.AddRange(opciones);
            cboxFormAdd.Items.AddRange(opciones);
            cboxFormEdi.Items.AddRange(opciones);
            cboxFormDel.Items.AddRange(opciones);
            cboxAccesoDashboard.Items.AddRange(opciones);
            cboxAccesoReportes.Items.AddRange(opciones);
            cboxAccesoConfiguracion.Items.AddRange(opciones);

            cboxEstado.Items.Add("Activo");
            cboxEstado.Items.Add("Inactivo");
        }

        private int ValorBit(string opcion)
        {
            return opcion == "Sí" ? 1 : 0;
        }

     
        private void mtdLimpiarCampos()
        {
            lblCodigoRol.Text = "";
            txtNombreRol.Text = "";
            cboxFormConsul.Text = "";
            cboxFormAdd.Text = "";
            cboxFormEdi.Text = "";
            cboxFormDel.Text = "";
            cboxAccesoDashboard.Text = "";
            cboxAccesoReportes.Text = "";
            cboxAccesoConfiguracion.Text = "";
            cboxEstado.Text = "";
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string Nombre = txtNombreRol.Text;
            int FormConsul = ValorBit(cboxFormConsul.Text);
            int FormAdd = ValorBit(cboxFormAdd.Text);
            int FormEdi = ValorBit(cboxFormEdi.Text);
            int FormDel = ValorBit(cboxFormDel.Text);
            int AccesoDashboard = ValorBit(cboxAccesoDashboard.Text);
            int AccesoReportes = ValorBit(cboxAccesoReportes.Text);
            int AccesoConfiguracion = ValorBit(cboxAccesoConfiguracion.Text);
            string Estado = cboxEstado.Text;
            string UsuarioAuditoria = "Sistema";
            DateTime FechaAuditoria = DateTime.Now;

            cd_Roles.mtdAgregarRol(Nombre, FormConsul, FormAdd, FormEdi, FormDel, AccesoDashboard, AccesoReportes, AccesoConfiguracion, Estado, UsuarioAuditoria, FechaAuditoria);
            MtdConsultaRoles();
            mtdLimpiarCampos();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(lblCodigoRol.Text))
            {
                MessageBox.Show("Seleccione un rol para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int CodigoRol = int.Parse(lblCodigoRol.Text);
                string Nombre = txtNombreRol.Text;

                // Si algún combo está vacío, lo tratamos como "No"
                int FormConsul = ValorBit(string.IsNullOrEmpty(cboxFormConsul.Text) ? "No" : cboxFormConsul.Text);
                int FormAdd = ValorBit(string.IsNullOrEmpty(cboxFormAdd.Text) ? "No" : cboxFormAdd.Text);
                int FormEdi = ValorBit(string.IsNullOrEmpty(cboxFormEdi.Text) ? "No" : cboxFormEdi.Text);
                int FormDel = ValorBit(string.IsNullOrEmpty(cboxFormDel.Text) ? "No" : cboxFormDel.Text);
                int AccesoDashboard = ValorBit(string.IsNullOrEmpty(cboxAccesoDashboard.Text) ? "No" : cboxAccesoDashboard.Text);
                int AccesoReportes = ValorBit(string.IsNullOrEmpty(cboxAccesoReportes.Text) ? "No" : cboxAccesoReportes.Text);
                int AccesoConfiguracion = ValorBit(string.IsNullOrEmpty(cboxAccesoConfiguracion.Text) ? "No" : cboxAccesoConfiguracion.Text);

                string Estado = string.IsNullOrEmpty(cboxEstado.Text) ? "Inactivo" : cboxEstado.Text;
                string UsuarioAuditoria = "Sistema";
                DateTime FechaAuditoria = DateTime.Now;

                cd_Roles.mtdActualizarRol(CodigoRol, Nombre, FormConsul, FormAdd, FormEdi, FormDel,
                                          AccesoDashboard, AccesoReportes, AccesoConfiguracion,
                                          Estado, UsuarioAuditoria, FechaAuditoria);

                MessageBox.Show("Rol actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MtdConsultaRoles();
                mtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el rol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int CodigoRol = int.Parse(lblCodigoRol.Text);
            cd_Roles.mtdEliminarRol(CodigoRol);
            MtdConsultaRoles();
            mtdLimpiarCampos();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            mtdLimpiarCampos();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRoles_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow fila = dgvRoles.Rows[e.RowIndex];
                lblCodigoRol.Text = fila.Cells[0].Value.ToString();
                txtNombreRol.Text = fila.Cells[1].Value.ToString();
                cboxFormConsul.Text = (bool)fila.Cells[2].Value ? "Sí" : "No";
                cboxFormAdd.Text = (bool)fila.Cells[3].Value ? "Sí" : "No";
                cboxFormEdi.Text = (bool)fila.Cells[4].Value ? "Sí" : "No";
                cboxFormDel.Text = (bool)fila.Cells[5].Value ? "Sí" : "No";
                cboxAccesoDashboard.Text = (bool)fila.Cells[6].Value ? "Sí" : "No";
                cboxAccesoReportes.Text = (bool)fila.Cells[7].Value ? "Sí" : "No";
                cboxAccesoConfiguracion.Text = (bool)fila.Cells[8].Value ? "Sí" : "No";
                cboxEstado.Text = fila.Cells[9].Value.ToString();
            }
        }
    }
}
