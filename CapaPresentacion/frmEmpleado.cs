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
            try
            {
                ConfigurarDGV();
                mtdCargarCombos();
                mtdCargarEmpleados();
                mtdLimpiarCampos();
                lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la ventana: " + ex.Message);
            }
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
            try
            {
                dgvEmpleados.DataSource = cd_Empleados.mtdConsultarTablaEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
            }
        }

        private void mtdCargarCombos()
        {
            try
            {
                cboGranja.DataSource = cd_Empleados.mtdConsultarGranjas();
                cboGranja.DisplayMember = "Nombre";
                cboGranja.ValueMember = "CodigoGranja";

                cboUsuario.DataSource = cd_Empleados.mtdConsultarUsuarios();
                cboUsuario.DisplayMember = "Nombre";
                cboUsuario.ValueMember = "CodigoUsuario";

                cboEstado.Items.Clear();
                cboEstado.Items.Add("Activo");
                cboEstado.Items.Add("Inactivo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combos: " + ex.Message);
            }
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
        private bool ValidarCampos()
        {
            if (cboGranja.SelectedIndex == -1 ||
                cboUsuario.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtNombreEmpleado.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtCargo.Text) ||
                string.IsNullOrWhiteSpace(txtSalarioBase.Text) ||
                cboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe llenar todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("Teléfono inválido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtSalarioBase.Text, out _))
            {
                MessageBox.Show("Salario inválido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
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
                MessageBox.Show("Empleado guardado exitosamente.");
                mtdCargarEmpleados();
                mtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblCodigoEmpleado.Text))
            {
                MessageBox.Show("Debe seleccionar un empleado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidarCampos()) return;

            try
            {
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
                MessageBox.Show("Empleado actualizado.");
                mtdCargarEmpleados();
                mtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblCodigoEmpleado.Text))
            {
                MessageBox.Show("Seleccione un empleado para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este empleado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            try
            {
                cd_Empleados.mtdEliminarEmpleado(int.Parse(lblCodigoEmpleado.Text));
                MessageBox.Show("Empleado eliminado.");
                mtdCargarEmpleados();
                mtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            mtdLimpiarCampos();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvEmpleados_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error seleccionando fila: " + ex.Message);
            }
        }
    }
}
