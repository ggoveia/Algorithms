
using NUnit.Framework;

namespace Algorithms
{
    [TestFixture]
    public class TestSorting
    {

        private int[] SortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        private int[] UnsortedArray = { 8, 3, 9, 2, 5, 10, 1, 7, 6, 4 };


        [Test]
        public void BubbleSort_canSort()
        {
            var resultArray = new BubbleSort().GetOrdered(UnsortedArray);

            Assert.AreEqual(resultArray, SortedArray);

        }

        [Test]
        public void QuickSort_canSort() {
             var resultArray = new QuickSort().GetOrdered(UnsortedArray);

            Assert.AreEqual(resultArray, SortedArray);

        }



    }



}
