        using System;
        using System.Linq;
        using System.Collections.Generic;
        namespace PeriodicTable
        {
            class Program
            {
                static void Main(string[] args)
                {
                    SortedSet<string> elements = new SortedSet<string>();
                    int n = int.Parse(Console.ReadLine());
                    for(int i=0;i<n;i++)
                    {
                        string input = Console.ReadLine();
                        List < string > line = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                        foreach(var e in line)
                        {
                            elements.Add(e);
                        }
                    }
                    foreach(var element in elements)
                    {
                        Console.Write(element+" ");
                    }
                }
            }
        }
