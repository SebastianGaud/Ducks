using Ducks;
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

        }

        [TestMethod]
        public void DuckSquackTest()
        {
            Assert.IsTrue(_rd.Quack() == "Sqauck");
        }
    }
}
