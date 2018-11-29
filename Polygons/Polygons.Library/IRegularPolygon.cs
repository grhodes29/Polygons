using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{


    // only properties, methods, events, indexers allowed !!!1
    public interface IRegularPolygon
    {

        // Indexer declaration
        string this[int index] { get; set; }


        int NumberOfSides { get; set; }
        int SideLength { get; set; }


        double GetPerimeter();
        double GetArea();


    }
}
