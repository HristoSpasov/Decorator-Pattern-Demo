namespace Decorator.ConcreteDecorator
{
    using Component;
    using Decorator;

    public class LeatherSeats : CarDecorator
    {
        private const decimal LeatherSeatsPrice = 2000m;

        public LeatherSeats(Car car) : base(car)
        {
            this.Description = "Leather Seats";
            this.AccessoryPrice = LeatherSeatsPrice;
        }
    }
}