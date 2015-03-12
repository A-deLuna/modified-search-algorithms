using System;
using System.Collections.Generic;
using System.Text;


namespace modifiedSearch
{
    class QuickSort
    {
        private static Results results;
        public static Results sort(int[] element, int last)
        {
            results = new Results();
            quickSort(element, 0, last - 1);
            return results;
        }

        private static void quickSort(int[] element, int first, int last)
        {
            int pivot;
            results.comparisons++;
            if (first < last)
            {
                pivot = element[first];
                int splitPoint = partition(element, pivot, first, last);
                results.swaps++;
                element[splitPoint] = pivot;
            
                quickSort(element, first, splitPoint - 1);
                quickSort(element, splitPoint + 1, last);
            }
            

        }

        private static int partition(int[] element, int pivot, int first, int last)
        {
            int low, high;

            low = first;
            high = last;
            while (low < high)
            {
                int highVac = extendLargeRegion(element, pivot, low, high);
                int lowVac = extendSmallRegion(element, pivot, low + 1, highVac);
                low = lowVac;
                high = highVac - 1;
            }
            return low;
        }

        private static int extendLargeRegion(int[] element, int pivot, int lowVac, int high)
        {
            int moves = 0;
            int comps = 0;
            int highVac, curr;
            highVac = lowVac;  // en caso de que no key < pivot
            curr = high;

            while (curr > lowVac)
            {
                results.comparisons++;
                if (element[curr] < pivot)
                {
                    results.swaps++;
                    element[lowVac] = element[curr];
                    highVac = curr;
                    break;
                }
                curr--;  // sigue buscando
            }
            return highVac;
        }

        private static int extendSmallRegion(int[] element, int pivot, int low, int highVac)
        {
            int moves = 0;
            int comps = 0;
            int lowVac, curr;

            lowVac = highVac;  // en caso de que  no key >= pivot
            curr = low;
            while (curr < highVac)
            {
                results.comparisons++;
                if (element[curr] >= pivot)
                {
                    results.swaps++;
                    element[highVac] = element[curr];
                    moves++;
                    lowVac = curr;
                    break;
                }
                curr++;  // sigue buscando
            }
            return lowVac;
        }

        // TERMINA METODO QUICKSORT
    }
}
