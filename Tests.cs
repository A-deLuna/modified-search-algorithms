using System.Collections;
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
            tests.Add(QuicksortL.sort(smallArray));
            tests.Add(QuicksortL.sort(bigArray));
            tests.Add(BinaryInsertionSort.sort(smallArray));
            tests.Add(BinaryInsertionSort.sort(bigArray));
            tests.Add(Shellsort.sort(smallArray));
            tests.Add(Shellsort.sort(bigArray));

            return tests;

        } 
        public static int [] generateRandomArray(int n){
            random = new Random(Guid.newGuid().GetHashCode());
            int [] array = new int[n];
            for(int i = 0 ; i < n; i ++){
                array[i] = random.Next(1,100);
            }
            return array;
        }
    }
}
