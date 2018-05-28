using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_28._05._18_.Products
{
    public class MercedesFamily : FamilyCar
    {
        public override void Speed()
        {
            Console.WriteLine($"Max speed {this.GetType().Name}: 100 km");
        }
    }
}
