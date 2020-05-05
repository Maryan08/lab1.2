using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int d = 654;
            int result = ConsoleApp2.Program.Example(d);
            Assert.AreEqual(456, result);
        }
    }
}
