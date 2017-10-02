using Ducks.Interfaces;

namespace Ducks
{
    public class RedHeadDuck : Ducks, IFly, IQuackable
    {
        public RedHeadDuck()
        {
            _name = "Redhead Duck";
        }

        public int Fly() => 50;

        public string Quack() => "Quack";

        public override int Swim() => 1000;
    }
}
