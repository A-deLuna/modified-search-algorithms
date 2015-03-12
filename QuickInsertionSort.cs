using System;
namespace modifiedSearch{
    public class QuickInsertionSort{
        private static int smallSize = 25;

        private static Results results;
        public static Results sort(int [] array){
            results = new Results();
            quickInsertionSort(array, 0, array.Length-1);

            return results;

        }
        private static void quickInsertionSort(int [] element, int first, int last){
            int pivot;
            results.comparisons++;
            if(last-first > smallSize){
                if (first < last)
                {
                    pivot = element[first];
                    int splitPoint = partition(element, pivot, first, last);
                    results.swaps++;
                    element[splitPoint] = pivot;
                
                    quickInsertionSort(element, first, splitPoint - 1);
                    quickInsertionSort(element, splitPoint + 1, last);
                }
            }
            else{
                Results rs = InsertionSort.sort(element, first, last);
                results.comparisons += rs.comparisons;
                results.swaps += rs.swaps;
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

    }
}
