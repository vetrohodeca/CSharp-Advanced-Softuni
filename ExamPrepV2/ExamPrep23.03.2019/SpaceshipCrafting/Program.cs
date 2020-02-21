using System;
using System.Linq;
using System.Collections.Generic;
namespace SpaceshipCrafting
{
    class Program
    {
        private const int GLASS_MIN_VALUE = 25;
        private const int ALUMINIUM_MIN_VALUE = 50;
        private const int LITHIUM_MIN_VALUE = 75;
        private const int CARBONFIBER_MIN_VALUE = 100;

        private static int glassCount = 0;
        private static int aluminiumCount = 0;
        private static int lithiumCount = 0;
        private static int carbonfiberCount = 0;

        static void Main(string[] args)
        {   
            int[] liquidsInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] pysicalElementsInput= Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> chemicalLquids = new Queue<int>(liquidsInput);
            Stack<int> physicalElements = new Stack<int>(pysicalElementsInput);
            while (chemicalLquids.Count > 0 && physicalElements.Count > 0)
            {
                int currentLiquid = chemicalLquids.Dequeue();
                int currentItem = physicalElements.Pop();
                int currentSum = currentItem + currentLiquid;
                if (currentSum == GLASS_MIN_VALUE)
                {
                    glassCount++;
                }
                else if (currentSum == ALUMINIUM_MIN_VALUE)
                {
                    aluminiumCount++;
                }
                else if (currentSum == LITHIUM_MIN_VALUE)
                {
                    lithiumCount++;
                }
                else if (currentSum == CARBONFIBER_MIN_VALUE)
                {
                    carbonfiberCount++;
                }
                else
                {
                    physicalElements.Push(currentItem+3);
                }
            }

            if (glassCount > 0 && aluminiumCount > 0 &&lithiumCount>0&&carbonfiberCount>0)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }
            string liquidsString = chemicalLquids.Count > 0 ? string.Join(", " , chemicalLquids) : "none";
            Console.WriteLine($"Liquids left: {liquidsString}");

            string itemsString = physicalElements.Count > 0 ? string.Join(", ",physicalElements) : "none";
            Console.WriteLine($"Physical items left: {itemsString}");
            Console.WriteLine($"Aluminium: {aluminiumCount}");
            Console.WriteLine($"Carbon fiber: {carbonfiberCount}");
            Console.WriteLine($"Glass: {glassCount}");
            Console.WriteLine($"Lithium: {lithiumCount}");
        }
    }
}
