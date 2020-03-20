using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras_geometricas
{
    abstract class figura
    {
         private float lado;
        
        public float Lado
        {
            get { return lado; }
            set { lado = value; }
        }
        
       

        public abstract void calcularPerimetro();
        public abstract void CalcularArea();


    }
    

}
