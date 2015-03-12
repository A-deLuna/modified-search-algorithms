using modifiedSearch;
using System;

public class App{
    public static void Main(){
        int [] array = {4,3,2,1};
        Results rs = InsertionSort.sort(array,4);
        Console.WriteLine(rs.comparisons);
        Console.WriteLine(rs.swaps);
        foreach( int element in array){
          Console.Write(element);
        }
        Console.WriteLine();
        int [] array2 = {4,3,2,1};
        rs = QuickSort.sort(array2, 4);
        Console.WriteLine(rs.comparisons);
        Console.WriteLine(rs.swaps);
        foreach( int element in array2){
          Console.Write(element);
        }
        Console.WriteLine();


    }
}
