using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samochod
{
    class Car
    {
        public double pojSilnika;
        public string marka;
        public static int ilKol;

        static Car()
        {
            ilKol = 4;
        }

        public Car(double pojSilnika, string marka)
        {
            this.pojSilnika = pojSilnika;
            this.marka = marka;
        }

        public static Car Create(double pojSilnika,string marka)
        {
            return new Car(pojSilnika,marka);
        }

        ~Car()
        {
            Console.WriteLine("Zwalniam pamięć");
            Console.ReadKey();

        }
    }
}
