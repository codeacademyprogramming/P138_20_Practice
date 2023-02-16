using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Dairy : Product
    {
        public Dairy():base("Dairy")
        {

        }
        public double FatPercent;

        public override void ShowInfo()
        {
            Console.WriteLine($"No:{No} - Name: {Name} - Category: {Category} - Price: {Price} - FatPercent: {FatPercent}");
        }
    }
}
