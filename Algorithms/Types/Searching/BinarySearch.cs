namespace Algorithms.Types.Searching
{
    public class BinarySearch
    {

        private readonly int[] _sortedArray;
        private readonly int _numberToBeFound;

        public BinarySearch(int[] sortedArray, int numberToBeFound)
        {
            _sortedArray = sortedArray;
            _numberToBeFound = numberToBeFound;
        }


        public bool Exists()
        {
            return LookForTheNumber();
         }


        private bool LookForTheNumber()
        {
                    
            // -> Create start point;
            var startPoint = 0;

            // -> Create end point (consideringn that array starts at 0);
            var endPoint = _sortedArray.Length -1 ;
            

            // 3 - Go to this part and start over again;
            while (startPoint <= endPoint) {
                    
                // Define the middlepart of array;
                int pointer = (endPoint - startPoint) / 2;

                //Verify if the value has been found
                if (_sortedArray[pointer] == _numberToBeFound)
                {
                    return true;                    
                }

                // Find the part what part does the value should be
                if (_numberToBeFound < _sortedArray[pointer])
                {
                    // Define range for searching
                    endPoint = pointer - 1;
                }

                if(_numberToBeFound > _sortedArray[pointer])
                {
                    // Define range for searching
                    startPoint = pointer + 1;
                    
                }
            }

            //value has not been found
            return false;
        }
    }
}
