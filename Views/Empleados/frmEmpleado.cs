using Empleados4G.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empleados4G.DataAccess;

namespace Empleados4G.Views.Empleados
{
    public partial class frmEmpleado : Form
    {
        private int IdUsuario;

        public int _IdUsuario
        {
            get { return IdUsuario; }
            set { IdUsuario = value; }
        }

        Utilidades util = new Utilidades();
        DataAccess.DataAccess DA = new DataAccess.DataAccess();

        public frmEmpleado(int ID)
        {
            this.IdUsuario = ID;
            InitializeComponent();

        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                cbTipoSangre.Items.Clear();
                cbTipoSangre.Items.Add("Seleccione");
                cbTipoSangre.Items.Add("O+");
                cbTipoSangre.Items.Add("O-");
                cbTipoSangre.Items.Add("A+");
                cbTipoSangre.Items.Add("A-");
                cbTipoSangre.Items.Add("AB+");
                cbTipoSangre.Items.Add("AB-");

                cbEPS.Items.Clear();
                cbEPS.Items.Add("Seleccione");
                cbEPS.Items.Add("SURA");
                cbEPS.Items.Add("Nueva EPS");
                cbEPS.Items.Add("Coomeva");
                cbEPS.Items.Add("Mutual Ser");
                cbEPS.Items.Add("Salud Total");

                cbARL.Items.Clear();
                cbARL.Items.Add("Seleccione");
                cbARL.Items.Add("AXA");
                cbARL.Items.Add("SURA");
                cbARL.Items.Add("Porvenir");
                cbARL.Items.Add("Proteccion");

                cbPensiones.Items.Clear();
                cbPensiones.Items.Add("Seleccione");
                cbPensiones.Items.Add("Porvenir");
                cbPensiones.Items.Add("ColPensiones");
                cbPensiones.Items.Add("OmbiaPensiones");
                cbPensiones.Items.Add("4G Pensiones");

                if (IdUsuario == -1)
                {
                    btnAceptar.Text = "Agregar";
                    cbTipoSangre.SelectedIndex = 0;
                    cbEPS.SelectedIndex = 0;
                    cbARL.SelectedIndex = 0;
                    cbPensiones.SelectedIndex = 0;
                }
                else
                {
                    btnAceptar.Text = "Editar";
                }

                if (IdUsuario != -1)
                {
                    Empleado iEmpleado = new Empleado();
                    iEmpleado = DA.RecuperarEmpleadoPorID(IdUsuario);

                    txtNombre.Text = iEmpleado.Nombre;
                    txtCedula.Text = iEmpleado.Cedula.ToString();
                    txtTelefono.Text = iEmpleado.Telefono;
                    cbTipoSangre.SelectedText = iEmpleado.TipoSangre;
                    txtSalarioCompleto.Text = iEmpleado.Salario.ToString();
                    cbEPS.SelectedText = iEmpleado.EPS;
                    txtPorcentajeEPS.Text = iEmpleado.PorcentajeEPS.ToString();
                    txtPorcentajeEPS.ReadOnly = iEmpleado.PorcentajeEPS == 0;
                    cbARL.SelectedText = iEmpleado.ARL;
                    txtPorcentajeARL.Text = iEmpleado.PorcentajeARL.ToString();
                    txtPorcentajeARL.ReadOnly = iEmpleado.PorcentajeARL == 0;
                    cbPensiones.SelectedText = iEmpleado.Pensiones;
                    txtPorcentajePensiones.Text = iEmpleado.PorcentajePensiones.ToString();
                    txtPorcentajePensiones.ReadOnly = iEmpleado.PorcentajePensiones == 0;
                    txtTotalSalario.Text = iEmpleado.TotalSalario.ToString();
                }
            }
            catch (Exception ex)
            {
                util.notificacion(ex);
            }
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string cedula = txtCedula.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string tipoSangre = cbTipoSangre.Text.Trim();
            string salario = txtSalarioCompleto.Text.Trim();
            string EPS = cbEPS.Text.Trim();
            string prcEPS = txtPorcentajeEPS.Text;
            string ARL = cbARL.Text.Trim();
            string prcARL = txtPorcentajeARL.Text;
            string pensiones = cbPensiones.Text.Trim();
            string prcPensiones = txtPorcentajePensiones.Text;
            string totalSalario = txtTotalSalario.Text.Replace(",","").Replace(".","");

