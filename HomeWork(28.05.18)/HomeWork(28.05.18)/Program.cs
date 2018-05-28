using HomeWork_28._05._18_.Clients;
using HomeWork_28._05._18_.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_28._05._18_
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver(new AudiFactory());
            driver.Speed();
            Console.WriteLine("-------------");
            driver = new Driver(new MercedesFactory());
            driver.Speed();
        }
    }
}
