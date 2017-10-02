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
        int Animal.Fly()
        {
            return 50;
        }

        int Animal.Swim()
        {
            return 100;
        }
    }
}
