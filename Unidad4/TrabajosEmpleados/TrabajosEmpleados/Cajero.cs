using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosEmpleados
{
    class Cajero:Empleado
    {
       
        public string caja;
        public override void calcularSueldo()
        
        
        {
             switch(caja)
            {
                case "Dos":
                    Sueldo = Sueldo * DiasTrabajados * 0.3;
                    break;
            }
                
            
        }
    }
}
