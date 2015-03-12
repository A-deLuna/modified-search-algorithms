using System;
using System.Collections.Generic;
using System.Text;

namespace modifiedSearch
{
    class InsertionSort
    {
        private static Results results; 
        public static Results sort(int[] element,int first, int dimension)
        {
            results = new Results();
            insertionsort(element,first ,dimension);
            return results;
         
        }
        // ORDENA POR INSERCION
        private static void insertionsort(int[] element,int first, int n)
        {
            int xindex, xLoc;
            int current;

            for (xindex = first+1; xindex <= n; xindex++)
            {
                current = element[xindex];
                xLoc = shiftVac(element, xindex, current, first);
                element[xLoc] = current;
            }
        }


        // HACE EL DESPLAZAMIENTO 
        private static int shiftVac(int[] element, int xindex, int x, int first)
        {
            int vacant = xindex;
        
            int xLoc = first; // asume que falla
            while (vacant > first)
            {
                results.comparisons++;
                if (element[vacant - 1] <= x)
                {
                    xLoc = vacant; // Exito
                    break;
                }
                else
                {
                    results.swaps++;
                    element[vacant] = element[vacant - 1]; // Recorre los datos
                }
               vacant--;
            }
            return xLoc;
        }




    }
}
