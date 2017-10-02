using Ducks.Interfaces;

namespace Ducks
{
    public class RubberDuck : Ducks, IQuackable
    {
        protected override string _name => "Rubber Duck";

        public override int Swim() => 5;

        public string Quack()
        {
            return "Squack";
        }
    }
}
