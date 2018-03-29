namespace Decorator.Decorator
{
    using Component;

    public abstract class CarDecorator : Car
    {
        private Car car;
        private decimal accessoryPrice;

        protected CarDecorator(Car car)
        {
            this.Car = car;
        }

        protected decimal AccessoryPrice
        {
            get
            {
                return this.accessoryPrice;
            }

            set
            {
                this.accessoryPrice = value;
            }
        }

        protected Car Car
        {
            get
            {
                return this.car;
            }

            set
            {
                this.car = value;
            }
        }

        public override decimal GetCarPrice()
        {
            return this.Car.GetCarPrice() + this.AccessoryPrice;
        }

        public override string GetDescription()
        {
            return $"{this.Car.GetDescription()}, {this.Description}";
        }
    }
}