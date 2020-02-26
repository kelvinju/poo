using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaYPerimetroDeUnCuadrado
{
    public class Cuadrado
    {
        public int lado, area, perimetro;
        public void PerimetroArea()
        {
            area = lado * lado;
            perimetro = 4 * lado;
        }
    }
}
