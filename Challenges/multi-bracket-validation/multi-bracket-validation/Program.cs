using System;
using System.Text.RegularExpressions;

namespace multi_bracket_validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Test cases
            // Should return true
            string candidate1 = "{}";
            string candidate2 = "()[[Extra Characters]]";
            string candidate3 = "(){}[[]]";
            string candidate4 = "{}{Code}[Fellows](())";

            // Should return false
            string candidate5 = "(]";

            Console.WriteLine("Multi-Bracket Validation");

            Console.WriteLine($"{candidate1} is {Validate(candidate1)}");
            Console.WriteLine($"{candidate2} is {Validate(candidate2)}");
            Console.WriteLine($"{candidate3} is {Validate(candidate3)}");
            Console.WriteLine($"{candidate4} is {Validate(candidate4)}");
            Console.WriteLine($"{candidate5} is {Validate(candidate5)}");

        }

        public static bool Validate(string candidate)
        {
            candidate.ToCharArray();
            char character = new char();

            // Declare a node
            Node node = new Node();

            // Instantiate the stack
            Stack stack = new Stack(node);

            // Iterate through candidate
            // need to filter a regular expresson for / [/(/{/[/]/}/)]/ g

            Regex open = new Regex(@"/ [/(/{/[]/ g");
            Regex close = new Regex(@"/ [/)/}/]]/ g");

            for (int i = 0; i < candidate.Length; i++)
            {
                character = candidate[i];
                if ((character == "{".ToChar()) || (character == "[") || character == "("))
                {
                    // Open bracket
                }
            }


        }
    }
}
