using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test
{
    public class OddOccurrencesInArray
    {
        public int Solution(int[] A)
        {

            int result = 0;
            foreach (var i in A)
                result ^= i;


            return result; 
        }
    }
}
