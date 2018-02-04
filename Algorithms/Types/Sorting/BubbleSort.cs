using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class BubbleSort
    {
        public int[] GetOrdered(int[] list)
        {
            var total = list.Count();
            var lastUnsortered = total;
            var isSorted = false;

            while (isSorted != true)
            {
                isSorted = true;

                for (int x = 0; x < lastUnsortered - 1; x++)
                {
                    var y = x + 1;
                    
                    if (list[x] > list[y])
                    {
                        isSorted = false;
                        swap(list, x, y);
                    }
                }
                lastUnsortered--;
            }

            return list;
        }

        private void swap(int[] array, int i, int j)
        {
            int temp = array[i];

            array[i] = array[j];

            array[j] = temp;
        }
    }
}