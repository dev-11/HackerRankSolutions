using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < n; a0++){
            int grade = Convert.ToInt32(Console.ReadLine());
            int rounding = 5-grade %5;
            
            if(rounding < 3 && grade >= 38)
            {
                grade += rounding;
            }
            
            Console.WriteLine(grade);
        }
    }
}
