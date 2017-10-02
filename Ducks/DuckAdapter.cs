using Ducks.Interfaces;

namespace Ducks
{
    public class DuckAdapter : Ducks, IFly, IQuackable
    {
        private Animal a;

        protected override string _name => a.Call();

        public DuckAdapter(Animal a)
        {
            this.a = a;
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
