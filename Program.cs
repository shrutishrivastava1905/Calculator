using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("=== Simple Calculator ===");

        // Taking first number
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Taking second number
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Choosing operation
        Console.WriteLine("Choose operation: +  -  *  /");
        char op = Convert.ToChar(Console.ReadLine());

        double result = 0;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '*':
                result = num1 * num2;
                break;

            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero!");
                    return;
                }
                break;

            default:
                Console.WriteLine("Invalid operator!");
                return;
        }

        Console.WriteLine("Result = " + result);
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}