using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        
        public override string Swim()
        {
            return a.Swim();
        }

        public string Fly()
        {
            return a.Fly();
        }

        public string Quack()
        {
            return a.Call();
        }
    }
}
