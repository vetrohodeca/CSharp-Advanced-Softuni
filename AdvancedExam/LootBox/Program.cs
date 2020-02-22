using System;
using System.Collections.Generic;
using System.Linq;
namespace LootBox
{
    class Program
    {
        static void Main(string[] args)
        {
            int loot= 0;
            int[] firstLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> firstBox = new Queue<int>(firstLine);
            Stack<int> secondBox = new Stack<int>(secondLine);
            while (firstBox.Count > 0 && secondBox.Count > 0)
            {

                if ((firstBox.Peek() + secondBox.Peek()) % 2 == 0)
                {
                    loot += firstBox.Dequeue();
                    loot += secondBox.Pop();
                }
                else
                {
                    Queue<int> tempFirst = new Queue<int>();
                    Stack<int> tempSecond = new Stack<int>(secondBox);
                    firstBox.Enqueue(secondBox.Pop());
                }
            }
                if(firstBox.Count==0)
                {
                    Console.WriteLine("First lootbox is empty");
                }
                if(secondBox.Count==0)
                {
                    Console.WriteLine("Second lootbox is empty");
                }
                if(loot>=100)
                {
                    Console.WriteLine($"Your loot was epic! Value: {loot}");
                }
                else Console.WriteLine($"Your loot was poor... Value: {loot}");
        }
        static object RemoveLast(Queue<int> q)
        {
            int first = q.Peek();
            int current = 0;
            while (true)
            {
                current = q.Dequeue();
                if (q.Peek() == first)
                {
                    break;
                }
                q.Enqueue(current);
            }
            return current;
        }
    }
}
