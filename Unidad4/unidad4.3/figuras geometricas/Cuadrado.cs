using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras_geometricas
{
    class Cuadrado:figura
    {
        private float perimetro, area;
        public float Area
        {
            get { return area; }
            set { area = value; }
        }
        public float Perimetro
        {
            get { return perimetro; }
            set { perimetro = value; }
        }
        public override void calcularPerimetro()


        {
            perimetro = Lado +Lado+Lado+Lado;
           
        }

        public override void CalcularArea()
        {
            area = Lado * Lado;
            
        }
        
    }
}
