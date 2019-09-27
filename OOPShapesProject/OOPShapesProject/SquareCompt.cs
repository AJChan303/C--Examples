using System;
using System.Collections.Generic;
using System.Text;

namespace OOPShapesProject {
   public class SquareCompt  {
        private Quad quad;
        public int GetPerimeter() {
            return quad.GetPerimeter();
        }
        public int Area() {
            return quad.side1 *quad.side1;
        }
        public SquareCompt(int side_f) {
            quad = new Quad(side_f, side_f, side_f, side_f);
        }

    }
}
