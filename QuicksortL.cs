using System;
using System.Collections.Generic;
using System.Text;


namespace modifiedSearch
{
    class QuickSortL
    {
        /*private static Results results;
        public static Results sort(int[] element, int last)
        {
            results = new Results();
            quickSort(element, 0, last - 1);
            return results;
        }*/

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

        public static void Main(string[] args)
        {   int n = 5;
            int[] array = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("dasdf");
                array[i] = int.Parse(Console.ReadLine());
            }
            quickSortL(array,0,n-1);
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
        /*
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
        }*/
        // TERMINA METODO QUICKSORT
    }
}
