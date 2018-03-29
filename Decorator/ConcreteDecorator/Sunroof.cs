namespace Decorator.ConcreteDecorator
{
    using Component;
    using Decorator;

    public class Sunroof : CarDecorator
    {
        private const decimal SunroofPrice = 3000;

        public Sunroof(Car car) : base(car)
        {
            this.Description = "Sunroof";
            this.AccessoryPrice = SunroofPrice;
        }
    }
}