using Ducks;
using Ducks.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DukcsTest
{
    [TestClass]
    public class DecoyDuckTest
    {
        private DecoyDuck dd;

        public DecoyDuckTest()
        {
            dd = new DecoyDuck();
        }

        [TestMethod]
        public void CanNotFly()
        {
            Assert.IsFalse(dd is IFly, "La papera sa volare e non doveva");
        }

        public void CanNotQuack()
        {
            Assert.IsFalse(dd is IQuackable, "La papera sa quackare e non doveva");
        }
    }
}
