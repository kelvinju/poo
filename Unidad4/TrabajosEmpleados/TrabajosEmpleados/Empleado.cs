using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosEmpleados
{
    abstract public class Empleado
    {
        private string nombre, fechanc;
        private double sueldo, diasTrabajados;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Fechanc
        {
            get { return fechanc; }
            set { fechanc = value; }
        }
        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }

        }
        public double DiasTrabajados
        {
            get { return diasTrabajados; }
            set { diasTrabajados = value; }
        }
        public abstract void calcularSueldo();

    }
}
