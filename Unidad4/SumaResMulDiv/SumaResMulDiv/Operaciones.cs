using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaResMulDiv
{
    public class Operaciones
    {

        private float valor1, valor2, resultados;
        public float Valor1
        {
            get { return valor1; }
            set { valor1 = value; }



        }
        public float Valor2
        {
            get { return valor2; }
            set { valor2 = value; }

        }
        public float Resultados
        {
            get { return resultados; }
            set { resultados = value; }
        }
        public void operacion()
        {
            valor1 = 0;
            valor2 = 0;
            resultados = 0;
        }
    }
    
}
