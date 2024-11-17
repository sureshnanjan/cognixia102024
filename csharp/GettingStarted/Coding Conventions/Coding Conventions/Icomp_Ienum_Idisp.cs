using System;
using System.Collections;
using System.Collections.Generic;
namespace KeywordLearning
{
    public interface ICustomComparable
    {
        int CompareTo(object obj);
    }

    public class Product : ICustomComparable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        // Implementing CompareTo to compare two Product objects
        public int CompareTo(object obj)
        {
            if (obj is Product otherProduct)
            {
                return this.Price.CompareTo(otherProduct.Price);
            }
            throw new ArgumentException("Object is not a Product.");
        }
    }

    public interface ICustomEnumerable
    {
        IEnumerator GetEnumerator();
    }

    public class Shop : ICustomEnumerable
    {
        private List<Product> _products;

        public Shop()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public IEnumerator GetEnumerator()
        {
            return _products.GetEnumerator();
        }
    }

    public class DisposableResource : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Resources are being cleaned up...");
            // Release any resources here
        }
    }
}