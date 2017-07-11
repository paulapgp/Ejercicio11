using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class CocinaService : ICocina
    {

        public void CalentarAlimentos(Alimento a1, Alimento a2)
        {
            a1.Calentado = true;
            a2.Calentado = true;
        }
    }
}
