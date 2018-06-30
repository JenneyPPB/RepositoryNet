using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEjemploPattern
{
    public class Bank
    {
        public Bank() {


        }

        public bool  HasSufficientSavings(Cliente c,int amount) {
            Console.WriteLine("Chequear Banco"+ c.Name);
            return true;
        }

    }
}
