using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.총정리
{
    interface IRunnable
    {
        public void Run();
    }

    interface IFlyable
    {
        public void Fly();
    }

    class FlyingCar : IRunnable, IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Car Run!");
        }

        public void Fly()
        {
            Console.WriteLine("Car Fly!");
        }
    }

    internal class _4_07
    {
        static void Main7(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runable = car as IRunnable;
            IFlyable flyable = car as IFlyable;

            runable.Run();
            flyable.Fly();
        }
    }
}
