using System.Collections.Generic;
using System;
namespace modifiedSearch{
    class Tests{
        private static Random random ;
        public static List<Results> generateSmallTests(){
            List<Results> tests = new List<Results>();

            int [] smallArray = generateRandomArray(10);
            int [] bigArray = generateRandomArray(1000);

            tests.Add(QuickInsertionSort.sort(smallArray, "QuickInsertionSort")); 
            tests.Add(BubbleM.sort(smallArray, "BubbleM"));
            tests.Add(QuickSortL.sort(smallArray, "QuickSortL "));
            tests.Add(BinaryInsertionSort.sort(smallArray,"BinaryInsertionSort "));
           tests.Add(ShellSortQ.sort(smallArray, "ShellSortQ "));

            return tests;

        }
        public static List<Results> generateBigTests()
        {
            List<Results> tests = new List<Results>();

            int[] smallArray = generateRandomArray(10);
            int[] bigArray = generateRandomArray(1000);

            tests.Add(QuickInsertionSort.sort(bigArray, "QuickInsertionSort "));
            tests.Add(BubbleM.sort(bigArray, "BubbleM "));
            tests.Add(QuickSortL.sort(bigArray, "QuickSortL "));
            tests.Add(BinaryInsertionSort.sort(bigArray, "BinaryInsertionSort "));
            tests.Add(ShellSortQ.sort(bigArray, "ShellSortQ "));

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
