using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradosCentigrados
{
    public class grados
    {
        public double f, c, cantidad;
        public string comvertir;
        public void convertirGrados()
        {
            switch(comvertir)
            {
                case"Centigrados":
                    cantidad = cantidad * 1.8000 + 32.00 ;
                    
                    break;
                case "Fahrenheit":
                    cantidad = (cantidad - 32.00) * 5 / 9;
                    break;
            }
        }
    }
}
