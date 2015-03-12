using modifiedSearch;
using System;

public class App{
    public static void Main(){
        int [] array = {1,2,3,4};
        Results rs = InsertionSort.sort(array,4);
        Console.Write(rs.comparisons);
        Console.Write(rs.swaps);

    }
}
