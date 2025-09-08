using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Question1; // use your main project namespace

namespace Test1
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestPositiveNumbers()
        {
            var result = Program.AddAndConvert(2.0f, 3.0f);
            Assert.AreEqual(5.0f, result.result, 0.0001f);
        }

       

        [TestMethod]
        public void TestWithZero()
        {
            var result = Program.AddAndConvert(7.0f, 0.0f);
            Assert.AreEqual(7.0f, result.result, 0.0001f);
        }

        [TestMethod]
        public void TestBinaryStringsNotEmpty()
        {
            var result = Program.AddAndConvert(1.5f, 2.5f);
            Assert.IsFalse(string.IsNullOrEmpty(result.binOne));
            Assert.IsFalse(string.IsNullOrEmpty(result.binTwo));
            Assert.IsFalse(string.IsNullOrEmpty(result.binSum));
        }
    }
}

