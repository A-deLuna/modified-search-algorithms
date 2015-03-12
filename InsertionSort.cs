using System;
using System.Collections.Generic;
using System.Text;
using Estadisticos;

namespace Ordenamiento
{
    class InsertionSort
    {
       
        public void sort(int[] element, int dimension)
        {
       
            insertionsort(element, dimension);
         
        }


        // HACE EL DESPLAZAMIENTO 
        private static int shiftVac(int[] element, int xindex, int x)
        {
            int vacant = xindex;
        
            int xLoc = 0; // asume que falla
            while (vacant > 0)
            {
                if (element[vacant - 1] <= x)
                {
                    xLoc = vacant; // Exito
                    break;
                }
                else
                {
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
