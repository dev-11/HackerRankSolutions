using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] score_temp = Console.ReadLine().Split(' ');
        int[] score = Array.ConvertAll(score_temp,Int32.Parse);
        // your code goes here
        
        int max = score[0];
        int min = score[0];
        
        int minCount = 0;
        int maxCount = 0;
        
        for(int i =0; i < score.Length; ++i)
        {
            if(score[i] < min)
            {
                minCount++;
                min = score[i];
            }
            
            if(score[i] > max)
            {
                maxCount++;
                max = score[i];
            }
        }
        
        Console.WriteLine("{0} {1}", maxCount, minCount);
    }
}
