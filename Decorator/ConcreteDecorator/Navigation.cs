namespace Decorator.ConcreteDecorator
{
    using Component;
    using Decorator;

    public class Navigation : CarDecorator
    {
        private const decimal NavigationPrice = 5000m;

        public Navigation(Car car) : base(car)
        {
            this.Description = "Navigation";
            this.AccessoryPrice = NavigationPrice;
        }
    }
}