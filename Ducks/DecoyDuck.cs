namespace Ducks
{
    public class DecoyDuck : Ducks
    {
        public DecoyDuck()
        {
            _name = "Decoy Duck";
        }

        public override int Swim() => 0;
    }
}
