using HomeWork_28._05._18_.Factory;
using HomeWork_28._05._18_.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_28._05._18_.Clients
{
    public class Driver
    {
        private SportsCar sportsCar;
        private FamilyCar familyCar;
        
        public Driver(CarFactory Car)
        {
            sportsCar = Car.CreateSortsCar();
            familyCar = Car.CreateFamilyCar();
        }

        public void Speed()
        {
            sportsCar.Speed();
            familyCar.Speed();
        }
    }
}
