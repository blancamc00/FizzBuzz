using System.Collections;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] print = new string[0];
            
            Console.WriteLine("Enter maximum number: ");
            string maxString = Console.ReadLine();
            int max = int.Parse(maxString);
            
            for (int i = 1; i <= max; i++)
            {
                if (i % 3 == 0)
                {
                    print.Append(Fizz);
                    if (i % 13 == 0) print.Append(Fezz);
                }

                if (i % 3 != 0 && i % 13 == 0) print.Append(Fezz);
                if (i % 5 == 0) print.Append(Buzz);
                if (i % 7 == 0) print.Append(Bang);
                if (i % 11 == 0) 
                {
                    Array.Clear(print, 0, print.Length);
                    print.Append(Bong);
                    if (i % 13 == 0) //print = Array.Reverse(Array.Reverse(print.Append(Fezz)));
                    {
                        Array.Reverse(print);
                        print.Append(Fezz);
                        Array.Reverse(print);
                    }
                }
                if (i % 17 == 0)
                {
                    print.Reverse();
                }
                if (print.Length == 0) Console.WriteLine(i);
                else Console.WriteLine(String.Join("",print));
            }
        }
    }
}