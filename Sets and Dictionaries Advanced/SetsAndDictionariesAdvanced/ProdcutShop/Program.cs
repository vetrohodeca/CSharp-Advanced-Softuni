using System;
using System.Collections.Generic;
using System.Linq;
namespace ProdcutShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var productShop = new Dictionary<string, Dictionary<string, double>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Revision") 
            {
                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string shopName = tokens[0];
                string productName = tokens[1];
                double price = double.Parse(tokens[2]);
                if (productShop.ContainsKey(shopName))
                {
                    if(!(productShop[shopName].ContainsKey(productName)))
                    productShop[shopName].Add(productName, price);
                }
                else
                {
                    productShop.Add(shopName, new Dictionary<string, double>());
                    productShop[shopName].Add(productName, price);
                }
            }
            foreach(var currentShop in productShop.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{currentShop.Key}->");
                foreach(var currentProduct in currentShop.Value)
                {
                    Console.WriteLine($"Product: {currentProduct.Key}, Price: {currentProduct.Value}");
                }
            }
        }
    }
}
