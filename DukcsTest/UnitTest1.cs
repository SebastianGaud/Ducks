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

            Assert.IsTrue(condition: d.Swim() == 0);


        }

        [TestMethod]
        public void TestMallardDuck()
        {
            var d = new Ducks.MallardDuck();

            Assert.IsTrue(d.Display() == "Mallard");
            Assert.IsTrue(d.Quack() == "Quack");

            Assert.IsTrue(condition: d.Swim() == 70);
            Assert.IsTrue(condition: d.Fly() == 20);
        }

        [TestMethod]
        public void TestRedheadDucks()
        {
            var d = new Ducks.RedHeadDuck();

            Assert.IsTrue(d.Display() == "Redhead Duck");
            Assert.IsTrue(d.Quack() == "Quack");

            Assert.IsTrue(condition: d.Swim() == 1000);
            Assert.IsTrue(condition: d.Fly() == 50);
        }
    }
}
