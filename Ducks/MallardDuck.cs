using Ducks.Interfaces;

namespace Ducks
{
    public class MallardDuck : Ducks, IFly, IQuackable
    {
        public MallardDuck()
        {
            _name = "Mallard";
        }

        public string Fly() => "Ho volato per 20 metri";

        public string Quack() => "Quack";

        public override string Swim() => "Ho nuotato per 70 metri";
    }
}
