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
    public partial class frmAnimales : Form
    {
        cdAnimales cd_Animales = new cdAnimales();
        public frmAnimales()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int CodigoGranja = int.Parse(cboxCodigoGranja.Text.Split('-')[0].Trim());
            string TipoAnimal = txtTipoAnimal.Text;
            string Raza = txtRaza.Text;
            DateTime FechaNacimiento = DateTime.Parse(dtpFechaNacimiento.Text);
            decimal Precio = decimal.Parse(txtPrecio.Text);
            string Descripcion = txtDescripcion.Text;
            string Estado = cboxEstadoAnimal.Text;
            string UsuarioAuditoria = "";
            DateTime FechaAuditoria = DateTime.Now;
            cd_Animales.MtdAgregarAnimal(CodigoGranja, TipoAnimal, Raza, FechaNacimiento, Precio, Descripcion, Estado, UsuarioAuditoria, FechaAuditoria);
            MtdLimpiarCampos();
            mtdConsultaAnimal();
        }

        public void MtdLimpiarCampos()
        {
            lblCodigoAnimal.Text = "";
            txtTipoAnimal.Text = "";
            txtRaza.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
            cboxEstadoAnimal.SelectedIndex = -1;
        }

        private void frmAnimales_Load(object sender, EventArgs e)
        {
            lblCodigoAnimal.Text = "";
            lblFechaAnimal.Text = DateTime.Now.ToString();
            mtdConsultaAnimal();
            MtdMostrarListaCodigoGranja();
        }

        private void MtdMostrarListaCodigoGranja()
        {
            var lista = cd_Animales.MtdListaCodigoGranja();
            MessageBox.Show("Granjas encontradas: " + lista.Count);

            cboxCodigoGranja.DataSource = lista;
            cboxCodigoGranja.DisplayMember = "Text";
            cboxCodigoGranja.ValueMember = "Value";
            cboxCodigoGranja.SelectedIndex = -1;
        }



        public void mtdConsultaAnimal()
        {
            DataTable dtAnimales = cd_Animales.mtdConsultarTablaAnimales();
            dgvAnimales.DataSource = dtAnimales;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int CodigoAnimal = int.Parse(lblCodigoAnimal.Text);
            int CodigoGranja = int.Parse(cboxCodigoGranja.Text.Split('-')[0].Trim());
            string TipoAnimal = txtTipoAnimal.Text;
            string Raza = txtRaza.Text;
            DateTime FechaNacimiento = DateTime.Parse(dtpFechaNacimiento.Text);
            decimal Precio = decimal.Parse(txtPrecio.Text);
            string Descripcion = txtDescripcion.Text;
            string Estado = cboxEstadoAnimal.Text;
            string UsuarioAuditoria = "";
            DateTime FechaAuditoria = DateTime.Now;
            cd_Animales.MtdActualizarAnimal(CodigoAnimal, CodigoGranja, TipoAnimal, Raza, FechaNacimiento, Precio, Descripcion, Estado, UsuarioAuditoria, FechaAuditoria);
            MtdLimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lblCodigoAnimal.Text, out int codigoAnimal))
            {
                MessageBox.Show("Seleccione primero un animal válido para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cd_Animales.MtdEliminarAnimal(codigoAnimal);
            MtdLimpiarCampos();
            mtdConsultaAnimal();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblCodigoAnimal.Text = "";
            cboxCodigoGranja.SelectedIndex = -1;
            txtTipoAnimal.Text = "";
            txtRaza.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
            cboxEstadoAnimal.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAnimales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigoAnimal.Text = dgvAnimales.CurrentRow.Cells[0].Value.ToString();
            cboxCodigoGranja.Text = dgvAnimales.CurrentRow.Cells[1].Value.ToString();
            txtTipoAnimal.Text = dgvAnimales.CurrentRow.Cells[2].Value.ToString();
            txtRaza.Text = dgvAnimales.CurrentRow.Cells[3].Value.ToString();
            dtpFechaNacimiento.Text = dgvAnimales.CurrentRow.Cells[4].Value.ToString();
            txtPrecio.Text = dgvAnimales.CurrentRow.Cells[5].Value.ToString();
            txtDescripcion.Text = dgvAnimales.CurrentRow.Cells[6].Value.ToString();
            cboxEstadoAnimal.Text = dgvAnimales.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
