using System;
using System.Collections.Generic;
using System.Text;
using Estadisticos;

namespace Ordenamiento
{

    class RadixBit
    {
        static SortResults sortR;

        public SortResults sort(int[] element, int last)
        {
            sortR = new SortResults();

            // número de bits
            int r = 4; // este dato puede ser  2, 8 o 16 para ver si es más rápido
            // numero de bits de un número int en  C# 
            int b = 32;


            sort(element, b, (int)Math.Ceiling((double)b / (double)r), r);
            return sortR;
        }


        // Precondiciones:
        // element es le vector de números
        // radix es la dimensión de las cubetas
        // en este caso como es byte ( rango de 0 a 255 ) el valor debe de ser 256
        // numfields es el número de campos en la llave
        // Postcondiciones : ordenar el vector element en forma ascendente
        public void sort(int[] element, int radix, int numfields, int numbits)
        {
            // Lista de cubetas de longitud radix
            List<int>[] buckets = new List<int>[radix];

            // Cada cubeta apunta a una lista
            for (int i = 0; i < buckets.Length; i++)
                buckets[i] = new List<int>();

            for (int field = 0; field < numfields; field++)
            {
                distribute(element, buckets, field, numfields, numbits);
                combine(element, buckets);

            }
        }



        //Precondiciones:
        // element es el vecto de números
        // buckets es el vector que opera como cubetas
        // field es la posición del dígito a revisar
        // numfields es la longitud máxima del campos en la llave
        // Postcondiciones:
        // Distribuye cada elemento en la cubeta dependiendo del dígito 
        private void distribute(int[] element, List<int>[] buckets, int field, int numfields, int numbits)
        {
            int shift = 0;
            for (int i = 0; i < element.Length; i++)
            {
                // Calcula la cubeta en donde le corresponde                
                int index = maskShift(element[i], shift);
                shift += numbits;
                // Agrega el dato del vector element[i] a la lista en la cubeta calculada
                buckets[index].Add(element[i]);
            }
        }



        // Postcondiciones: calcula la cubeta en donde le corresponde ubicar al número
        private int maskShift(int numero, int bytes)
        {
            // x =  (  numero divido entre bytes ) 
            int x = (numero >> bytes / 8) & 0xFF;
            return x;
        }



        // Precondiciones:
        // element es el vector de números
        // buckets es el vector que opera como cubetas
        // Postcondiciones: combina las listas 
        void combine(int[] element, List<int>[] buckets)
        {
            // combina las cubetas
            int idx = 0;
            for (int i = 0; i < buckets.Length; i++)
            {
                List<int> bucket = buckets[i];
                for (int k = 0; k < bucket.Count; k++)
                    element[idx++] = bucket[k];
                // Inicializa la lista de la cubeta i
                bucket.Clear();
            }

        }

    }
}
