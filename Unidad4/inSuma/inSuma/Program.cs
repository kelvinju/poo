using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inSuma
{
    //las interfaces definen las propiedades metodos y eventos que pueded 
    //ISeriable permite que un objeto  controle sus proías serializacion y deserializacion
    interface ISerieable
    {
        bool Guardar();
    }
    //declaramos una clase 
    public class Control
    {
        protected int num1, num2;
        public int suma;
        //declaramos un metodo gent y set
        public int Num1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        }
        public int Num2
        {
            get { return this.num2; }
            set { this.num2 = value; }
        }
        public int Suma
        {
            get { return this.suma; }
            set { this.suma = value; }
        }
    }
    //declaramos otra clase y heredamos todo lo que este en la clase control
    class miControl : Control,ISerieable
    {
      //metodo contructor
      public miControl()
        {
            
            
            Console.WriteLine("pon un nemero");
            num1 = Console.Read();
            Console.WriteLine("pon un nemero");
            num2 = Console.Read();
            Console.WriteLine("la suma es ");
            Console.WriteLine(suma);
            Console.ReadLine();
            Console.ReadLine();
            suma = num1 + num2;
        }
        //mandamos a llamar a anuestro metodo que declaramos en la interface

        public bool Guardar()
        {
            
            
                
           
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("la suma de los dos numeros");
            Console.WriteLine("----------------");
            //declaramos un objeto de la clase control
            miControl obj = new miControl();
            //declaron un objeto  del obj de la clase contrlo
            ISerieable ser = (ISerieable)obj;
            ser.Guardar();
           
        }
    }
}
