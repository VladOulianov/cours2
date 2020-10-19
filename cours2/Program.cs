using System;

namespace cours2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Car Volvo = new Car("xc90", 2000);

             Console.WriteLine(Volvo.Year);
             Volvo.Year = 2030;
             Console.WriteLine(Volvo.Year);
             Volvo.Year = 2019;
             Console.WriteLine(Volvo.Year);


             Console.WriteLine(Volvo.model);
             Volvo.model = "ac50";
             Console.WriteLine(Volvo.model);*/


            /*Suv kangoo = new Suv("Peugeot", 2000);
            Console.WriteLine(kangoo.model);
            kangoo.Bruit();*/

            Car peugeot = new Suv("coucou", 2018);
            peugeot.Bruit();
        }
    }
}
