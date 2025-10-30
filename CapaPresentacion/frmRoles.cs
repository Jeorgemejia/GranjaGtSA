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

        private void btnGuardar_Click(object sender, EventArgs e)
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int CodigoRol = int.Parse(lblCodigoRol.Text);
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

            cd_Roles.mtdActualizarRol(CodigoRol, Nombre, FormConsul, FormAdd, FormEdi, FormDel, AccesoDashboard, AccesoReportes, AccesoConfiguracion, Estado, UsuarioAuditoria, FechaAuditoria);
            MtdConsultaRoles();
            mtdLimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int CodigoRol = int.Parse(lblCodigoRol.Text);
            cd_Roles.mtdEliminarRol(CodigoRol);
            MtdConsultaRoles();
            mtdLimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mtdLimpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigoRol.Text = dgvRoles.SelectedCells[0].Value.ToString();
            txtNombreRol.Text = dgvRoles.SelectedCells[1].Value.ToString();
            cboxFormConsul.Text = (bool)dgvRoles.SelectedCells[2].Value ? "Sí" : "No";
            cboxFormAdd.Text = (bool)dgvRoles.SelectedCells[3].Value ? "Sí" : "No";
            cboxFormEdi.Text = (bool)dgvRoles.SelectedCells[4].Value ? "Sí" : "No";
            cboxFormDel.Text = (bool)dgvRoles.SelectedCells[5].Value ? "Sí" : "No";
            cboxAccesoDashboard.Text = (bool)dgvRoles.SelectedCells[6].Value ? "Sí" : "No";
            cboxAccesoReportes.Text = (bool)dgvRoles.SelectedCells[7].Value ? "Sí" : "No";
            cboxAccesoConfiguracion.Text = (bool)dgvRoles.SelectedCells[8].Value ? "Sí" : "No";
            cboxEstado.Text = dgvRoles.SelectedCells[9].Value.ToString();
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

        private void cboxFormConsul_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
