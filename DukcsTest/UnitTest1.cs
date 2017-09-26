using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DucksTest
{
    [TestClass]
    public class TestAllDucks
    {
        [TestMethod]
        public void TestDecoyDuck()
        {
            var d = new Ducks.DecoyDuck();

            Assert.IsTrue(d.Display() == "Decoy Duck");
            Assert.IsTrue(d.Swim() == "Non so nuotare");
        }

        [TestMethod]
        public void TestMallardDuck()
        {
            var d = new Ducks.MallardDuck();

            Assert.IsTrue(d.Display() == "Mallard");
            Assert.IsTrue(d.Quack() == "Quack");
            Assert.IsTrue(d.Swim() == "Ho nuotato per 70 metri");
        }

        [TestMethod]
        public void TestRedheadDucks()
        {
            var d = new Ducks.RedHeadDuck();

            Assert.IsTrue(d.Display() == "Redhead Duck");
            Assert.IsTrue(d.Quack() == "Quack");
            Assert.IsTrue(d.Swim() == "Ho nuotato per 1 Km");
            Assert.IsTrue(d.Fly() == "Ho volato per: 50 metri");
        }


        [TestMethod]
        public void TestRubberDuck()
        {
            var d = new Ducks.RubberDuck();

            Assert.IsTrue(d.Display() == "Rubber Duck");
            Assert.IsTrue(d.Squack() == "Squack");
            Assert.IsTrue(d.Swim() == "Ho nuotato per 5 metri");
        }
    }
}
