using System;
using System.ComponentModel;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bravo bravo = new Bravo();

            string opt;
            do
            {
                Console.WriteLine("1. Butun mehsullara bax");
                Console.WriteLine("2. Drink mehsullarina bax");
                Console.WriteLine("3. Dairy mehsullarina bax");
                Console.WriteLine("4. Secilmis nomreli mehsula bax");
                Console.WriteLine("5. Mehsul elave et");
                Console.WriteLine("6. Axtarix et");
                Console.WriteLine("0. Cixis");

                Console.WriteLine("\nSecim edin:");
                opt = Console.ReadLine();


                switch (opt)
                {
                    case "1":
                        foreach (var item in bravo.Products)
                        {
                            item.ShowInfo();
                        }
                        break;
                    case "2":
                        foreach (var item in bravo.GetDrinks())
                        {
                            item.ShowInfo();
                        }
                        break;
                    case "3":
                        foreach (var item in bravo.GetDairies())
                        {
                            item.ShowInfo();
                        }
                        break;
                    case "4":
                        Console.Write("No: ");
                        string no = Console.ReadLine();

                        Product wantedProduct = bravo.GetProductByNo(no);

                        if (wantedProduct == null)
                            Console.WriteLine($"{no} nomreli mehsul yoxdur");
                        else
                            wantedProduct.ShowInfo();
                        break;
                    default:
                        break;
                }

            } while (opt!="0");
            

        }
    }
}
