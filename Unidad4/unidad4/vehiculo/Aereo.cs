using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculo
{
    class Aereo:ClassVehiculo
    {
        public int numeroDeTubinas, numeroDeAlas, numeroDeElices;
        public string tipoAereo;
        public Aereo()
        {
            numeroDeAlas = 0;
            numeroDeTubinas = 0;
            numeroDeElices = 0;
            tipoAereo = "";
        }
        public string enVuelo(string estado )
        {
            return "el "+tipoAereo+"esta volando "+estado;
        }
    }
}
