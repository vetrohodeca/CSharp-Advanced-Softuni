using System;
using System.Linq;
namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[],int>minFunct=(arr)=>
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine();
        }
    }
}
