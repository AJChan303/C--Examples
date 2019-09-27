using System;
using System.Collections.Generic;
using System.Text;

namespace OOPShapesProject {
    public class Quad {
        public int side1;
        public int side2;
        public int side3;
        public int side4;

        public  Quad(int side_a, int side_b, int side_c, int side_d) {//constructor :)
            this.side1 = side_a;
            this.side2 = side_b;

            this.side3 = side_c;
            this.side4 = side_d;
        }

        public virtual int Area() {
            throw new NotImplementedException("Cannot calc area of quad!");
        }

        public int GetPerimeter() {
            return side1 + side2 + side3 + side4;
        }
            
    }
}
