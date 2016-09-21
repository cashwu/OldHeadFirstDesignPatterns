namespace Ch01
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}
