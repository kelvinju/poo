using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculo
{
    class ClassVehiculo
    {
          public string tipoDeCombustible, color;
          public int numeroDeLlantas, NumeroDePuertas, NumeroDeVentanas;
        //contructor de la clase es un metodo que se llama igual que la clase y se ejecuta aumtomaticamente al crear el objeto//
        public ClassVehiculo()
        {
            tipoDeCombustible = "";
            color = "blanco";
            numeroDeLlantas = 1;
            NumeroDePuertas = 0;
            NumeroDeVentanas = 0;
        }
        public string arrancarMotor(string sonido)
        {
            return "se arranco el motor" + sonido;
        }
        public string pararMotor(string sonido)
        {
            return "se detuvo el motor + sonido";
        }

    }
}
