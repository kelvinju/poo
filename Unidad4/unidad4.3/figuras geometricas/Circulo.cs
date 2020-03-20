using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras_geometricas
{
     class Circulo:figura
    {
        private double area, perimetro;
        public double Area
        {
            get { return area; }
            set { area = value; }
        }
        public double Perimetro
        {
            get { return perimetro; }
            set { perimetro = value; }
        }
        public override void calcularPerimetro()
        {
            perimetro = 2*3.1416*Lado;
            
        }

        public override void CalcularArea()
        {
            area = Lado * 3.1416;
            
        }
    }
}
