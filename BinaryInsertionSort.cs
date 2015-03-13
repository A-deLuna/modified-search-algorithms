using System;
using System.Collections.Generic;
using System.Text;

namespace modifiedSearch
{
    class BinaryInsertionSort
    {
        private static Results results; 
        public static Results sort(int[] element, int dimension)
        {
            results = new Results();
            insertionsort(element,dimension-1);
            return results;
         
        }
        // ORDENA POR INSERCION
        private static void insertionsort(int[] element, int n)
        {
            int xindex, xLoc;
            int current;

            for (xindex = 1; xindex <= n; xindex++)
            {
                current = element[xindex];
                xLoc = shiftVac(element, xindex, current );
                element[xLoc] = current;
            }
        }
        private static int findPositionWithBinarySearch(int [] array,int first, int last,  int key ){
            int mid ;
            while(first <= last){
                mid = (first + last) / 2;
                results.comparisons++;
                if(key > array[mid]){
                    first = mid + 1;
                } else {
                    results.comparisons++;
                    if( key < array[mid]){
                        last = mid -1;
                    }else{
                        return mid;
                    }
                }
            }
            return first;
        }


        // HACE EL DESPLAZAMIENTO 

        private static int shiftVac(int[] array, int currentIndex, int current)
        {
            int position = findPositionWithBinarySearch(array,0,currentIndex-1,current); 
            for(int i = currentIndex; i > position; i--){
                results.swaps++;
                array[i] = array[i-1];
            }
            return position;
        }




    }
}
