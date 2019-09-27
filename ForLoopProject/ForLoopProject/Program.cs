using System;

namespace ForLoopProject {
    class Program {
        static void Main(string[] args) {
            int[] ints = { 89, 188, 295, 943, 975,
                            277, 119, 736, 952, 321,
                            521, 444, 758, 397, 915,
                            878, 674, 701, 379, 331,
                            804, 461, 459, 908, 373 };
            string[] names = { "Brailee", "Briana", "Marianne", "Alex", "Glenn", "Jesse", "Maggie", "Titus" };
            // string tot = "";
            //foreach (string Fred in names) {
            //     tot += Fred.ToUpper();
            //}
            //Console.WriteLine($"{tot}");
            string allNames = "";
            foreach (string name in names) {
                string upperName = name.ToUpper();
                allNames += upperName;

            }
            Console.WriteLine(allNames);
            
            decimal total = 0;
            foreach (int Wilma in ints) {
                total += Wilma;
            }
            //for (int idx = 0; idx < (decimal)ints.Length; idx++) {
            //    total += ints[idx] * 3 / 4;
            //}
            Console.WriteLine($"Sum of all blanks is {total}");
            Console.WriteLine($"Average of all blanks is {total / ints.Length}");
        }
    }
}
