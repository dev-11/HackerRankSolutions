using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        string[] tmp = Console.ReadLine().Split(' ');
        int[] numbers = Array.ConvertAll(tmp, int.Parse);
        
        long sum = 0;
        
        foreach(int i in numbers)
        {
            sum+=i;
        }
        
        Console.WriteLine("{0} {1}", sum-numbers.Max(), sum-numbers.Min());
    }
}
