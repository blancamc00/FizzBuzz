using System.Collections;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string print = "";
            
            Console.WriteLine("Enter maximum number: ");
            string maxString = Console.ReadLine();
            int max = int.Parse(maxString);
            
            Console.WriteLine("Indicate which commands you would like to implement, " + 
                              "writing the numbers separated by a space");
            string allCommands = Console.ReadLine();
            string[] commandArray = allCommands.Split(" ");
            List<int> listCommands = new List<int>();

            foreach (string command in commandArray)
            {
                listCommands.Add(int.Parse(command));
            }


            for (int i = 1; i <= max; i++)
            {
                List<int> rulesThatApply = Program.rulesThatApply(i,listCommands);
                print = "";
                if (rulesThatApply.Contains(3)) print += "Fizz";
                if (rulesThatApply.Contains(5)) print += "Buzz";
                if (rulesThatApply.Contains(7)) print += "Fizz";
                if (rulesThatApply.Contains(11)) print = "Bong";
                if (rulesThatApply.Contains(13)) ruleFezz(print);


                if (i % 3 != 0 && i % 13 == 0) print += "Fezz";
                if (i % 5 == 0) print += "Buzz";
                if (i % 7 == 0) print += "Bang";
                if (i % 11 == 0) 
                {
                    
                    print = "Bong";
                    if (i % 13 == 0) //print = Array.Reverse(Array.Reverse(print.Append(Fezz)));
                    {
                        print = "Fezz" + print;
                    }
                }
                if (i % 17 == 0)
                {
                    print.Reverse();
                }
                if (print == "") Console.WriteLine(i);
                else Console.WriteLine(String.Join("",print));
            }
            
        }

        private static List<int> rulesThatApply(int number, List<int> listCommands)
        {
            List<int> rules = new List<int>();
            for (int i = 0; i < listCommands.Count; i++)
            {
                if (number % listCommands[i] == 0)
                {
                    rules.Add(listCommands[i]);
                }
            }

            return rules;
        }

        private static string ruleFezz(string print)
        {
            string[] twoParts = print.Split("B", 2);
            if (twoParts.Length == 2) return twoParts[0] + "Fezz" + twoParts[1];
            else {return print + "Fezz";}
        }
        
    }
}