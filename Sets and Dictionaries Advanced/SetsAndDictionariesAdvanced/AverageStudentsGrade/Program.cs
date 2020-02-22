using System;
using System.Linq;
using System.Collections.Generic;
namespace AverageStudentsGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = tokens[0];
                decimal grade = decimal.Parse(tokens[1]);
                if (dictionary.ContainsKey(name))
                {
                    dictionary[name].Add(grade);
                }
                else
                {
                    dictionary.Add(name, new List<decimal>());
                    dictionary[name].Add(grade);
                }
            }
            foreach(var element in dictionary)
            {
                decimal avg=0;
                foreach (var grade in element.Value)
                {
                    avg += grade;
                }
                avg /= element.Value.Count;
                Console.Write(element.Key+ " -> ");
                foreach (decimal item in element.Value)
                {
                    Console.Write($"{item:F2} ");
                }
                Console.WriteLine($"(avg: {avg:F2})");
            }
        }
    }
}
