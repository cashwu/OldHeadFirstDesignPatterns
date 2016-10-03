namespace Ch03_Decorator
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override decimal Cost()
        {
            return 1.99M;
        }
    }
}
