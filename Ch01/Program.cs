using Ch01.Duck;
using Ch01.Fly;

namespace Ch01
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck.Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}
