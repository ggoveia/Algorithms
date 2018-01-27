namespace Algorithms
{
    public class QuickSort
    {

        public int[] GetOrdered(int[] array)
        {

            GetOrdered(array, 0, array.Length - 1);

            return array;
        }


        private void GetOrdered(int[] array, int left, int right)
        {

            if (left >= right)
            {
                return;
            }

            var pivot = array[left + right / 2];
            var index = partition(array, left, right);

            GetOrdered(array, left, index - 1);
            GetOrdered(array, index + 1, right);


        }

        private int partition(int[] array, int left, int right)
        {

            var done = false;
            var pivot = left + right / 2;

            while (!done) {

                if (array[left] > pivot) {

                }

            }

            return 1;

        }


        private void swap(int[] array, int i, int j)
        {
            int temp = array[i];

            array[i] = array[j];

            array[j] = temp;
        }
    }
}
