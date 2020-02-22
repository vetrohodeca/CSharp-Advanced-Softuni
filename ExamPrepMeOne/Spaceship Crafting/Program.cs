using System;
using System.Collections.Generic;
using System.Linq;
namespace Spaceship_Crafting
{
    class Program
    {
        const int GLASSVALUE = 25;
        const int ALUMINIUMVALUE = 50;
        const int LITHIUMVALUE = 75;
        const int CARBONFIBERVALUE = 100;
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> liquids = new Queue<int>(input1);
            Stack<int> physicalItems = new Stack<int>(input2);
            int glass = 0;
            int aluminium = 0;
            int lithium = 0;
            int carbon = 0;
            while (liquids.Count > 0 && physicalItems.Count > 0)
            {
                if (liquids.Peek() + physicalItems.Peek() == GLASSVALUE)
                {
                    glass++;
                    liquids.Dequeue();
                    physicalItems.Pop();
                }
                else if (liquids.Peek() + physicalItems.Peek() == ALUMINIUMVALUE)
                {
                    aluminium++;
                    liquids.Dequeue();
                    physicalItems.Pop();
                }
                else if (liquids.Peek() + physicalItems.Peek() == LITHIUMVALUE)
                {
                    lithium++;
                    liquids.Dequeue();
                    physicalItems.Pop();
                }
                else if (liquids.Peek() + physicalItems.Peek() == CARBONFIBERVALUE)
                {
                    carbon++;
                    liquids.Dequeue();
                    physicalItems.Pop();
                }
                else
                {
                    liquids.Dequeue();
                    physicalItems.Push(physicalItems.Pop() + 3);
                }
            }
            bool hasShip = (carbon >= 1 && lithium >= 1 && aluminium >= 1 && glass >= 1);
            if (hasShip)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.Write("Liquids left: ");
                Console.WriteLine(string.Join(", ", liquids));
            }
            if (physicalItems.Count == 0)
            {
                Console.WriteLine("Physical items left: none");
            }
            else
            {
                Console.Write("Physical items left: ");
                Console.WriteLine(string.Join(", ", physicalItems));
            }
            Console.WriteLine($"Aluminium: {aluminium}");
            Console.WriteLine($"Carbon fiber: {carbon}");
            Console.WriteLine($"Glass: {glass }");
            Console.WriteLine($"Lithium: {lithium}");
        }
    }
}
