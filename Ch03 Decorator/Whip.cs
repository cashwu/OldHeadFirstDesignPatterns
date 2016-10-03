namespace Ch03_Decorator
{
    class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }

        public override decimal Cost()
        {
            return 0.1M + _beverage.Cost();
        }
    }
}
