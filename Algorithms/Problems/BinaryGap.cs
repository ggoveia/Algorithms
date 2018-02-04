using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BinaryGap
    {

        public int Solution(int N)
        {

            var binaryValue = Convert.ToString(N, 2).ToCharArray();

            var startWith1 = false;
            var endsWith1 = false;
            var final = 0;
            var count = 0;
            var max = 0;
            var occurance = 0;

            for (int i = 0; i < binaryValue.Length - 1; i++)
            {
                if (!(binaryValue[i] == '1' && binaryValue[i + 1] == '0') && startWith1 == false)
                {
                    continue;
                }

                startWith1 = true;

                if ((binaryValue[i] == '0' && binaryValue[i + 1] == '1') && startWith1 == true)
                {
                    endsWith1 = true;
                    occurance++;
                    startWith1 = false;

                    if (max > final)
                    {
                        final = max;
                    }

                    count = 0;
                    continue;

                }

                count++;

                if (count > max)
                {
                    max = count;
                }

            }

            if (occurance == 0)
                return 0;

            return final;
        }

        public int Solution2(int N)
        {

            var max = 0;
            var current = 0;
            var pointer = 0;


            var binaryValue = Convert.ToString(N, 2).ToCharArray();

            while (pointer < binaryValue.Length -1)
            {
                if (binaryValue[pointer] == '1' && current != 0)
                {
                    current = 0;
                    
                }

                if (binaryValue[pointer] == '0' && current >= 0)
                {
                    current++;
                }

                if (binaryValue[pointer + 1] == '1' && current >= 0)
                {
                    if (current > max)
                        max = current;
                }

                pointer++;
            }
            
            return max;
        }
    }
}
