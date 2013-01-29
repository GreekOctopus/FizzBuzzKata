using FizzBuzzApp;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        readonly FizzBuzz _target = new FizzBuzz();

        [Test]
        public void FizzBuzz_GetOutput_Method_Returns_Fizz_When_Number_Is_Divisible_By_Only_3()
        {
            Assert.That(_target.GetOutput(3), Is.StringMatching("Fizz"));
            Assert.That(_target.GetOutput(6), Is.StringMatching("Fizz"));
            Assert.That(_target.GetOutput(9), Is.StringMatching("Fizz"));
        }

        [Test]
        public void FizzBuzz_GetOutput_Method_Returns_Buzz_When_Number_Is_Divisible_By_Only_5()
        {
            Assert.That(_target.GetOutput(5), Is.StringMatching("Buzz"));
            Assert.That(_target.GetOutput(10), Is.StringMatching("Buzz"));
            Assert.That(_target.GetOutput(20), Is.StringMatching("Buzz"));
        }

        [Test]
        public void FizzBuzz_GetOutput_Method_Returns_FizzBuzz_When_Number_Is_Divisible_By_Only_15()
        {
            Assert.That(_target.GetOutput(15), Is.StringMatching("FizzBuzz"));
            Assert.That(_target.GetOutput(30), Is.StringMatching("FizzBuzz"));
            Assert.That(_target.GetOutput(45), Is.StringMatching("FizzBuzz"));
        }

        [Test]
        public void FizzBuzz_GetOutput_Method_Returns_Number_When_Number_Is_Not_Divisible_By_3_Or_5()
        {
            Assert.That(_target.GetOutput(7), Is.StringMatching("7"));
            Assert.That(_target.GetOutput(17), Is.StringMatching("17"));
            Assert.That(_target.GetOutput(1), Is.StringMatching("1"));
        }
    }
}
