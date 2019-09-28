using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller.net
{
   public class promedionotas
   {
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;
        
        public void setnota1(double prom)
        {
            this.nota1 = prom;
        }
        public double getnota1()
        {
            return this.nota1;
        }
        public void setnota2(double prom)
        {
            this.nota2 = prom;
        }
        public double getnota2()
        {
            return this.nota2;
        }
        public void setnota3(double prom)
        {
            this.nota3 = prom;
        }
        public double getnota3()
        {
            return this.nota3;
        }
        public void setnota4(double prom)
        {
            this.nota4 = prom;
        }
        public double getnota4()
        {
            return this.nota4;
        }


        
        public double resultado()
        {
            return ((this.getnota1() + this.getnota2() + this.getnota3() + this.getnota4()) / 4);
        }
    }
   
}
