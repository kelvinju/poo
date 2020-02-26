using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servicioDeLuz
{
    public class recibo
    {
        public double kw, presio;
        public string vivienda;
        public void kwConsumidos()
        {
            switch (vivienda)
            {
                case "Negocio":
                    presio = kw * 5;
                    break;

                case "Hogar":
                    if (kw >= 0 && kw <= 250)
                        presio = kw * 0.65;
                    else if (kw >= 251 && kw <= 500)
                        presio = kw * 0.85;
                    if (kw >= 501 && kw <= 1200)
                        presio = kw * 1.5;
                    else if (kw >= 1201 && kw <= 2100)
                        presio = kw * 2.5;
                    if (kw >= 2101)
                        presio = kw * 3;
                    break;

                    
            }
        }
    }
}
