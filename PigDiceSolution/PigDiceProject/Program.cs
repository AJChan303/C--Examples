using System;

namespace PigDiceProject {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
    }
    class DiceRoll {
        int[] dice = new int[6];
        dice[0] = 1;
        dice[1] = 2;
        dice[2] = 3;
        dice[3] = 4;
        dice[4] = 5;
        dice[5] = 6;
        Random ran = new Random();
        int start = dice[ran.Next(0, dice.Length)];
       
    }
}
    