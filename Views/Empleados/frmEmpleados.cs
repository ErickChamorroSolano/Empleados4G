using Empleados4G.Clases;
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
using Empleados4G.Views.Empleados;

namespace Empleados4G.Views
{
    public partial class frmEmpleados : Form
    {
        private string Bienvenido;

        public string _Bienvenido
        {
            get { return Bienvenido; }
            set { Bienvenido = value; }
        }

        DataAccess.DataAccess oHelper;
        Utilidades util = new Utilidades();

        public frmEmpleados(string usuario)
        {
            Bienvenido = usuario;
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 login = new Form1();
                login.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString() ?? ex.Message);
            }
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido: " + Bienvenido.ToUpper();
            oHelper = new DataAccess.DataAccess();
            gvEmpleados.DataSource = oHelper.RecuperarEmpleados().Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEmpleado empleado = new frmEmpleado(-1);
            empleado.ShowDialog();
            frmEmpleados_Load(sender, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvEmpleados.SelectedRows.Count > 0)
                {
                    int idEmpleado = Convert.ToInt32(gvEmpleados.SelectedRows[0].Cells[0].Value);
                    frmEmpleado frmEmpleado = new frmEmpleado(idEmpleado);
                    frmEmpleado.ShowDialog();
                    frmEmpleados_Load(sender,e);
                }
                else
                {
                    throw new Exception("Debe seleccionar un registro a editar.");
                }
            }
            catch (Exception ex)
            {
                util.notificacion(ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvEmpleados.SelectedRows.Count > 0)
                {
                    int idEmpleado = Convert.ToInt32(gvEmpleados.SelectedRows[0].Cells[0].Value);
                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        //eliminar
                        oHelper = new DataAccess.DataAccess();
                        oHelper.EliminarEmpleado(idEmpleado);

                        //recargar
                        frmEmpleados_Load(sender, e);
                    }
                }
                else
                {
                    throw new Exception("Debe seleccionar un registro a eliminar.");
                }
            }
            catch (Exception ex)
            {
                util.notificacion(ex);
            }
        }
    }
}
