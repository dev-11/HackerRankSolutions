using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    private static int _alicePoints;
    private static int _bobPoints;
    
    static void Main(String[] args) {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);
        
        EvaluateScores(a0,b0);
        EvaluateScores(a1,b1);
        EvaluateScores(a2,b2);
        
        Console.WriteLine("{0} {1}", _alicePoints, _bobPoints);
    }
    
    private static void EvaluateScores(int score1, int score2)
    {
        if(score1 > score2)
        {
            ++_alicePoints;
        }
        if(score2 > score1)
        {
            ++_bobPoints;
        }
    }
}
