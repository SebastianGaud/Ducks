namespace Ducks
{
    public abstract class Ducks
    {
        protected abstract string _name { get; }

        public string Display() => _name;

        public abstract int Swim();
    }
}
