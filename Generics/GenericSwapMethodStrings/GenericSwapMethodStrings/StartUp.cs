using System;

namespace GenericSwapMethodStrings
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var personInfo = Console.ReadLine().Split();
            string fullName = $"{personInfo[0]}{personInfo[1]}";
            string address = $"{personInfo[2] }";
            var nameAndBeer = Console.ReadLine().Split();
            string name = nameAndBeer[0];
            int beerAmount = int.Parse(nameAndBeer[1]);
            var thridInput = Console.ReadLine().Split();
            var firstArgument = int.Parse(thridInput[0]);
            var secondArgument = double.Parse(thridInput[1]);
            Tuple<string, st
        }
    }
}
