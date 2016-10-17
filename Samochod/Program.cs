using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samochod
{
    class Program
    {
        static void Main(string[] args)
        {
            Car zbyszek = Car.Create(2.0, "zbychu");
            Console.WriteLine(zbyszek.marka);
            Console.WriteLine(zbyszek.pojSilnika);
        }
    }
}
