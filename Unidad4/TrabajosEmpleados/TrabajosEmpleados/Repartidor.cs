using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosEmpleados
{
    class Repartidor:Empleado
    {
        public  double  zona, totalab;
        public override void calcularSueldo()
        {
            if (zona == 1)
                Sueldo = Sueldo * DiasTrabajados + totalab;
            else if (zona==2)
                Sueldo = Sueldo * DiasTrabajados +  + 2;
        }
    }
}
