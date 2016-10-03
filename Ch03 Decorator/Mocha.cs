namespace Ch03_Decorator
{
    class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }

        public override decimal Cost()
        {
            return 0.2M + _beverage.Cost();
        }
    }
}
