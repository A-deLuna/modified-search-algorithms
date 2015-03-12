using System;
using System.Collections.Generic;
using System.Text;
using Estadisticos;


namespace Ordenamiento
{
    class QuickSort
    {
        public void sort(int[] element, int last)
        {
            quickSort(element, 0, last - 1);
        }

        private static void quickSort(int[] element, int first, int last)
        {
            int pivot;

            if (first < last)
            {
                pivot = element[first];
                int splitPoint = partition(element, pivot, first, last);
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
                if (element[curr] < pivot)
                {
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
                if (element[curr] >= pivot)
                {
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
