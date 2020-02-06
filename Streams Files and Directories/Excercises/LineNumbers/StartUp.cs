using System;
using System.IO;
using System.Linq;
namespace LineNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"./text.txt");
            for(int i=0;i<lines.Length;i++)
            {
                string currentLine = lines[i];
                int letters = countOfLetters(currentLine);
                int marks = countOfPunctuationalMarks(currentLine);
                lines[i]=$"Line {i+1}: {currentLine} ({letters})({marks})";
            }
            File.WriteAllLines("../../../output.txt", lines);
        }
        static int countOfLetters(string line)
        {
            int counter=0;
            for(int i=0;i<line.Length;i++)
            {
                if(char.IsLetter(line[i]))
                {
                    counter++;
                }
            }
            return counter;
        }
        static int countOfPunctuationalMarks(string line)
        {
            char[] marks = { '.', ',', '!', '?', '-' };
            int counter=0;
            {
                for(int i=0;i<line.Length;i++)
                {
                    if(marks.Contains(line[i]))
                    {
                        counter++;
                    }
                }
                return counter;
            }
        }
    }
}
