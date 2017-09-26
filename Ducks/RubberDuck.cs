namespace Ducks
{
    public class RubberDuck : Ducks
    {
        public RubberDuck()
        {
            _name = "Rubber Duck";
        }
        public override string Swim() => "Ho nuotato per 5 metri";

        public string Squack() => "Squack";
    }
}
