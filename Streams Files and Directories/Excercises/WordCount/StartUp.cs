using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        StreamReader fileWords = new StreamReader("words.txt", Encoding.UTF8);
        StreamReader fileText = new StreamReader("text.txt", Encoding.UTF8);
        StreamWriter fileDestination = new StreamWriter("result.txt");
        Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();

        using (fileWords)
        {
            string line = fileWords.ReadLine();

            while (line != null)
            {
                string[] lineWords = line.Split(new char[] { ' ', '\n', '.', '!', '?', '-', ',' },
                    StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < lineWords.Length; i++)
                {
                    lineWords[i] = lineWords[i].ToLower();

                    if (!(wordsDictionary.ContainsKey(lineWords[i])))
                    {
                        wordsDictionary.Add(lineWords[i], 0);
                    }
                }

                line = fileWords.ReadLine();
            }

            using (fileText)
            {
                using (fileDestination)
                {
                    string lineText = fileText.ReadLine();

                    while (lineText != null)
                    {
                        string[] lineTextSplited = lineText.Split(new char[] { ' ', '\n', '.', '!', '?', '-', ',' },
                            StringSplitOptions.RemoveEmptyEntries);

                        for (int j = 0; j < lineTextSplited.Length; j++)
                        {
                            lineTextSplited[j] = lineTextSplited[j].ToLower();

                            if (wordsDictionary.ContainsKey(lineTextSplited[j]))
                            {
                                wordsDictionary[lineTextSplited[j]] += 1;
                            }
                        }

                        lineText = fileText.ReadLine();
                    }

                    foreach (var wordCount in wordsDictionary.OrderByDescending(key => key.Value))
                    {
                        fileDestination.WriteLine("{0} - {1}", wordCount.Key, wordCount.Value);
                    }

                    Console.WriteLine("All Done!Please check the file \"result.txt\" to see the result");
                    Console.WriteLine();
                }
            }
        }
    }
}