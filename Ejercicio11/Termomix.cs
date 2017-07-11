using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Termomix
    {
        public IBascula bascula
        {
            get;
            set;
        }

        public ICocina cocina
        {
            get;
            set;
        }

        public Termomix(ICocina _cocina, IBascula _bascula)
        {
            this.bascula = _bascula;
            this.cocina = _cocina;
        }

        public Termomix()
        { }

        public Plato PreparaPlatos(Alimento alimento1, Alimento alimento2)
        {
            float peso1 = bascula.PesarAlimentos(alimento1);
            float peso2 = bascula.PesarAlimentos(alimento2);

            cocina.CalentarAlimentos(alimento1, alimento2);

            Plato p = new Plato();
            p.alimento1 = alimento1;
            p.alimento2 = alimento2;

            return p;
        }


    }
}
