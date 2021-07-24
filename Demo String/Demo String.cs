using System;

namespace Demo_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Rob Mair ";
            Console.WriteLine("Trim   : '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index+1);

            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName : " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName Array: " + names[0]);
            Console.WriteLine("LastName Array : " + names[1]);

            Console.WriteLine(fullName.Replace("Rob", "Robert"));
            
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            // String to number.
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine("Age: " + age);

            // Number to string.
            float price = 29.95f;
            Console.WriteLine("Amount : " + price.ToString("c"));
            Console.WriteLine("Rounded: " + price.ToString("C0"));

            Console.WriteLine("Press any key to exit program.");
            Console.ReadKey();
        }
    }
}
