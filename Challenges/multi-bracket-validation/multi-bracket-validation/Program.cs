using System;
using System.Text.RegularExpressions;

namespace multi_bracket_validation
{
    class Program
    {
        static void Main(string[] args)
        {

            // Test cases
            // Should return true
            string candidate1 = "{}";
            string candidate2 = "()[[Extra Characters]]";
            string candidate3 = "(){}[[]]";
            string candidate4 = "{}{Code}[Fellows](())";

            // Should return false
            string candidate5 = "(((((";

            Console.WriteLine("Multi-Bracket Validation");

            Console.WriteLine($"{candidate1} is {Validate(candidate1)}, should be true");
            Console.WriteLine($"{candidate2} is {Validate(candidate2)}, should be true");
            Console.WriteLine($"{candidate3} is {Validate(candidate3)}, should be true");
            Console.WriteLine($"{candidate4} is {Validate(candidate4)}, should be true");
            Console.WriteLine();
            Console.WriteLine($"{candidate5} is {Validate(candidate5)}, should be false");

            Console.ReadLine();

        }

        public static bool Validate(string candidate)
        {
            candidate.ToCharArray();
            string character = "";

            // Declare a node
            Node node = new Node();

            // Instantiate the stack
            Stack stack = new Stack(node);

            // Iterate through candidate

            //Regex open = new Regex(@"/ [/(/{/[]/ g");
            //Regex close = new Regex(@"/ [/)/}/]]/ g");

            for (int i = 0; i < candidate.Length; i++)
            {
                character = candidate[i].ToString();
                Console.WriteLine($"Character: {character}");
                if (character == "{" || character=="(" || character == "[")
                {
                    // Open bracket character found
                    // push character to stack
                    node.Value = character;
                    Stack.Push(node);
                }
                else if (character == "}" || character == ")" || character == "]")
                {
                    // Close bracket character found
                    // pop a character from the stack
                    node = Stack.Pop();
                    // if bracket character is not its mate, return false
                    if ((node.Value == "{" && character == "}") || (node.Value == "(" && character == ")") || (node.Value == "[" && character == "]"))
                    {
                        // True condition, do nothing
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            // Check to see if stack is empty.  If it is not, return false.
            Console.WriteLine($"At end of iteration, Stack.Peek().Value: {Stack.Peek().Value}");
            if (null != Stack.Peek().Value)
                return false;

            return true; // if return false hasn't been reached by this point, string must be balanced.


        }
    }
}
