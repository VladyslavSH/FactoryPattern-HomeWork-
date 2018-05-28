using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_28._05._18_.Products;

namespace HomeWork_28._05._18_.Factory
{
    public abstract class CarFactory
    {
        public abstract FamilyCar CreateFamilyCar();
        public abstract SportsCar CreateSortsCar();
    }
}
