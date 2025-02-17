using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Empleados4G.Clases;
using System.Data;

namespace Empleados4G.DataAccess
{
    internal class DataAccess
    {
        Utilidades util = new Utilidades();
        private static string connectionString = ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString;

        public bool SignUp(string usuario, string password, string rol)
        {
            try
            {
                string hashedPassword = util.Encriptar(password);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("InsertarUsuario", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Rol", rol);

                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            catch
            {
                throw;
            }
        }

        public bool Login(string usuario, string password)
        {
            try
            {
                string hashedPassword = util.Encriptar(password);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Contrasenia FROM Usuario WHERE Usuario = @usuario";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuario", usuario);

                    string storedHash = (string)command.ExecuteScalar();
                    connection.Close();

                    // Compara el hash generado con el hash almacenado
                    return hashedPassword == storedHash;
                }
            }
            catch
            {
                throw;
            }
        }

        public void InsertarEmpleado(Empleado empleado)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("InsertarEmpleado", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    
                    command.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    command.Parameters.AddWithValue("@Cedula", empleado.Cedula);
                    command.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                    command.Parameters.AddWithValue("@TipoSangre", empleado.TipoSangre);
                    command.Parameters.AddWithValue("@Salario", empleado.Salario);
                    command.Parameters.AddWithValue("@EPS", empleado.EPS);
                    command.Parameters.AddWithValue("@PrcEPS", empleado.PorcentajeEPS);
                    command.Parameters.AddWithValue("@ARL", empleado.ARL);
                    command.Parameters.AddWithValue("@PrcARL", empleado.PorcentajeARL);
                    command.Parameters.AddWithValue("@Pensiones", empleado.Pensiones);
                    command.Parameters.AddWithValue("@PrcPensiones", empleado.PorcentajePensiones);
                    command.Parameters.AddWithValue("@TotalSalario", empleado.TotalSalario);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch
            {
                throw;
            }
        }

        public void ActualizarEmpleado(Empleado empleado)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ActualizarEmpleado", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", empleado.Id);
                    command.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    command.Parameters.AddWithValue("@Cedula", empleado.Cedula);
                    command.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                    command.Parameters.AddWithValue("@TipoSangre", empleado.TipoSangre);
                    command.Parameters.AddWithValue("@Salario", empleado.Salario);
                    command.Parameters.AddWithValue("@EPS", empleado.EPS);
                    command.Parameters.AddWithValue("@PrcEPS", empleado.PorcentajeEPS);
                    command.Parameters.AddWithValue("@ARL", empleado.ARL);
                    command.Parameters.AddWithValue("@PrcARL", empleado.PorcentajeARL);
                    command.Parameters.AddWithValue("@Pensiones", empleado.Pensiones);
                    command.Parameters.AddWithValue("@PrcPensiones", empleado.PorcentajePensiones);
                    command.Parameters.AddWithValue("@TotalSalario", empleado.TotalSalario);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch
            {
                throw;
            }
        }

        public void EliminarEmpleado(int Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("EliminarEmpleado", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", Id);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch
            {
                throw;
            }
        }

        public DataSet RecuperarEmpleados()
        {
            DataSet DS = new DataSet();
            SqlDataAdapter Adapter = new SqlDataAdapter();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("RecuperarEmpleados", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    Adapter.SelectCommand = command;
                    Adapter.Fill(DS);
                    connection.Close();
                    return DS;
                }
            }
            catch
            {
                throw;
            }
        }

        public Empleado RecuperarEmpleadoPorID(int id)
        {
            Empleado result = new Empleado();
            DataSet DS = new DataSet();
            SqlDataAdapter Adapter = new SqlDataAdapter();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("RecuperarEmpleadoPorID", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);
                    Adapter.SelectCommand = command;
                    Adapter.Fill(DS);
                    connection.Close();

                    DataTable dt = new DataTable();
                    dt = DS.Tables[0];

                    foreach (DataRow item in dt.Rows)
                    {
                        result.Id = Convert.ToInt32(item["Id"]);
                        result.Nombre = item["Nombre"].ToString();
                        result.Cedula = Convert.ToInt32(item["Cedula"].ToString());
                        result.Telefono = item["Telefono"].ToString();
                        result.TipoSangre = item["TipoSangre"].ToString();
                        result.Salario = Convert.ToInt32(item["Salario"].ToString());
                        result.EPS = item["EPS"].ToString();
                        result.PorcentajeEPS = Convert.ToInt16(item["PorcentajeEPS"].ToString());
                        result.ARL = item["ARL"].ToString();
                        result.PorcentajeARL = Convert.ToInt16(item["PorcentajeARL"].ToString());
                        result.Pensiones = item["Pensiones"].ToString();
                        result.PorcentajePensiones = Convert.ToInt16(item["PorcentajePensiones"].ToString());
                        result.TotalSalario = Convert.ToInt32(item["TotalSalario"].ToString());
                    }
                }
                return result;
            }
            catch
            {
                throw;
            }
        }
    }
}
