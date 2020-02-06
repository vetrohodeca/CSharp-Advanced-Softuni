    using System;
    using System.Collections.Generic;
    using System.Linq;
    namespace SonqsQueue
    {
        class Program
        {
            static void Main(string[] args)
            {
                Queue<string> songs = new Queue<string>();
                string firstLine = Console.ReadLine();
                string[] firstSongs = firstLine.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (var el in firstSongs)
                {
                    songs.Enqueue(el);
                }
                while (true)
                {
                    string command = Console.ReadLine(); 
                    if (command[0] == 'A')
                    {
                        string[] tokens = command.Split("Add ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                        if(songs.Contains(tokens[0]))
                        {
                            Console.WriteLine($"{tokens[0]} is already contained!");
                        }
                        else
                        {
                            songs.Enqueue(tokens[0]);
                        }
                    }
                    if (command == "Show")
                    {
                        Console.WriteLine(string.Join(", ", songs));
                    }
                    if (command == "Play" && songs.Count > 0)
                    {
                        songs.Dequeue();
                    }
                    if (songs.Count == 0 && command == "Play")
                    {
                        Console.WriteLine("No more songs!");
                        break;
                    }

                }
            }
        }
    }
