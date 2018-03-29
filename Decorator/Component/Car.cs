namespace Decorator.Component
{
    public abstract class Car
    {
        private string description;
        private decimal price;

        protected Car()
        {
        }

        protected string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.description = value;
            }
        }

        protected decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.price = value;
            }
        }

        public abstract string GetDescription();

        public abstract decimal GetCarPrice();
    }
}