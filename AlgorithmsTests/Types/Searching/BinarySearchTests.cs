using Algorithms.Types.Searching;
using NUnit.Framework;

namespace AlgorithmsTests.Types.Searching
{
    [TestFixture]
    public class BinarySearchTests
    {


        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        public void BinarySearch_CanFindAGivenNumberInASortedArray(int value)
        {

            var sortedArray = new[] {1,2,3,4,5,6,7,8,9,10};

            var result = new BinarySearch(sortedArray, value).Exists();

            Assert.AreEqual(true, result);

        }

        [TestCase(11)]
        public void BinarySearch_CanNOTFindAGivenNumberInASortedArray(int value)
        {

            var sortedArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = new BinarySearch(sortedArray, value).Exists();

            Assert.AreEqual(false, result);

        }
    }
}
