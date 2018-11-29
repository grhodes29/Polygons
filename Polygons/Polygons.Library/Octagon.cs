using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    public class Octagon : IRegularPolygon
    {

        private string[] _array = new string[100];

        public string this[int index] {

            get { return _array[index]; }
            set { _array[index] = value; }
        }

        // public string this[int index] { get { } set { } }

        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public Octagon(int length)
        {
            NumberOfSides = 8;
            SideLength = length;

            this[0] = "One";
            var _x = this[0];

        }

        public double GetArea()
        {
            return NumberOfSides * SideLength;
        }

        public double GetPerimeter()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }
    }
}