            try
            {
                if (string.IsNullOrEmpty(nombre))
                    throw new Exception("Debe ingresar un nombre.");
                if (string.IsNullOrEmpty(cedula))
                    throw new Exception("Debe ingresar una cédula.");
                if (tipoSangre.Contains("Seleccione"))
                    throw new Exception("Debe seleccionar un tipo de sangre.");
                if (string.IsNullOrEmpty(salario) || salario == "0")
                    throw new Exception("Debe ingresar un salario.");

                Empleado oEmpleado = new Empleado();

                oEmpleado.Id = IdUsuario;
                oEmpleado.Nombre = nombre;
                oEmpleado.Cedula = Convert.ToInt32(cedula);
                oEmpleado.Telefono = telefono;
                oEmpleado.TipoSangre = tipoSangre;
                oEmpleado.Salario = Convert.ToInt32(salario);
                oEmpleado.EPS = EPS;
                oEmpleado.PorcentajeEPS = Convert.ToInt16(prcEPS);
                oEmpleado.ARL = ARL;
                oEmpleado.PorcentajeARL = Convert.ToInt16(prcARL);
                oEmpleado.Pensiones = pensiones;
                oEmpleado.PorcentajePensiones = Convert.ToInt16(prcPensiones);
                oEmpleado.TotalSalario = Convert.ToInt32(totalSalario);

                if (oEmpleado.Id == -1)
                {
                    DA.InsertarEmpleado(oEmpleado);
                    DialogResult result = MessageBox.Show("Empleado agregado correctamente.","Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                        this.Close();
                }
                else
                {
                    DA.ActualizarEmpleado(oEmpleado);
                    DialogResult result = MessageBox.Show("Empleado actualizado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                        this.Close();
                }
            }
            catch (Exception ex)
            {
                util.notificacion(ex);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbEPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbEPS.Text.Contains("Seleccione"))
                {
                    txtPorcentajeEPS.Text = "0";
                    txtDevengadoEPS.Text = "0";

                    txtPorcentajeEPS.ReadOnly = true;
                }
                else
                {
                    txtPorcentajeEPS.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                util.notificacion(ex);
            }
        }

        private void cbARL_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbARL.Text.Contains("Seleccione"))
                {
                    txtPorcentajeARL.Text = "0";
                    txtDevengadoARL.Text = "0";

                    txtPorcentajeARL.ReadOnly = true;
                }
                else
                {
                    txtPorcentajeARL.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                util.notificacion(ex);
            }
        }

        private void cbPensiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPensiones.Text.Contains("Seleccione"))
                {
                    txtPorcentajePensiones.Text = "0";
                    txtDevengadoPensiones.Text = "0";

                    txtPorcentajePensiones.ReadOnly = true;
                }
                else
                {
                    txtPorcentajePensiones.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                util.notificacion(ex);
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Int32 salario = string.IsNullOrEmpty(txtSalarioCompleto.Text) ? 0 : Convert.ToInt32(txtSalarioCompleto.Text);

                Int32 porcentajeEPS = string.IsNullOrEmpty(txtPorcentajeEPS.Text) ? 0 : Convert.ToInt32(txtPorcentajeEPS.Text);
                Int32 porcentajeARL = string.IsNullOrEmpty(txtPorcentajeARL.Text) ? 0 : Convert.ToInt32(txtPorcentajeARL.Text);
                Int32 porcentajePensiones = string.IsNullOrEmpty(txtPorcentajePensiones.Text) ? 0 : Convert.ToInt32(txtPorcentajePensiones.Text);

                double devengadoEPS = porcentajeEPS == 0 ? 0 : salario * ((double)porcentajeEPS / (double)100);
                double devengadoARL = porcentajeARL == 0 ? 0 : salario * ((double)porcentajeARL / (double)100);
                double devengadoPensiones = porcentajePensiones == 0 ? 0 : salario * ((double)porcentajePensiones / (double)100);

                double total = salario - (devengadoEPS + devengadoARL + devengadoPensiones);

                txtDevengadoEPS.Text = devengadoEPS.ToString("N0");
                txtDevengadoARL.Text = devengadoARL.ToString("N0");
                txtDevengadoPensiones.Text = devengadoPensiones.ToString("N0");
                txtTotalSalario.Text = total.ToString("N0");
            }
            catch (Exception ex)
            {
                util.notificacion(ex);
            }
        }
    }
}
