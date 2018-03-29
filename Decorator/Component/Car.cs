namespace Decorator.Component
{
    public abstract class Car
    {
        private string description;

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

        public abstract string GetDescription();

        public abstract decimal GetCarPrice();
    }
}