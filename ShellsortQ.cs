using System;
using System.Collections.Generic;
using System.Text;


namespace modifiedSearch
{
	class ShellSortQ
	{
		private static Results results;

		public static Results sort(int[] element)
		{
			results = new Results();
			shellsortQ(element,element.Length,element.Length/2);
			return results;
		}

		private static void shellsortQ(int[] array, int n, int ht)
		{
			int start, last;
			int h = ht;

			while(h > 0)
			{
				for(start = 0; start < h; start++)
				{
					last = start + (((n -1) / h) * h);
					results.comparisons++;
					if(last > n - 1)
						last -= h;
					quickSortL(array,start,last);
				}
				h = (h - 1) / 3;
			}
		}//shellsort

		private static void quickSortL(int[] element, int first, int last)
        {
            int pivot;
            results.comparisons++;
            if (first < last)
            {
                pivot = element[first];
                int splitPoint = partitionL(element, pivot, first, last);
                results.swaps++;
                element[splitPoint] = pivot;
            
                quickSortL(element, first, splitPoint - 1);
                quickSortL(element, splitPoint + 1, last);
            }
            

        }//quicksort

        private static int partitionL(int[] element, int pivot, int first, int last)
        {
            int vacant, unknown;
            vacant = first;
            for(unknown = first + 1; unknown <= last; unknown++)
            {
            	results.comparisons++;
                if(element[unknown] < pivot)
                {
                	results.swaps++;
                    element[vacant] = element[unknown];
                    element[unknown] = element[vacant + 1];
                    vacant++;
                }
            }
            return vacant;
        }//partition

	}//class
}//namespace
