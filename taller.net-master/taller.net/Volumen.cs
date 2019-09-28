using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller.net
{
    class Volumen
    {
        private Double numeroalto;
        private Double numerolargo;
        private Double numeroancho;

        public void setnumeroalto(double alto)
        {
            this.numeroalto = alto;
        }
        public double getnumeroalto()
        {
            return this.numeroalto;
        }
        public void setnumerolargo(double largo)
        {
            this.numerolargo = largo;
        }
        public double getnumerolargo()
        {
            return this.numerolargo;
        }
        public void setnumeroancho(double ancho)
        {
            this.numeroancho = ancho;
        }
        public double getnumeroancho()
        {
            return this.numeroancho;
        }
        public double calcular()
        {
            return (this.getnumerolargo() * this.getnumeroancho() * this.getnumeroalto());
        }

    }
}
