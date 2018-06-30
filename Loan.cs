using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEjemploPattern
{
   public class Loan
    {
        public bool HasNoBadLoans(Cliente c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true;

        }

    }
}
