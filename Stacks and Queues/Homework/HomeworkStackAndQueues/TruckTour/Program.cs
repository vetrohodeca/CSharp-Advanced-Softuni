using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour06
{
    public class TruckTour
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int startPump = 0;
            int fuelLeft = 0;

            for (int i = 0; i < n; i++)
            {
                List<int> pair = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                int gasPump = pair[0];
                int distanceToNext = pair[1];
                fuelLeft += gasPump; 
                if (fuelLeft >= distanceToNext)
                {
                    fuelLeft -= distanceToNext;
                }
                else
                {
                    startPump = i + 1;
                    fuelLeft = 0;
                }
            }

            Console.WriteLine($"{startPump}");
        }
    }
}