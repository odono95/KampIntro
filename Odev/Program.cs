using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product computer = new Product();
            computer.productName = "ASUS";
            computer.productImage = "URL to the product";
            computer.productPrice = 7500;

            Product car = new Product();
            car.productName = "Opel";
            car.productImage = "URL to the product";
            car.productPrice = 350000;

            Product[] products = new Product[] { computer, car };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].productName + " costs " + products[i].productPrice + " and you can find the picture of the product at " + products[i].productImage);
            }

            foreach (var product in products)
            {
                Console.WriteLine(product.productName + " costs " + product.productPrice + " and you can find the picture of the product at " + product.productImage);
            }

        }
    }

    class Product
    {
        public string productName { get; set; }
        public string productImage { get; set; }
        public double productPrice { get; set; }
    }
}
