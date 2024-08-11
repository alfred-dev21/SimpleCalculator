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
            return "CALCULATOR BY ALFRED_DEV21" +
                "Instructions:" +
                "   - type help to learn how to use the calculator effeciently";

        }
        static void Main(string[] args)
        {
            Console.WriteLine(message());

            try
            {
                string instruction = Console.ReadLine();

                while (instruction != "done")
                {
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
                        Calculator calculator = new Calculator(instruction);
                        string solution = calculator.CalculatorHandler();

                        Console.WriteLine(solution);
                    }

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