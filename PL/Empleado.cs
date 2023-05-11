using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public float Sueldo_Diario { get; set; }
        public List<object> Empleados { get; set; }
        public float Calcula_Sueldo(float dias_trabajados)
        {
            return dias_trabajados * Sueldo_Diario;
        }
    }
}
