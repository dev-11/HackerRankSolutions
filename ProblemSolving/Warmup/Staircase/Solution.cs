using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i<n; ++i)
        {
            for(int j = n-i; j > 1; --j )
            {
                Console.Write(" ");   
            }
            
            for(int j = (n-i); j <= n; ++j)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}
