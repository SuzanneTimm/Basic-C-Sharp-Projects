using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1 = "I am a huge fan of movies, ";
            String str2 = "pizza, ";
            String str3 = "and beer.";

            var str = String.Concat(str1, str2, str3);
            Console.WriteLine(str);           

            str = str.ToUpper();
            Console.WriteLine(str);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This is the first line of text.");
            sb.AppendLine("This is the second line of text.");
            sb.AppendLine("This is the third line of text.");
            sb.AppendLine("This is the fourth line of text.");
            sb.AppendLine("This is the fifth line of text.");
            sb.Append(123);
            sb.AppendLine();

            string result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}
