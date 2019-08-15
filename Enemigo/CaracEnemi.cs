using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemigo
{
    class CaracEnemi
    {
        public int posicionx { get; set; }
        public int posiciony { get; set; }

        private int _puntos;
        public int Puntos
        {
            get
            {
                return _puntos;
            }
            set
            {
                if(value >= 100)
                {
                    _puntos = value;
                }
                else
                {
                    throw new Exception("no gano puntos");
                }
            }
        }
        public void moverse() { }
        public void disparar() { }
        public void explotar() { }





    }
}
