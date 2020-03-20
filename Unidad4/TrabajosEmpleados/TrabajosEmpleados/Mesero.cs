using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosEmpleados
{
    class Mesero:Empleado
    {
        private float propinas;
        public float Propinas
        {
            get { return propinas; }
            set { propinas = value; }
        }
        public override void calcularSueldo()
        {
            Sueldo = DiasTrabajados * Sueldo + propinas;
        }
    }
}
