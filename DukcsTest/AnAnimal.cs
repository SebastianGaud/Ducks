using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks.Interfaces;

namespace DukcsTest
{
    public class AnAnimal : Animal
    {
        private string _animalName;

        public AnAnimal(string animalName)
        {
            _animalName = animalName;
        }

        public string Call()
        {
            return _animalName;
        }

        public string Fly()
        {
            return "I can't Fly";
        }

        public string Swim()
        {
            return "I can Swim for 2 Miles";
        }
    }
}
