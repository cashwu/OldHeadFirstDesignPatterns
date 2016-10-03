namespace Ch03_Decorator
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override decimal Cost()
        {
            return 0.89M;
        }
    }
}
