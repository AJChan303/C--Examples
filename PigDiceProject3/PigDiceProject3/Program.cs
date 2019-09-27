using System;

namespace PigDiceProject3 {
    class Program {
        static void Main(string[] args) {
            Random ran = new Random();
            int total = 0;
             int dice = ran.Next(1, 7);

            do {
                
                dice = ran.Next(1, 7);
                total += dice;
                Console.WriteLine($"{dice}");
            } while (dice != 1);
            Console.WriteLine(total);
          //if(int highscore < total) {
          //      highscore = total;
          //  }
        }
    }
}
