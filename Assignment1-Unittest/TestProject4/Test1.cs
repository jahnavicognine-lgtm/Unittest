namespace TestProject4
{
    [TestClass]
    public sealed class Test1
    {

        [TestMethod]
        public void FindMaxProduct_WhenStringIs123456_Returns360()
        {

            var result = Program.FindMaxProduct("123456");

            Assert.AreEqual(360, result.maxProduct);
            Assert.AreEqual("3*4*5*6", result.maxDigits);
        }


        [TestMethod]
        public void FindMaxProduct_WhenStringHasZeros_ReturnsZeroProduct()
        {

            var result = Program.FindMaxProduct("10506");

            Assert.AreEqual(0, result.maxProduct);
            Assert.AreEqual("1*0*5*0", result.maxDigits);
        }
    }
}
