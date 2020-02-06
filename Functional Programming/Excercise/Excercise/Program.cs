using System;
using System.Linq;
namespace Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> honor = (name) =>
              {
                  Console.WriteLine("Sir " + name);
              };
            Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(n => Console.WriteLine(n));
        }
    }
}
