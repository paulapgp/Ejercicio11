using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Alimento
    {
        public int Peso { get; set; }
        public bool Calentado { get; set; }

        public Alimento()
        {
            Peso = 0;
            Calentado = false;
        }

        public Alimento(int _Peso, bool _Calentado)
        {
            this.Peso = _Peso;
            this.Calentado = _Calentado;
        }
    }
}
