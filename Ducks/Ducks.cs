namespace Ducks
{
    public abstract class Ducks
    {
        protected string _name;

        public Ducks()
        {
            _name = "Duck";
        }

        public string Display() => _name;

        public abstract int Swim();
    }
}
