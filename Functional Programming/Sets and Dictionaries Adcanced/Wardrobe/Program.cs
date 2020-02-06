using System;
using System.Collections.Generic;
using System.Linq;
namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] separation = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string color = separation[0];
                List<string> lineClothes = separation[1].Split(',',StringSplitOptions.RemoveEmptyEntries).ToList();

                if(!wardrobe.ContainsKey(color))
                {
                    wardrobe[color]=new Dictionary<string, int>();
                }
                foreach(var cloth in lineClothes)
                {
                    if(!wardrobe[color].ContainsKey(cloth))
                    {
                        wardrobe[color][cloth] = 0;
                    }
                    wardrobe[color][cloth]++;
                }
            }
            string search = Console.ReadLine();
            string[] tokens = search.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string searchColor = tokens[0];
            string searchClothes = tokens[1];
            foreach (var colorPair in wardrobe)
            {
                string color = colorPair.Key;
                Dictionary<string, int> clothes = colorPair.Value;
                Console.WriteLine($"{color} clothes:");
                foreach (var quantityPair in clothes)
                {
                    string cloth = quantityPair.Key;
                    int qnty = quantityPair.Value;
                    if (color == searchColor && cloth == searchClothes)
                    {
                        Console.WriteLine($"* {cloth} - {qnty} (found!)");
                    }  
                    else
                    {
                        Console.WriteLine($"* {cloth} - {qnty}");
                    }
                }
            }
        }
    }
}
