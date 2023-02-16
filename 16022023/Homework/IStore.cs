using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal interface IStore
    {
        Product[] Products { get; set; }
        void AddProduct(Product product);
        Product[] Search(string search);
        bool HasProductByNo(int no);
        Product GetProductByNo(int no);
    }
}
