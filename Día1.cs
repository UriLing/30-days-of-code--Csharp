using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        
        // Read and save an integer, double, and String to your variables.
        int j= Int32.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        string ss = Console.ReadLine();
        // Print the sum of both integer variables on a new line.
        int suma1= i + j;
        Console.WriteLine(suma1);
        // Print the sum of the double variables on a new line.
        
        Console.WriteLine($"{(d+e):0.0}");
       
        // Concatenate and print the String variables on a new line

        Console.WriteLine(s+ss);
        // The 's' variable above should be printed first.

    }
}