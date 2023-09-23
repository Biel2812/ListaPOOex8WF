using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ007
{
    internal class Valorxy
    {
        //atributos
        private double x;
        private double y;
        private double valores;




        //metodos 
        public void setXnumero(double p)
        {
            x = p;
        }

        public void setYnumero(double p)
        {
            y = p;
        }


        public double getXnumero()
        {
            return x;
        }

        public double getYnumero()
        {
            return y;
        }

        public double getValores()
        {
            return valores;
        }

        public void calcularValores()
        {
            if (x >= y)
            {
                Console.WriteLine("O maior  número é: " + x);
            }
            else
            {
                Console.WriteLine("O maior  número é: " + y);

            }

        }
    }
}

