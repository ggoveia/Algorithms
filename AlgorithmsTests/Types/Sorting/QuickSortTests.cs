using Algorithms;
using NUnit.Framework;

namespace AlgorithmsTests.Types.Searching
{
    [TestFixture]
    public class QuickSortTests
    {

        [TestCase(new string []{  "31415926535897932384626433832795", "1", "3", "10", "3", "5" },
            new string[] { "1", "3", "3", "5", "10", "31415926535897932384626433832795" })]
        public void QuickSort_CanFindThePivot(string[] arr, string[] result) {

            QuickSort Sorting = new QuickSort(arr);
            var solution = Sorting.Solve();

            Assert.AreEqual(result, solution);
        }
    }
}
