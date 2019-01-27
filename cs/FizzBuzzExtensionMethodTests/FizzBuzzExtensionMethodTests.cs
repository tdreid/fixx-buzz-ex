using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzExtensionMethodTests
{
    [TestClass]
    public class TheFizzBuzzExtensionMethod
    {
        private const string fizz = "Fizz";
        private const string buzz = "Buzz";
        private const string fizzBuzz = "FizzBuzz";
        
        [TestMethod]
        public void ReturnsFizzGivenAMultipleOfThreeIndivisibleByFive()
        {
            Assert.AreEqual(fizz, 3.FizzBuzz());
            Assert.AreEqual(fizz, 6.FizzBuzz());
            Assert.AreEqual(fizz, 12.FizzBuzz());
            Assert.AreEqual(fizz, 24.FizzBuzz());
            Assert.AreEqual(fizz, 48.FizzBuzz());
            Assert.AreEqual(fizz, 96.FizzBuzz());
        }
        [TestMethod]
        public void ReturnsBuzzGivenAMultipleOfFiveIndivisibleByThree()
        {
            Assert.AreEqual(buzz, 5.FizzBuzz());
            Assert.AreEqual(buzz, 10.FizzBuzz());
            Assert.AreEqual(buzz, 20.FizzBuzz());
            Assert.AreEqual(buzz, 40.FizzBuzz());
            Assert.AreEqual(buzz, 80.FizzBuzz());
        }
        [TestMethod]
        public void ReturnsFizzBuzzGivenAMultipleOfBothThreeAndFive()
        {
            Assert.AreEqual(fizzBuzz, 15.FizzBuzz());
            Assert.AreEqual(fizzBuzz, 30.FizzBuzz());
            Assert.AreEqual(fizzBuzz, 60.FizzBuzz());
        }
        [TestMethod]
        public void ReturnsNGivenNDivisibleByNeitherThreeNorFive()
        {
            Assert.AreEqual("1", 1.FizzBuzz());
            Assert.AreEqual("2", 2.FizzBuzz());
            Assert.AreEqual("4", 4.FizzBuzz());
            Assert.AreEqual("8", 8.FizzBuzz());
            Assert.AreEqual("16", 16.FizzBuzz());
            Assert.AreEqual("32", 32.FizzBuzz());
            Assert.AreEqual("64", 64.FizzBuzz());
        }
    }
}
