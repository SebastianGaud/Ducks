using Ducks.Interfaces;

namespace Ducks
{
    public class RedHeadDuck : Ducks, IFly, IQuackable
    {
        public RedHeadDuck()
        {
            _name = "Redhead Duck";
        }

        public string Fly() => "Ho volato per: 50 metri";

        public string Quack() => "Quack";

        public override string Swim() => "Ho nuotato per 1 Km";
    }
}
