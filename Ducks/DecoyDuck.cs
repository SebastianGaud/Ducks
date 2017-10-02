namespace Ducks
{
    public class DecoyDuck : Ducks
    {
        protected override string _name => "Decoy Duck";

        public override int Swim() => 0;
    }
}
