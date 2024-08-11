using System;

namespace Program
{
    public class Start
    {
        static string help()
        {
            return "";
        }
        static string message()
        {
            return "CALCULATOR BY ALFRED_DEV21\n" +
                "Instructions:\n" +
                "   - type help to learn how to use the calculator effeciently\n\n" +
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