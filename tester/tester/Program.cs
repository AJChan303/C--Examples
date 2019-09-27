using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr) {
        int total = 0;
        foreach (int nbr in arr) {
            total += nbr;
        }
        int maxnbr = arr.Max();
        int minnbr = arr.Min();
        int total2 = total;
        total2 -= minnbr;
        total -= maxnbr;
        Console.WriteLine($"{total2} {total}");
        
    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
