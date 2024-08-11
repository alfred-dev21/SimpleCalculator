using System;
using System.ComponentModel;
using System.Numerics;
using System.Text.RegularExpressions;


public class Calculator
{
    private string instruction;
    private readonly string ArithmaticPattern = @"\d+(\.\d+)?\s*[+\-*/]\s*\d+(\.\d+)?";
    private readonly string functionalPattern = @"\b(sqrt|sin|cos|tan)\(\d+(\.\d+)?\)";


    public Calculator(string instruction)
    {
        this.instruction = instruction;
    }

    public Calculator() 
    {
        instruction = "";
    }

    // This is for testing purposes since I will be using a default constructor

    public void SetInstruction(string instruction) 
    {
        this.instruction = instruction;
    }

    public string CalculatorHandler()
    {
        if (Regex.IsMatch(instruction, ArithmaticPattern))
        {
            string[] items = instruction.Split(' ');
            
            switch (items[1])
            {
                case "+":
                    return Add(items[0], items[2]);
                case "-":
                    return Subtraction(items[0], items[2]);
                case "*":
                    return Multiplication(items[0], items[2]);
                default:
                    return Division(items[0], items[2]);
            }
        }
        else if (Regex.IsMatch(instruction, functionalPattern))
        {
            if (instruction.StartsWith("sqrt"))
            {
                instruction = instruction.Replace("sqrt(", "").Replace(")", "");
                return SquareRoot(instruction);
            }
            return "";
        }
        else
        {
            return "";
        }
        
    }

    private string SquareRoot(string instruction)
    {
        double solution = Math.Sqrt(Convert.ToDouble(instruction));
        return Convert.ToString(solution);
    }

    private string Division(string v1, string v2)
    {
        double solution = Convert.ToDouble(v1)/Convert.ToDouble(v2);
        return Convert.ToString(solution);
    }

    private string Multiplication(string v1, string v2)
    {
        double solution = Convert.ToDouble(v1)*Convert.ToDouble(v2);
        return Convert.ToString(solution);
    }

    private string Subtraction(string v1, string v2)
    {
        double solution = Convert.ToDouble(v1) - Convert.ToDouble(v2);
        return Convert.ToString(solution);
    }

    private string Add(string v1, string v2)
    {
        double solution = Convert.ToInt32(v1) + Convert.ToInt32(v2);
        return Convert.ToString(solution);
    }
}