using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacaciones
{
    public class empleado
    {
        public int años;
        public void trabajador()
        {
            if (años >=1 && años<=5)
                años = 5;
            else if (años>=6 && años<=10)
                    años = 10;
            if (años >= 10 && años <= 20)
                años = años * 1;
            else if (años >= 20 && años <= 45)
                años = años - 20 *1 + años;
            if (años >= 45)
                años = 45;
            

        }
    }
}
