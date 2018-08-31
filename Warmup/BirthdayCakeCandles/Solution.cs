using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int birthdayCakeCandles(int n, int[] ar) {
        int maxCount = 0;
        int maxValue = int.MinValue;
        
        for(int i = 0; i < ar.Length; ++i)
        {
            if(maxValue < ar[i])
            {
                maxCount = 1;
                maxValue = ar[i];
            }else if(maxValue == ar[i])
            {
                ++maxCount;
            }
        }
        
        return maxCount;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = birthdayCakeCandles(n, ar);
        Console.WriteLine(result);
    }
}
