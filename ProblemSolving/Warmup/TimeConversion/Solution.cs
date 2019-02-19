using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string time = Console.ReadLine();
        
        string[] timeParts = time.Split(':');
        int hour = int.Parse(timeParts[0]);
        
        if(timeParts.Last().EndsWith("PM"))
        {
            if(hour != 12)
            {
                hour += 12;
            }
        }else
        {
            if(hour == 12)
            {
                hour = 0;
            }
        }
           
        Console.WriteLine("{0:00}:{1}:{2}",hour,timeParts[1], timeParts[2].Replace("PM", string.Empty).Replace("AM", string.Empty));
        
    }
}
