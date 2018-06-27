using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PooVueling
{
    public class Calculadora : ICalculadora, ICloneable
    {

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public int multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Suma(int num1, int num2)
        {
            return num1 + num2;
        }
    } 

}
