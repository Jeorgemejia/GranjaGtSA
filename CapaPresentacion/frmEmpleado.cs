using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class frmEmpleado : Form
    {
        cdEmpleados cd_Empleados = new cdEmpleados();

        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            ConfigurarDGV();
            mtdCargarCombos();
            mtdCargarEmpleados();
            mtdLimpiarCampos();
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
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
            dgvEmpleados.DataSource = cd_Empleados.mtdConsultarTablaEmpleados();
        }

        private void mtdCargarCombos()
        {
            // Combos desde la BD
            cboGranja.DataSource = cd_Empleados.mtdConsultarGranjas();
            cboGranja.DisplayMember = "Nombre";
            cboGranja.ValueMember = "CodigoGranja";

            cboUsuario.DataSource = cd_Empleados.mtdConsultarUsuarios();
            cboUsuario.DisplayMember = "Nombre";
            cboUsuario.ValueMember = "CodigoUsuario";

            // Estado
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
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
            cd_Empleados.mtdAgregarEmpleado(
                Convert.ToInt32(cboGranja.SelectedValue),
                Convert.ToInt32(cboUsuario.SelectedValue),
                txtNombreEmpleado.Text,
                int.Parse(txtTelefono.Text),
                txtCorreo.Text,
                txtCargo.Text,
                decimal.Parse(txtSalarioBase.Text),
                dtpFechaIngreso.Value,
                cboEstado.Text,
                "Sistema",
                DateTime.Now
            );
            mtdCargarEmpleados();
            mtdLimpiarCampos();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblCodigoEmpleado.Text)) return;

            cd_Empleados.mtdActualizarEmpleado(
                int.Parse(lblCodigoEmpleado.Text),
                Convert.ToInt32(cboGranja.SelectedValue),
                Convert.ToInt32(cboUsuario.SelectedValue),
                txtNombreEmpleado.Text,
                int.Parse(txtTelefono.Text),
                txtCorreo.Text,
                txtCargo.Text,
                decimal.Parse(txtSalarioBase.Text),
                dtpFechaIngreso.Value,
                cboEstado.Text,
                "Sistema",
                DateTime.Now
            );
            mtdCargarEmpleados();
            mtdLimpiarCampos();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblCodigoEmpleado.Text)) return;

            cd_Empleados.mtdEliminarEmpleado(int.Parse(lblCodigoEmpleado.Text));
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
            if (e.RowIndex < 0) return;

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
}
