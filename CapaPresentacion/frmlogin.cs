using CapaSeguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CapaPresentacion
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        // Para mover la ventana desde el panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            catch { }
        }

        private void frmlogin_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            catch { }
        }

        // BOTÓN LOGIN
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtuser.Text) || txtuser.Text == "Username")
                {
                    msgError("Ingrese el usuario.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtpass.Text) || txtpass.Text == "Password")
                {
                    msgError("Ingrese la contraseña.");
                    return;
                }

                UserModel user = new UserModel();
                bool validLogin = user.LoginUser(txtuser.Text, txtpass.Text);

                if (validLogin)
                {
                    frmMenuPrincipal mainMenu = new frmMenuPrincipal();
                    mainMenu.Show();
                    mainMenu.FormClosed += Logout;
                    this.Hide();
                }
                else
                {
                    msgError("Usuario o contraseña incorrecta.");
                    txtpass.Text = "Password";
                    txtpass.UseSystemPasswordChar = false;
                    txtuser.Focus();
                }
            }
            catch (Exception ex)
            {
                msgError("Error inesperado en el login.");
                Console.WriteLine(ex.Message);
            }
        }

        // PLACEHOLDER DE PASSWORD
        private void txtpass_Enter(object sender, EventArgs e)
        {
            try
            {
                if (txtpass.Text == "Password")
                {
                    txtpass.Text = "";
                    txtpass.ForeColor = Color.LightGray;
                    txtpass.UseSystemPasswordChar = true;
                }
            }
            catch { }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtpass.Text == "")
                {
                    txtpass.Text = "Password";
                    txtpass.ForeColor = Color.Silver;
                    txtpass.UseSystemPasswordChar = false;
                }
            }
            catch { }
        }

        // PLACEHOLDER DE USUARIO
        private void txtuser_Enter(object sender, EventArgs e)
        {
            try
            {
                if (txtuser.Text == "Username")
                {
                    txtuser.Text = "";
                    txtuser.ForeColor = Color.LightGray;
                }
            }
            catch { }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtuser.Text == "")
                {
                    txtuser.Text = "Username";
                    txtuser.ForeColor = Color.Silver;
                }
            }
            catch { }
        }

        // MOSTRAR MENSAJE DE ERROR
        private void msgError(string msg)
        {
            try
            {
                lblErrorMessage.Text = "    " + msg;
                lblErrorMessage.Visible = true;
            }
            catch { }
        }

        // LOGOUT: vuelve al login cuando se cierra el menú principal
        private void Logout(object sender, FormClosedEventArgs e)
        {
            try
            {
                txtpass.Text = "Password";
                txtpass.UseSystemPasswordChar = false;
                txtuser.Text = "Username";
                lblErrorMessage.Visible = false;
                this.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // MINIMIZAR
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch { }
        }
        

        // CERRAR APLICACIÓN
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                msgError("No se pudo cerrar correctamente.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
