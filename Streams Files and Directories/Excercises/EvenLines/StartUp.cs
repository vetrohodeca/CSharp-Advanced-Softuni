using System;
using System.Linq;
using System.Text;
using System.IO;
namespace EvenLines
{
    class StartUp
    {
        static string Replace(string line, char symbol, char[] charsToReplace)
        {
            StringBuilder sb = new StringBuilder();
            for(int i=0;i<line.Length;i++)
            {
                if(charsToReplace.Contains (line[i]))
                {
                    sb.Append ('@');
                }
                else
                {
                    sb.Append(line[i]);
                }
            }
            return sb.ToString().TrimEnd();
        }
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("./text.txt");
            bool evenLine=true;
            char[] charsToReplace = { '-', ',', '?', '!', '.' };
            while(!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                if(line==null)
                {
                    break;
                }
                if(evenLine==true)
                {
                    line= Replace(line, '@', charsToReplace);
                    line=string.Join(" ",line.Split(' ').Reverse());
                    Console.WriteLine(line);
                }
                evenLine = !evenLine;
            }
        }
    }
}
