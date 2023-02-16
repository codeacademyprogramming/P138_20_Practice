using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Drink:Product
    {
        public Drink():base("Drink")
        {

        }
        public double AlcoholPercent;

        public override void ShowInfo()
        {
            Console.WriteLine($"No:{No} - Name: {Name} - Category: {Category} - Price: {Price} - AlcoholPercent: {AlcoholPercent}");

        }
    }
}
