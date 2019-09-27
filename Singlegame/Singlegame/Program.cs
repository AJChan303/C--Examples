using System;

namespace PigDiceProject3 {
    class Highscore {
        public int highscore { get; set; }

    }
    class Program {
        static void Main(string[] args) {
            Random ran = new Random();

            int dice = ran.Next(1, 7);
            int highscore = 660;
            int timesran=0;
            int total = 0;
            while(highscore < total)
                do {
                    
                    dice = ran.Next(1, 7);
                    total += dice;
                    timesran++;
                   
                } while (dice != 1);
                Console.WriteLine(total);
                if (highscore < total) {
                highscore = total;
                
                Console.WriteLine($"Highscore is {highscore}");
                Console.WriteLine($"Number games before highscore was beaten {timesran}");
          }
           
        
            
            
        }
    }
}
