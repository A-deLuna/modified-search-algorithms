using System;
using System.Collections.Generic;
using System.Text;

namespace modifiedSearch
{
    class BubbleM
    {
        private static Results results;

        public static Results sort(int[] element, int n)
        {
            results = new Results();
            bubbleM(element,n);
            return results;
        }

        static public void bubbleM(int[] array, int n)
        {
            int numPairs;
            bool didSwitch;
            int i;
            int temp;
            int j;
            numPairs = n - 1;
            j = numPairs;
            didSwitch = true;
            while(didSwitch) 
            {
                numPairs = j;
                didSwitch = false;
                for(i = 0; i < numPairs; i++)
                {
                    results.comparisons++;
                    if(array[i] > array[i + 1])
                    {
                        j = i + 1;
                        results.swaps++;
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        didSwitch = true;
                    }
                }
            }
        }//improved bubblesort
    }//class
}//namespace       

