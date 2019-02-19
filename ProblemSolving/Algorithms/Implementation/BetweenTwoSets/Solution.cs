using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    
    static int gcd(int a, int b) {
        while(a!=0 && b!=0) {
            if (a >= b)
                a %= b;
            else
                b %= a;
        }
        return a + b;
    }

    static int lcm(int a, int b) {
        return (a / gcd(a, b)) * b;
    }

    /*
     * Complete the getTotalX function below.
     */
    static int getTotalX(int[] a, int[] b) {
        int multiple = 0;
        foreach(int i in b) {
            multiple = gcd(multiple, i);
        }
       
        int factor = 1;
        foreach(int i in a) {
            factor = lcm(factor, i);
            if (factor > multiple) {
                return 0;
            }
        }

        if (multiple % factor != 0) {
            return 0;
        }
       
        int val = multiple / factor;
        
        int max = Math.Max(factor, val);
        int totalX = 1;
        
        for (int i = factor; i < multiple; i++) {
            if (multiple % i == 0 && i % factor == 0) {
                totalX++;
            }
        }

        return totalX;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
        ;
        int total = getTotalX(a, b);

        tw.WriteLine(total);

        tw.Flush();
        tw.Close();
    }
}
