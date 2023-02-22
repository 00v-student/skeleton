using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsWatch Awatch = new clsWatch();
            Assert.isNotNull(Awatch);
        }
    }
}
