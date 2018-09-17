using NUnit.Framework;
using CodeWars.Core;

namespace CodeWars.Tests
{
    [TestFixture]
    public class WeightSortTest
    {
        [Test]
        public void orderWeightTest()
        {
            string inpurString = "56 65 74 100 99 68 86 180 90";
            var result = WeightSort.orderWeight(inpurString);
            Assert.That(result, Is.EqualTo("100 180 90 56 65 74 68 86 99"));
        }
    }
}
