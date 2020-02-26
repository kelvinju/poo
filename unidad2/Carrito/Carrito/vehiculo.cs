using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrito
{
    public class vehiculo
    {
        public int cantidad;
        public string tipo;
        public void TipoDeVehiculo()
        {
            switch(tipo)
            {
                case "Motocicleta":
                    cantidad = 100;
                    break;
                case "Automovil":
                    cantidad = 200;
                    break;
                case "Autobus":
                    cantidad = 300;
                    break;
                case "Trailer":
                    cantidad = 400;
                    break;


            }
        }
    }
}
