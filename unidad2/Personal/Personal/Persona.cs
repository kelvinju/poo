using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal
{
    class Persona
    {
        //atributos
        private string nombre, apPaterno, apMaterno, tipo, estadoDeNacimiento;
        public int fecha, telefono;
        public int contadorEstado=0;
        public int contadorAlumnos = 0, contadorMaestros = 0, contadorAdministrativo;
        public int contadorMayor = 0;
        //Metodos
        public void registroPersona(string nombreM,string apPaternoM, string apMaternoM, int telefonoM,int fechaM,string tipoM, string estadoDeNacimientoM)
       
        {
            nombre = nombreM;
            apMaterno = apMaternoM;
            apPaterno = apPaternoM;
            tipo = tipoM;
            estadoDeNacimiento = estadoDeNacimientoM;
            fecha = fechaM;
            telefono = telefonoM;

        }
        public void contarNayarit()
        {
            if (estadoDeNacimiento == "Nayarit")
            {
                contadorEstado++;
            }
        }


        public void contarTipo()
        {
            
            switch(tipo)
            {
                case "Alumno":
                 {
                        contadorAlumnos++;
                        break;
                 }
                case "Maestro":
                    {
                        contadorMaestros++;
                        break;
                    }
                    
                        case "Administrador":
                    {
                        contadorAdministrativo++;
                        break;
                    }
                    default:
                    break;
                    }
                    
                
            }

        public void mayorEdad(int año, int mes, int dias, int añoActual, int mesActual, int diaActual)
        {
            if (añoActual - año > 18)
                contadorMayor++;
            else if (añoActual - año == 18)
            {
                if (mesActual < mes)
                    contadorMayor++;

            }

                        
        }


     
    }
            
        

    
}
