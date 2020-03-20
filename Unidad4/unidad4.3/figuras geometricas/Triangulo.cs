using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras_geometricas
{
      class Triangulo:figura
    {
        private float area, perimetro, altura;
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
        public float Altura
        {
            get { return altura; }
            set { altura = value; }
        }


        public override void calcularPerimetro()
        {
            perimetro = Lado * 3;
           
        }

        public override void CalcularArea()
        {
            area = Lado * altura;
           
        }
    }
}
