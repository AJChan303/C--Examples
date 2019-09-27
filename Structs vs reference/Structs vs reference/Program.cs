using System;
using System.Text;

namespace Structs_vs_reference {
    class Program {
        static void Main(string[] args) {
            StringBuilder sb = new StringBuilder();
            string s = "";
            DateTime d1 = DateTime.Now;
            for (long i = 0; i < 10000000000000; i++) {
               sb.Append("sadfasdfa");
            }
            DateTime d2 = DateTime.Now;
            Console.WriteLine(d1-d2);
            
            //    Cube c1 = new Cube();
            //    c1.x = 10;
            //    c1.y = 12;
            //    c1.z = 14;

            //    ProcessCube(c1);

            //    //Cube c2;
            //    //c2 = c1;
            //    //c2.x = 1000;
            //    //Console.WriteLine(c2.x);
            //    //Console.WriteLine(c1.x);
            //}
            //static void ProcessCube(Cube cu) {
            //    Console.WriteLine(cu.x);
            //}
        }

        class Cube {
            public int x { get; set; }
            public int y { get; set; }
            public int z { get; set; }

        }
    }
}
