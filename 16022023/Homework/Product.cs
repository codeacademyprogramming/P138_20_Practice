using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Homework
{
    internal abstract class Product
    {
        static int _count = 100;

        public Product(string category)
        {
            Category = category;

            _count++;
            No = category.Substring(0,2).ToUpper()+ _count;
        }

        public string No;
        public string Category;
        public string Name;
        public double Price;

        public abstract void  ShowInfo();

    }
}
