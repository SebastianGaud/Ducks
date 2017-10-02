using Ducks.Interfaces;

namespace Ducks
{
    public class RubberDuck : Ducks, IQuackable
    {
        public RubberDuck()
        {
            _name = "Rubber Duck";
        }
        public override int Swim() => 5;

        public string Quack()
        {
            return "Squack";
        }
    }
}
