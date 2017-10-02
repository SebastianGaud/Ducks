using Ducks.Interfaces;

namespace DukcsTest
{
    public class AnAnimal : IAnimal
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
        int IAnimal.Fly()
        {
            return 50;
        }

        int IAnimal.Swim()
        {
            return 100;
        }
    }
}
