#region #fileheader
// Sebastiano Gaudeano
// Ducks Ducks Animal.cs
// 2017 10 01
// 2017 10 01
#endregion
namespace Ducks.Interfaces
{
    public interface IAnimal
    {
        string Call();

        int Fly();

        int Swim();
    }
}