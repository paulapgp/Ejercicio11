using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class BasculaService : IBascula
    {
        public float PesarAlimentos(Alimento a)
        {
            float peso = 0;

            peso = a.Peso;

            return peso;
        }
    }
}
