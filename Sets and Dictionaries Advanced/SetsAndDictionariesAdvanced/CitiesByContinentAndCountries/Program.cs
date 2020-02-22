using System;
using System.Linq;
using System.Collections.Generic;
namespace CitiesByContinentAndCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];
                if (!(dictionary.ContainsKey(continent)))
                {
                    dictionary.Add(continent, new Dictionary<string, List<string>>());
                    List<string> cities = new List<string>();
                    cities.Add(city);
                    dictionary[continent].Add(country, cities);
                }
                else
                {
                    if (dictionary[continent].ContainsKey(country))
                    {
                        dictionary[continent][country].Add(city);
                    }
                    else
                    {
                        List<string> cities = new List<string>();
                        cities.Add(city);
                        dictionary[continent].Add(country, cities);
                    }
                }
            }
            foreach (var continent in dictionary)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach(var element in continent.Value)
                {
                    Console.WriteLine($"  {element.Key} -> {string.Join(", ",element.Value)}");
                }
            }
        }
    }
}
