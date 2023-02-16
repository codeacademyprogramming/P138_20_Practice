using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Bravo : IStore
    {
        Product[] _products;

        public int DairyProductLimit;
        public Product[] Products { get => _products; set => _products = value; }
        public int DairyProductCount
        {
            get
            {
                int count = 0;
                foreach (Product p in _products)
                {
                    if (p is Dairy)
                    {
                        count++;
                    }
                }

                return count;
            }
        }
        public void AddProduct(Product product)
        {
            if(product is Dairy)
            {
                if (DairyProductCount == DairyProductLimit) return;
            }
            else if(product is Drink)
            {
                Drink drink = (Drink)product;
                if (drink.AlcoholPercent > 40) return;
            }

            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;
        }

        public bool HasProductByNo(string no)
        {
            foreach (var item in Products)
            {
                if (item.No == no)
                    return true;
            }
            return false;
        }

        public Product[] Search(string search)
        {
            Product[] wantedProducts = new Product[0]; 
            foreach (var item in Products)
            {
                if (item.Name.Contains(search))
                {
                    Array.Resize(ref wantedProducts, wantedProducts.Length+1);
                    wantedProducts[wantedProducts.Length - 1] = item;
                }
            }

            return wantedProducts;
        }

        public Product GetProductByNo(string no)
        {
            foreach (var item in Products)
            {
                if (item.No == no)
                    return item;
            }

            return null;
        }

        public Drink[] GetDrinks()
        {
            Drink[] drinks = new Drink[0];

            foreach (var item in Products)
            {
                if(item is Drink)
                {
                    Array.Resize(ref drinks, drinks.Length + 1);
                    drinks[drinks.Length - 1] = item as Drink;
                }
            }

            return drinks;
        }

        public Dairy[] GetDairies()
        {
            Dairy[] dairies = new Dairy[0];

            foreach (var item in Products)
            {
                if(item is Dairy)
                {
                    Array.Resize(ref dairies, dairies.Length + 1);
                    dairies[dairies.Length - 1] = (Dairy)item;
                }
            }

            return dairies;
        }
    }
}
