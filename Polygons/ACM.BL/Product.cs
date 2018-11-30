using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase
    {

        public string ProductName { get; set; }

        public Product(string inProductName)
        {
            ProductName = inProductName;
        }

        public override string ToString()
        {
            return this.ProductName;
        }

        public override bool Validate() { var _isValid = true;

            // some additional logic here


            return _isValid;
        }
    }
}
