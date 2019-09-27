using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result {
    static void plusMinus(int[] arr) {
        int pos = 0;
        int neg = 0;
        int zero = 0;
        foreach (int n in arr) {
            if (n == 0) {
                zero++;
            } else if (n < 0) {
                neg++;

            } else if (n > 0) {
                pos++;
            }

        }
        decimal positive =(decimal) pos / (decimal)arr.Length;
        decimal negative = (decimal)neg / (decimal)arr.Length;
        decimal calczero = (decimal)zero / (decimal)arr.Length;



    }
    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr) {
        int n = -1;
        int total = 0;
        int FirstDiag = 0;
        int SecondDiag = 0;
        for (int i = 0; i <= n; i++) {
             FirstDiag += arr[i][i]; 
             SecondDiag += arr[n-i][i];
        }
             total = Math.Abs(FirstDiag) - Math.Abs(SecondDiag);
        return total;
    }


}
    static void Main(string[] args) {
        int[] ar = { 1, 2, 3, 4, 10, 11 };
        Console.WriteLine(   simpleArraySum(ar));
    }
}
