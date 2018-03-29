namespace Decorator.ConcreteComponent
{
    using Component;

    public class FullSizeCar : Car
    {
        private const string FullSizeCarDescription = "FullSize Car";
        private const decimal FullSizeCarPrice = 30000.00m;

        public FullSizeCar()
        {
            this.Description = FullSizeCarDescription;
            this.Price = FullSizeCarPrice;
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