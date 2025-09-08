using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using New1;
    
namespace New1.Tests
{
    [TestClass]
    public sealed class Test1
    {
       
            [TestMethod]
            public void FindMaxProduct_WhenStringIs123456_Returns360()
            {
                var result = Program.FindMaxProduct("123456");

                Assert.AreEqual(360, result.maxProduct);
                
            }

            [TestMethod]
            public void FindMaxProduct_WhenStringHasZeros_ReturnsZero()
            {
                var result = Program.FindMaxProduct("10506");

                Assert.AreEqual(0, result.maxProduct);
             
            }
          [TestMethod]
            public void FindMaxProduct_WhenStringHasLongString()
              {
            var result = Program.FindMaxProduct("134738756");
           
            Assert.AreEqual(1176, result.maxProduct);
            


              }



    }
  
    
}
