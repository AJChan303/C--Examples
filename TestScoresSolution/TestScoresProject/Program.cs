using System;

namespace TestScoresProject {
    class Program {
        static void Main(string[] args) {
            int[] scores = { 71, 78, 89, 73, 68, 73, 96, 71, 72, 65, 87, 63, 100, 100, 100 };
            
            decimal avg = 0;
            decimal total = 0;
            int index = 0;
            while (index < scores.Length) {
                total = total + scores[index];
                index = index + 1;
                avg = total / scores.Length;

            }
            Console.WriteLine($"The Average is {avg}%");
        }
    }
}
