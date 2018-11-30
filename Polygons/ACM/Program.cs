using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    class Program
    {
        static void Main(string[] args)
        {

            Product _product = new Product("My New Product");

            Console.WriteLine(_product.ToString());


            Console.ReadLine(); 



        }
    }
}
