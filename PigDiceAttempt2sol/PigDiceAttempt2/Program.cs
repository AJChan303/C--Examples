﻿using System;

namespace PigDiceAttempt2 {
    class Program {
        static void Main(string[] args) {
            int[] dice = new int[6] { 1, 2, 3, 4, 5, 6 };
            Random ran = new Random();
            int start = dice[ran.Next(1, dice.Length)];
           //Console.WriteLine($"Dice Roll: {start}");
            int total = 0;
            int TimesRan = 0;
            
            do {

            }

    //        while (start != 1) {
    //            start = dice[ran.Next(0, dice.Length)];
    //            total = total + start;
                
    //            TimesRan = TimesRan + 1;
    //        }
    //        Console.WriteLine($"Game Total: {total}");
        }
    }
}

// look at do.. While or for()
//Add counter and best tracking
//highest score 142