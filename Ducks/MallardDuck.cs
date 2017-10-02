using Ducks.Interfaces;

namespace Ducks
{
    public class MallardDuck : Ducks, IFly, IQuackable
    {
        public MallardDuck()
        {
            _name = "Mallard";
        }

        public int Fly() => 20;

        public string Quack() => "Quack";

        public override int Swim() => 70;
    }
}
