using System;
using System.Collections.Generic;
using System.Text;

namespace OOPShapesProject {
    public class Rect: Quad {


        public  Rect(int side_x, int side_y) : base(side_x, side_y, side_x, side_y) {
            
        }
        public override int Area() {
            return this.side1 * this.side2;
        }

    }
}
