using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Pesar : IPesar
    {
        public int PesarAlimentos(Alimento a1, Alimento a2)
        {
            int peso = 0;

            peso = a1.peso + a2.peso;

            return peso;
        }
    }
}
