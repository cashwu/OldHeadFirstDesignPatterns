namespace Ch03_Decorator
{
    class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Soy";
        }

        public override decimal Cost()
        {
            return 0.15M + _beverage.Cost();
        }
    }
}
