using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNDunit20
{
    class Rectangle
    {
        private double length, breadth;

        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public double Length
        {
            set
            {
                length = value;
            }
            get
            {
                return length;
            }
        }

        public double Breadth
        {
            set
            {
                breadth = value;
            }
            get
            {
                return breadth;
            }
        }
    }
}
