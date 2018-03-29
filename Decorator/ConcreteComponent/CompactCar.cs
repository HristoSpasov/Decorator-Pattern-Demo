namespace Decorator.ConcreteComponent
{
    using Component;

    public class CompactCar : Car
    {
        private const string CompactCarDescription = "Compact Car";
        private const decimal CompactCarPrice = 10000m;

        public CompactCar()
        {
            this.Description = CompactCarDescription;
            this.Price = CompactCarPrice;
        }

        public override decimal GetCarPrice()
        {
            return this.Price;
        }

        public override string GetDescription()
        {
            return this.Description;
        }
    }
}