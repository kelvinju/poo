using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayorDeEdad1
{
    public class Persona
    {
        public int dia = 0, mes = 0, años = 0;
        public int añoActual = 0, diaActual = 0, mesActual=0;
        public string mayorDeEdad;
        public void grande()
        {
            if (añoActual - años > 18)
                mayorDeEdad = "es mayor de edad";
            else mayorDeEdad = "es menor de edad";
             if (añoActual - años == 18)
                if (mesActual > mes)
                    mayorDeEdad = "es mayor de edad";
                else if (mesActual == mes)
                    if (diaActual > dia)
                        mayorDeEdad = "es mayor de edad";
                    else if (diaActual == dia)
                        mayorDeEdad = "es mayor de edad";
        }
    }
}
