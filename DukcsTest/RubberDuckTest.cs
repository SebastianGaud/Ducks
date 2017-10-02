using Ducks;
using Ducks.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DukcsTest
{
    [TestClass]
    public class RubberDuckTest
    {
        private RubberDuck _rd;

        public RubberDuckTest()
        {
            _rd = new RubberDuck();
        }


        [TestMethod]
        public void DuckCanNotFly()
        {
            Assert.IsFalse(_rd is IFly, "La rubber duck sa volare");
        }

        [TestMethod]
        public void DuckSquackTest()
        {
            const string rightQuack = "Squack";
            string quackToTest = _rd.Quack();
            bool areEquals = rightQuack == quackToTest;

            Assert.IsTrue(areEquals, "La papera non fa" + rightQuack);
        }
    }
}
