namespace Ch03_Decorator
{
    abstract class Beverage
    {
        protected string Description = "Unknow Beverage";

        public virtual string GetDescription()
        {
            return Description;
        }

        public virtual decimal Cost()
        {
            return 0;
        }
    }
}
