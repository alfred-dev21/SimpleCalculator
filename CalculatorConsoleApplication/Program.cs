using System;

namespace Program
{
    public class Start
    {
        static string help()
        {
            return "How to use the calculator:\n" +
                "   * insure that there is a space between the expression for arithmetic operations such as +,-,* and /\n" +
                "       eg 1+1 is not allowed but 1 + 1 is. For the rest 1 - 1, 1 * 1, 1 / 1\n" +
                "   * insure that there is no space with functional operations cos, tan, sqrt and sin\n" +
                "       eq sin(20) is correct, sqrt(4), etc\n";
        }

        static string message()
        {
            return "CALCULATOR BY ALFRED_DEV21\n" +
                "Instructions:\n" +
                "   - type help to learn how to use the calculator effeciently\n" +
                "Otherwise you can go ahead and use the calculator\n\n" +
                "Insert instruction: ";

        }
        static void Main(string[] args)
        {
            Console.WriteLine(message());

            try
            {
                string instruction = Console.ReadLine();

                while (instruction != "done")
                {
                    Console.WriteLine("Outcome: ");

                    if (instruction == null || instruction.Equals(""))
                    {
                        Console.WriteLine("Insert an expression or command: ");
                    }
                    else if (instruction.ToLower().Equals("help"))
                    {
                        Console.WriteLine(help());
                    }
                    else
                    {
                        Calculator calculator = new(instruction);
                        string solution = calculator.CalculatorHandler();

                        Console.WriteLine(solution);
                    }

                    Console.WriteLine("Insert instruction: ");
                    instruction = Console.ReadLine();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}