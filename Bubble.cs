using System;
using System.Collections.Generic;
using System.Text;

namespace modifiedSearch
{
    class Bubble
    {
        private static Results results;

        public static Results sort(int[] element, int n)
        {
            results = new Results();
            bubble(element,n);
            return results;
        }

        public void bubble(int[] array, int n)
        {
            int numPairs;
            bool didSwitch;
            int i;
            int temp;
            numPairs = n - 1;
            didSwitch = true;
            while(didSwitch)
            {
                didSwitch = false;
                for(i = 0; i < numPairs; i++)
                {
                    results.comparisons++;
                    if(array[i] > array[i + 1])
                    {
                        results.swaps++;
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        didSwitch = true;
                    }
                }
                numPairs--;
            }
        }//bubble
    }//class
}//namespace

