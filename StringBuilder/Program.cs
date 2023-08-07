using System;
using System.Text;
namespace StringBuilder01
{
    class Program
    {

        static void Main(string[] args)
        {
            string s1 = "this is an example off ";
            s1=s1 + "string concatenation";
            Console.WriteLine(s1);
            Console.WriteLine("==========================================");

            StringBuilder sb2 = new StringBuilder("this is an example off ");
            sb2.Append("string concatenation");
            Console.WriteLine(sb2);
            Console.WriteLine("==========================================");

            sb2.AppendLine();
            sb2.Append("using stringbuilder...");
            Console.WriteLine(sb2);
            Console.WriteLine("==========================================");

            sb2.Replace("stringbuilder", "the StringBuilder class...");
            Console.WriteLine(sb2);
            Console.WriteLine("==========================================");  
        }

    }


}