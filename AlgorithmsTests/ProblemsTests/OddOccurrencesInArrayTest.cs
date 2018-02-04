using NUnit.Framework;

namespace Algorithms.Test
{
    [TestFixture]
    public class OddOccurrencesInArrayTest
    {

        OddOccurrencesInArray sutOddOcurrences = new OddOccurrencesInArray();
        

        [TestCase(new int[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
        [TestCase(new int[] { 2, 1, 2, 3, 1}, 3)]
        [TestCase(new int[] { 2, 1, 2, 1 }, 0)]
        public void OddOcurrencesInArray(int[] A, int result) {
            
            var answer = sutOddOcurrences.Solution(A);

            Assert.AreEqual(answer, result);
        }

    }
}
