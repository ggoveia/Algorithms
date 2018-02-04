using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test
{
    public class LargestRightCircleShift
    {


        public int solution(int N) {


            var maxShift = Convert.ToString(N, 2).Length;
            var max = 0;
            var count = 0;

            for (int i = 1; i < maxShift; i++) {

                var m = (N >> i) | (N << (maxShift - i));

                if (m > max) {

                    max = m;
                    count++;

                }

            }

            return count;
        }
    }
}
