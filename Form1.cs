using Empleados4G.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empleados4G.DataAccess;

namespace Empleados4G
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmpleados frmEmpleados = new frmEmpleados("Admin");
                frmEmpleados.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //DataAccess.DataAccess DA = new DataAccess.DataAccess();
            //string usuario = txtUsuario.Text;
            //string password = txtPassword.Text;

            //try
            //{
            //    if (string.IsNullOrEmpty(usuario))
            //        throw new Exception("Debe ingresar un usuario.");

            //    if (string.IsNullOrEmpty(password))
            //        throw new Exception("Debe ingresar una contraseña.");

            //    if (DA.Login(usuario,password))
            //    {
            //        frmEmpleados frmEmpleados = new frmEmpleados(usuario);
            //        frmEmpleados.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        throw new Exception("Datos incorrectos o usuario no registrado.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DataAccess.DataAccess DA = new DataAccess.DataAccess();
            string usuario = txtUsuarioReg.Text.Trim();
            string password = txtPasswordReg.Text.Trim();
            string confirm = txtConfirmPassword.Text.Trim();
            string rol = cbRol.SelectedItem.ToString();

            try
            {
                if (string.IsNullOrEmpty(usuario))
                    throw new Exception("Debe ingresar un usuario.");

                if (string.IsNullOrEmpty(password))
                    throw new Exception("Debe ingresar una contraseña.");

                if (string.IsNullOrEmpty(confirm))
                    throw new Exception("Debe confirmar la contraseña.");

                if (password != confirm)
                    throw new Exception("Las contraseñas no coinciden.");

                if (rol.Contains("Seleccione"))
                    throw new Exception("Debe seleccionar un rol.");

                if (DA.SignUp(usuario, password, rol))
                {
                    DialogResult result = MessageBox.Show("Usuario registrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        txtUsuario.Text = usuario;
                        txtPassword.Text = password;
                        pnlRegistrar.Visible = false;
                        pnlLogin.Visible = true;
                    }
                }
                else
                {
                    throw new Exception("Datos incorrectos o usuario no registrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void lblRegistrar_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            cbRol.Items.Clear();
            cbRol.Items.Add("-- Seleccione --");
            cbRol.Items.Add("Administrador");
            cbRol.Items.Add("Empleado");
            cbRol.SelectedIndex = 0;
            pnlRegistrar.Visible = true;
        }

        private void lblIniciarSesion_Click(object sender, EventArgs e)
        {
            pnlRegistrar.Visible = false;
            pnlLogin.Visible = true;
        }
    }
}
