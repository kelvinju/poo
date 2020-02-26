using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConciertodeMcDavo
{
    public class Concierto
    {
        public int bebes=0, niños=0, adultos=0, mayores=0, cantidad=0;
        public string asisten;
        public void contarEntradas()
        {
            switch (asisten)
            {
 
                case "bebes":
                    bebes = bebes += cantidad;
                    break;
                case "niños":
                    niños = niños += cantidad;
                    break;
                case "adultos":
                    adultos = adultos += cantidad;
                    break;
                case "tercera edad":
                    mayores = mayores += cantidad;
                    break;

            } 

            }
    }
}
