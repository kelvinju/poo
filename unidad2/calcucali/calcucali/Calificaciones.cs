using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcucali
{
    public class Calificaciones
    {
        public int califCapturada = 0;
        public double promedioGrupal = 0;
        public int sumaCalif = 0;
        public int reprobados = 0, aprobados = 0;
        public void centerAprobacion()
        {
            if (califCapturada < 70)
                reprobados++;
            else
                aprobados++;
        }
        public void sumarCalificacione()
        {
            sumaCalif += califCapturada;




            
            promedioGrupal += sumaCalif / califCapturada;

        }

    }

}
