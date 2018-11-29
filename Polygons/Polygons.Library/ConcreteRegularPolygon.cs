using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{

    public class ConcreteRegularPolygon
    {

        // public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        private int _numberOfSides;

        public int NumberOfSides
        {
            get { return _numberOfSides; }
            set { _numberOfSides = value; }
        }



        public ConcreteRegularPolygon(int sides, int length)
        {
            NumberOfSides = sides;
            SideLength = length;
        }

        [Obsolete("Use GetPerimeter()")]
        public double GetPer()
        {

            return NumberOfSides * SideLength;

        }

        public double GetPerimeter()
        {

            return NumberOfSides * SideLength;
        }

        public virtual double GetArea()
        {

            throw new NotImplementedException();
        }

    }

}
