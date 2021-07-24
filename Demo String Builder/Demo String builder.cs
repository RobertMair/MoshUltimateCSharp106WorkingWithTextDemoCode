using System;
using System.Text;

namespace Demo_String_Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            var builder = new StringBuilder("Hello World");

            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);
            Console.WriteLine(builder);
            
            Console.WriteLine();
            
            builder
                .Replace('-', '*')
                .Remove(0, 10);
            Console.WriteLine(builder);

            Console.WriteLine();

            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            Console.WriteLine("First char: " + builder[0]);

            Console.WriteLine("\nPress any key to exit program.");
            Console.ReadKey();
        }
    }
}
