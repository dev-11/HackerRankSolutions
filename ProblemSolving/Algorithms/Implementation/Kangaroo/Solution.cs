using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args)
    {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);
        
        if(v1 < v2)
        {
            Console.WriteLine("NO");
        }
        else
        {
            int newX1 = x1;
            int newX2 = x2;
            
            while(newX1 < newX2)
            {
                newX1 += v1;
                newX2 += v2;
            }

            string answer = "NO";
            
            if(newX1 == newX2)
            {
                answer = "YES";
            }
            
            Console.WriteLine(answer);
        }
    }
}
