using System;
using System.Collections.Generic;
using System.Text;

namespace modifiedSearch
{
    class InsertionSort
    {
        private static Results results; 
        public static Results sort(int[] element, int dimension)
        {
            results = new Results();
            insertionsort(element, dimension);
            return results;
         
        }


        // HACE EL DESPLAZAMIENTO 
        private static int shiftVac(int[] element, int xindex, int x)
        {
            int vacant = xindex;
        
            int xLoc = 0; // asume que falla
            while (vacant > 0)
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


        // ORDENA POR INSERCION
        private static void insertionsort(int[] element, int n)
        {
            int xindex, xLoc;
            int current;

            for (xindex = 1; xindex < n; xindex++)
            {
                current = element[xindex];
                xLoc = shiftVac(element, xindex, current);
                element[xLoc] = current;
            }
        }


    }
}
