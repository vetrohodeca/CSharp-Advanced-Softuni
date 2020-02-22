using System;
using System.Linq;
using System.Collections.Generic;
namespace SoftuniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var guests = new HashSet<string>();
            while((input=Console.ReadLine())!="PARTY")
            {
                guests.Add(input);
            }
            while ((input = Console.ReadLine()) != "END")
            {
                guests.Remove(input);
            }
            Console.WriteLine(guests.Count);
            foreach(var element in guests)
            {
                if(element[0]>='0'||element[0]<='9')
                {
                    Console.WriteLine(element);
                }
            }
            foreach (var element in guests)
            {
                if (!(element[0] >= '0' || element[0] <= '9'))
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}
