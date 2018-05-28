using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_28._05._18_.Products
{
    public class AudiSport : SportsCar
    {
        public override void Speed()
        {
            Console.WriteLine($"Max speed {this.GetType().Name}: 400 km");
        }
    }
}
