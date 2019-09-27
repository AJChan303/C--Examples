using System;

namespace PigDiceLatest {
    class Program {
        static void Main(string[] args) {
          
            var ran = new Random();
            var total = 0;
            var highscore = 0;
            var timesran = 0;
            do {
                var dice = ran.Next(1, 7);
                total += dice;
               
            } while(dice !== 1);
        }
    }
}
