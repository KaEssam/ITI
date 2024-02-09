using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_C__Advanced
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Company company = new Company { ID = 1, Name = "ABC Company" };
            Supplier supplier1 = new Supplier { ID = 1, Name = "Supplier 1" };

            company.LowQuantityNotification += supplier1.HandleLowQuantity;

            Product product1 = new Product { ID = 101, Name = "Product 1" };
            company.AddProduct(product1, 10);

            company.SellProduct(product1, 6);

            company.PaySupplier(product1, 20);

            company.SellProduct(product1, 15);

            Console.ReadLine();
        }
    }

    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }

        private Dictionary<Product, int> products = new Dictionary<Product, int>();

        public event EventHandler<Product> ProductSold;

        public event EventHandler<Product> LowQuantityNotification;

        public void AddProduct(Product product, int quantity)
        {
            if (products.ContainsKey(product))
            {
                products[product] += quantity;
            }
            else
            {
                products.Add(product, quantity);
            }
        }

        public void SellProduct(Product product, int quantity)
        {
            if (products.ContainsKey(product))
            {
                products[product] -= quantity;
                if (products[product] < 5)
                {
                    LowQuantityNotification?.Invoke(this, product);
                }
                if (products[product] <= 0)
                {
                    products.Remove(product);
                }
                ProductSold?.Invoke(this, product);
            }
        }

        public void PaySupplier(Product product, int quantity)
        {
            AddProduct(product, quantity);
        }
    }

    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void HandleLowQuantity(object sender, Product product)
        {
            Console.WriteLine($"Notification for supplier {Name}: Product {product.Name} has low quantity.");
        }
    }
}