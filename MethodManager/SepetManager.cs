using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.Name + " eklendi!");
        }
        public void Add2(int Id, string Name, double Price, string Detail)
        {
            Console.WriteLine(Name + " eklendi!");
        }
    }
}
