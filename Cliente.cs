using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEjemploPattern
{
    public class Cliente
    {


        
        private string _name;
        public Cliente()
        {

        }
        public Cliente(string name) {

            this._name = name;

        }
        public string Name { get; set; }




    }
}
