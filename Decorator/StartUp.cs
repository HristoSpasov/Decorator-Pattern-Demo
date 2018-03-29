namespace Decorator
{
    using System;
    using Component;
    using ConcreteComponent;
    using ConcreteDecorator;

    internal class StartUp
    {
        public static void Main(string[] args)
        {
            Car theCar = new CompactCar();
            theCar = new Navigation(theCar);
            theCar = new Sunroof(theCar);
            theCar = new LeatherSeats(theCar);

            Console.WriteLine(theCar.GetDescription());
            Console.WriteLine($"{theCar.GetCarPrice():C2}");
        }
    }
}