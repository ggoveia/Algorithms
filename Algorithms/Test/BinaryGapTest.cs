using NUnit.Framework;

namespace Algorithms.Test
{
    [TestFixture]
    public class BinaryGapTest
    {

        BinaryGap sutBinaryGap = new BinaryGap();


        //Decimal 9
        private const long CASE1 = 1001;
        private const int CASE1_RESULT = 2;

        //Decimal 529
        private const long CASE2 = 1000010001;
        private const int CASE2_RESULT = 4;

        //Decimal 20
        private const long CASE3 = 10100;
        private const int CASE3_RESULT = 1;

        //Decimal 15
        private const long CASE4 = 1111;
        private const int CASE4_RESULT = 0;

        //Decimal 1041 
        private const long CASE5 = 10000010001;
        private const int CASE5_RESULT = 5;


        [TestCase(9, 1001, 2)]
        [TestCase(529, 1000010001, 4)]
        [TestCase(20, 10100, 1)]
        [TestCase(15, 1111, 0)]
        [TestCase(1041, 10000010001, 5)]
        [TestCase(1024, 10000010001, 0)]
        public void BinaryGap_canFindTheLongestGap(int decimalRep, long binary, int result)
        {

            var answer = sutBinaryGap.Solution2(decimalRep);

            Assert.AreEqual(result, answer);

        }
        
    }
}
