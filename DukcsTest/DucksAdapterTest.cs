using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ducks;
using Ducks = Ducks.Ducks;

namespace DukcsTest
{
    [TestClass]
    public class DucksAdapterTest
    {
        [TestMethod]
        public void DuckAdapterIsDuck()
        {
            var d = new DuckAdapter(new AnAnimal("Ghepard"));

            Assert.IsTrue(d is global::Ducks.Ducks);
        }

        [TestMethod]
        public void DuckAdapterReturnProperlyQuack()
        {
            var d = new DuckAdapter(new AnAnimal("Ghepard"));

            Assert.IsTrue(d.Display() == "Ghepard");
        }
    }
}
