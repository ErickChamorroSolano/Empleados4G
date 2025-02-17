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
using OfficeOpenXml;
using System.IO;

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
            try
            {
                lblBienvenido.Text = "Bienvenido: " + Bienvenido.ToUpper();
                oHelper = new DataAccess.DataAccess();
                gvEmpleados.DataSource = oHelper.RecuperarEmpleados().Tables[0];
            }
            catch (Exception ex)
            {
                util.notificacion(ex);
                btnLogout_Click(sender,e);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmpleado empleado = new frmEmpleado(-1);
                empleado.ShowDialog();
                frmEmpleados_Load(sender, e);
            }
            catch (Exception ex)
            {
                util.notificacion(ex);
            }
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvEmpleados.Rows.Count > 0)
                {
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Empleados");

                        for (int i = 1; i <= gvEmpleados.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i].Value = gvEmpleados.Columns[i - 1].HeaderText;
                        }

                        for (int i = 0; i < gvEmpleados.Rows.Count; i++)
                        {
                            for (int j = 0; j < gvEmpleados.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = gvEmpleados.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        SaveFileDialog saveFileDialog = new SaveFileDialog
                        {
                            Filter = "Excel files (*.xlsx)|*.xlsx",
                            FileName = "Empleados.xlsx"
                        };

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                            excelPackage.SaveAs(fileInfo);
                            MessageBox.Show("Datos exportados correctamente a " + fileInfo.FullName);
                        }
                    }
                }
                else
                {
                    throw new Exception("No hay datos para exportar.");
                }
            }
            catch (Exception ex)
            {
                util.notificacion(ex);
            }
        }
    }
}
