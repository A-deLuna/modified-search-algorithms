using System.Collections.Generic;
using System;
namespace modifiedSearch{
    class Tests{
        private static Random random ;
        public static List<Results> generateTests(){
            List<Results> tests = new List<Results>();

            int [] smallArray = generateRandomArray(10);
            int [] bigArray = generateRandomArray(1000);

            tests.Add(QuickInsertionSort.sort(smallArray)); 
            tests.Add(QuickInsertionSort.sort(bigArray)); 
            tests.Add(BubbleM.sort(smallArray));
            tests.Add(BubbleM.sort(bigArray));
            tests.Add(QuickSortL.sort(smallArray));
            tests.Add(QuickSortL.sort(bigArray));
            tests.Add(BinaryInsertionSort.sort(smallArray));
            tests.Add(BinaryInsertionSort.sort(bigArray));
            tests.Add(ShellSortQ.sort(smallArray));
            tests.Add(ShellSortQ.sort(bigArray));

            return tests;

        } 
        public static int [] generateRandomArray(int n){
            random = new Random(Guid.NewGuid().GetHashCode());
            int [] array = new int[n];
            for(int i = 0 ; i < n; i ++){
                array[i] = random.Next(1,100);
            }
            return array;
        }
    }
}
