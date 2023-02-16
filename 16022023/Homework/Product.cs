using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal abstract class Product
    {
        static int _count = 0;

        public Product()
        {
            _count++;
            No = _count;
        }

        public int No;
        public string Name;
        public double Price;
    }
}
