using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW11
{
    class Stock
    {
        List<Product> products = new List<Product>();
        public Stock(List<Product> porductsList)
        {
            this.products = porductsList;
        }
        public void WritePlane(int index)
        {
            if (index > products.Count - 1)
                throw new Exception("Продукта не существует");
            Console.WriteLine("Название продукта: " + products[index].productName);
            Console.WriteLine("Название магазина: " + products[index].shopName);
            Console.WriteLine("Стоимость товара в рублях: " + products[index].cost);
        }
        public void ProductAdd(Product addProduct)
        {
            products.Add(addProduct);
        }
        public void AddProductsRange(params Product[] Product)
        {
            products.AddRange(Product);
        }
    }
    class Product : IComparable<Product>
    {
        private string _productName;
        private string _shopName;
        private decimal _cost;

        public Product(string productName, string shopName, decimal cost)
        {
            this._productName = productName;
            this._shopName = shopName;
            this._cost = cost;
        }

        public string productName { get { return _productName; } set { _productName = value; } }
        public string shopName { get { return _shopName; } set { _shopName = value; } }
        public decimal cost { get { return _cost; } set { _cost = value; } }

        public int CompareTo(Product obj)
        {
            if (shopName.CompareTo(obj.shopName)!=0)
            {
                return shopName.CompareTo(obj.shopName);
            }
            if (productName.CompareTo(obj.productName)!=0)
            {
                return productName.CompareTo(obj.productName);
            }
            return cost.CompareTo(obj.cost);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("Юбка", "ExPz", 25));
            products.Add(new Product("Шорты", "ExPу", 55));
            products.Add(new Product("Юбка", "ExPу", 11));
            products.Add(new Product("Бита", "ExPzz", 99));
            products.Sort();
            Stock product = new Stock(products);
            for (int i = 0; i < products.Count; i++)
            {
                product.WritePlane(i);
            }
            Console.ReadLine();
        }
    }
}
