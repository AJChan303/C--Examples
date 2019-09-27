using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speach {
    class Program {
        static void Main(string[] args) {
            var speak = new System.Speech.Synthesis.SpeechSynthesizer();
            speak.Rate = 0;
            speak.Speak("Never gonna give you up Never gonna let you down Never gonna run around and desert you");
        }
    }
}
