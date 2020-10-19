using System;
using System.Collections.Generic;
using System.Text;

namespace cours2
{
    public class Car 
    {
        public string model;
        private int year;
        public int Year
        {
            get { return year; }
            set{ if (value <= 2020) { year = value; } }
        }

        
        public Car(string _model, int _year)
        {
            model = _model;
            Year = _year;
        }

        public virtual void Bruit()
        {
            Console.WriteLine("Vroom!!!");
        }
        
    }
}
