using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        int positiveCount = arr.Count(x => x > 0);
        int negativeCount = arr.Count(x => x < 0);
        int zeroCount = arr.Count(x => x == 0);
        
        Console.WriteLine("{0:F6}",(double)positiveCount/n);
        Console.WriteLine("{0:F6}",(double)negativeCount/n);
        Console.WriteLine("{0:F6}",(double)zeroCount/n);
    }
}
