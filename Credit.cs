using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEjemploPattern
{
    public class Credit
    {
        public bool HasGoodCredit(Cliente c)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true;


        }

    }
}
        

