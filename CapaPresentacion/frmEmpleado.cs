using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmEmpleado : Form
    {
        cdEmpleados cd_Empleados = new cdEmpleados();

        public frmEmpleado()
        {
            InitializeComponent();
        }


        private void ConfigurarDGV()
        {
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.MultiSelect = false;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.RowHeadersVisible = false;
        }

        private void mtdCargarEmpleados()
        {
            DataTable dt = cd_Empleados.mtdConsultarTablaEmpleados();
            dgvEmpleados.DataSource = dt;
        }

        private void mtdCargarCombos()
        {
            // Estado
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");

            // Combos desde la BD
            cboGranja.DataSource = cd_Empleados.mtdConsultarGranjas();
            cboGranja.DisplayMember = "Nombre";
            cboGranja.ValueMember = "CodigoGranja";

            cboUsuario.DataSource = cd_Empleados.mtdConsultarUsuarios();
            cboUsuario.DisplayMember = "Nombre";
            cboUsuario.ValueMember = "CodigoUsuario";
        }

      
        private void mtdLimpiarCampos()
        {
            lblCodigoEmpleado.Text = "";
            cboGranja.SelectedIndex = -1;
            cboUsuario.SelectedIndex = -1;
            txtNombreEmpleado.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtCargo.Text = "";
            txtSalarioBase.Text = "";
            dtpFechaIngreso.Value = DateTime.Now;
            cboEstado.SelectedIndex = -1;
        }



        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            int CodigoGranja = Convert.ToInt32(cboGranja.SelectedValue);
            int CodigoUsuario = Convert.ToInt32(cboUsuario.SelectedValue);
            string Nombre = txtNombreEmpleado.Text;
            int Telefono = int.Parse(txtTelefono.Text);
            string Correo = txtCorreo.Text;
            string Cargo = txtCargo.Text;
            decimal SalarioBase = decimal.Parse(txtSalarioBase.Text);
            DateTime FechaIngreso = dtpFechaIngreso.Value;
            string Estado = cboEstado.Text;
            string UsuarioAuditoria = "Sistema";
            DateTime FechaAuditoria = DateTime.Now;

            cd_Empleados.mtdAgregarEmpleado(CodigoGranja, CodigoUsuario, Nombre, Telefono, Correo, Cargo, SalarioBase, FechaIngreso, Estado, UsuarioAuditoria, FechaAuditoria);
            MessageBox.Show("Empleado agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mtdCargarEmpleados();
            mtdLimpiarCampos();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblCodigoEmpleado.Text))
            {
                MessageBox.Show("Seleccione un empleado para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int CodigoEmpleado = int.Parse(lblCodigoEmpleado.Text);
            int CodigoGranja = Convert.ToInt32(cboGranja.SelectedValue);
            int CodigoUsuario = Convert.ToInt32(cboUsuario.SelectedValue);
            string Nombre = txtNombreEmpleado.Text;
            int Telefono = int.Parse(txtTelefono.Text);
            string Correo = txtCorreo.Text;
            string Cargo = txtCargo.Text;
            decimal SalarioBase = decimal.Parse(txtSalarioBase.Text);
            DateTime FechaIngreso = dtpFechaIngreso.Value;
            string Estado = cboEstado.Text;
            string UsuarioAuditoria = "Sistema";
            DateTime FechaAuditoria = DateTime.Now;

            cd_Empleados.mtdActualizarEmpleado(CodigoEmpleado, CodigoGranja, CodigoUsuario, Nombre, Telefono, Correo, Cargo, SalarioBase, FechaIngreso, Estado, UsuarioAuditoria, FechaAuditoria);
            MessageBox.Show("Empleado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mtdCargarEmpleados();
            mtdLimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblCodigoEmpleado.Text))
            {
                MessageBox.Show("Seleccione un empleado para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int CodigoEmpleado = int.Parse(lblCodigoEmpleado.Text);
            cd_Empleados.mtdEliminarEmpleado(CodigoEmpleado);
            MessageBox.Show("Empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mtdCargarEmpleados();
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

        private void dgvEmpleados_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvEmpleados.Rows[e.RowIndex];

                lblCodigoEmpleado.Text = fila.Cells["CodigoEmpleado"].Value.ToString();
                cboGranja.SelectedValue = fila.Cells["CodigoGranja"].Value;
                cboUsuario.SelectedValue = fila.Cells["CodigoUsuario"].Value;
                txtNombreEmpleado.Text = fila.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
                txtCargo.Text = fila.Cells["Cargo"].Value.ToString();
                txtSalarioBase.Text = fila.Cells["Salariobase"].Value.ToString();
                dtpFechaIngreso.Value = Convert.ToDateTime(fila.Cells["FechaIngreso"].Value);
                cboEstado.Text = fila.Cells["Estado"].Value.ToString();
            }
        }

        private void frmEmpleado_Load_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Server=tcp:proyectofinaldb1.database.windows.net,1433;Initial Catalog=db_GranjaGtSA;Persist Security Info=False;User ID=usuario;Password=Proyectofinal1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
                conexion.Open();
                MessageBox.Show("Conexión abierta correctamente");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }

            ConfigurarDGV();
            mtdCargarCombos();
            mtdCargarEmpleados();
            mtdLimpiarCampos();
        }
    }
}
