using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Termomix
    {
        public IPesar pesar
        {
            get;
            set;
        }

        public ICalentar calentar
        {
            get;
            set;
        }

        public Plato PreparaPlatos(Alimento alimento1, Alimento alimento2)
        {
            Plato p = new Plato();

            int pesoTotal = pesar.PesarAlimentos(alimento1, alimento2);
            calentar.CalentarAlimentos(alimento1, alimento2);

            p.alimento1 = alimento1;
            p.alimento2 = alimento2;

            return p;
        }


    }
}
