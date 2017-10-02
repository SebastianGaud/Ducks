using Ducks.Interfaces;

namespace Ducks
{
    public class DuckAdapter : Ducks, IFly, IQuackable
    {
        private Animal a;

        public DuckAdapter(Animal a)
        {
            this.a = a;
            _name = a.Call();
        }

        public override int Swim()
        {
            return a.Swim();
        }

        public int Fly()
        {
            return a.Fly();
        }

        public string Quack()
        {
            return a.Call();
        }
    }
}
