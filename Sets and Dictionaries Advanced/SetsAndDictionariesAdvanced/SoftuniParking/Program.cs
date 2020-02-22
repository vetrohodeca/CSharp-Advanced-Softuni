using System;
using System.Linq;
using System.Collections.Generic;
namespace SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new HashSet<string>();
            string input = Console.ReadLine();
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(", ").ToArray();
                string command = tokens[0];
                string number = tokens[1];
                if (command == "IN")
                {
                    if (!numbers.Contains(number))
                        numbers.Add(number);
                }
                else
                {
                    if (numbers.Contains(number))
                        numbers.Remove(number);
                }
            }
            if (numbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }
            foreach (var element in numbers)
            {
                Console.WriteLine(element);
            }
        }
    }
}
