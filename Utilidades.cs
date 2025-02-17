using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados4G
{
    internal class Utilidades
    {
        public string Encriptar(string texto)
        {
            string result = string.Empty;

            try
            {
                byte[] Encriptado = System.Text.Encoding.UTF8.GetBytes(texto);
                result = Convert.ToBase64String(Encriptado);
                return result;
            }
            catch
            {
                throw;
            }
        }

        public DialogResult notificacion(Exception ex)
        {
            string mensaje = ex.Message;

            if (ex.InnerException != null)
                mensaje = ex.InnerException.Message;

            return MessageBox.Show(mensaje,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        //public static class TipoDeSangre
        //{
        //    public static String O_Positivo { get { return "O+"; } }
        //    public static String O_Negativo { get { return "O-"; } }
        //    public static String A_Positivo { get { return "A+"; } }
        //    public static String A_Negativo { get { return "A-"; } }
        //    public static String AB_Positivo { get { return "AB+"; } }
        //    public static String AB_Negativo { get { return "AB-"; } }
        //}
    }
}
