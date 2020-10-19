using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace cours2
{
    class Suv : Car, Interface1
    {
       public Suv (string _model, int _year) : base(_model, _year)
       {

       }
        public void Demarrer()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }

        public void Bruit()
        {
            Console.WriteLine("Pouette! Pouette!");
        }

        public void remorque()
        {
            Console.WriteLine("remorque");
        }
    }
}
