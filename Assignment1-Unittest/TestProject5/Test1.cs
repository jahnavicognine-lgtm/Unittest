
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Question_2;  // 👈 This allows access to Program

namespace TestProject5
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Substring_Found_MultipleTimes()
        {
            int result = Program.FindSubstringOccurrences("abcdabcabd", "ab");
            Assert.AreEqual(3, result); // "ab" occurs 3 times
        }

        [TestMethod]
        public void Substring_NotFound()
        {
            int result = Program.FindSubstringOccurrences("hello", "xyz");
            Assert.AreEqual(0, result); // no match
        }

        [TestMethod]
        public void Substring_EqualsMainString()
        {
            int result = Program.FindSubstringOccurrences("test", "test");
            Assert.AreEqual(1, result); // one full match
        }

        [TestMethod]
        public void Substring_SingleCharacter()
        {
            int result = Program.FindSubstringOccurrences("banana", "a");
            Assert.AreEqual(3, result); // "a" at positions 1, 3, 5
        }
    }
}
