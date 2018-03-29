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
        }

        public override decimal GetCarPrice()
        {
            return CompactCarPrice;
        }

        public override string GetDescription()
        {
            return this.Description;
        }
    }
}