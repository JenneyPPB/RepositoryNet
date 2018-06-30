using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEjemploPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Mortgage mortgage = new Mortgage();

            Cliente cliente = new Cliente("Ann McKinsey");
            // Evaluate mortgage eligibility for customer

          
            bool eligible = mortgage.IsEligible(cliente, 125000);

            Console.WriteLine("\n" + cliente.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));

            // Wait for user

            Console.ReadKey();
        }
    } 
}
