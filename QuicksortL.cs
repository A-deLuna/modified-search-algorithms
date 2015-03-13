using System;
using System.Collections.Generic;
using System.Text;


namespace modifiedSearch
{
    class QuickSortL
    {
        private static Results results;
        public static Results sort(int[] element)
        {
            results = new Results();
            quickSortL(element, 0, element.Length-1);
            return results;
        }

        private static void quickSortL(int[] element, int first, int last)
        {
            int pivot;
            //results.comparisons++;
            if (first < last)
            {
                pivot = element[first];
                int splitPoint = partitionL(element, pivot, first, last);
                //results.swaps++;
                element[splitPoint] = pivot;
            
                quickSortL(element, first, splitPoint - 1);
                quickSortL(element, splitPoint + 1, last);
            }
            

        }

        private static int partitionL(int[] element, int pivot, int first, int last)
        {
            int vacant, unknown;
            vacant = first;
            for(unknown = first + 1; unknown <= last; unknown++)
            {
                if(element[unknown] < pivot)
                {
                    element[vacant] = element[unknown];
                    element[unknown] = element[vacant + 1];
                    vacant++;
                }
            }
            return vacant;
        }

    }
}
