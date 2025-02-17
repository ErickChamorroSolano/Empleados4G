using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Empleados4G.Clases
{
    internal class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cedula { get; set;}
        public string Telefono { get; set; }
        public string TipoSangre { get; set; }
        public int Salario { get; set; }
        public string EPS { get; set; }
        public Int16 PorcentajeEPS { get; set; }
        public string ARL { get; set; }
        public Int16 PorcentajeARL { get; set; }
        public string Pensiones { get; set; }
        public Int16 PorcentajePensiones { get; set; }
        public int TotalSalario { get; set; }
    }
}
