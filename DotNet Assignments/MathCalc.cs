using System;

class MathCalc
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter an operator (+, -, *, /): ");
            string op = Console.ReadLine();

            double result = 0;

            if (op == "+")
                result = num1 + num2;
            else if (op == "-")
                result = num1 - num2;
            else if (op == "*")
                result = num1 * num2;
            else if (op == "/")
                result = num1 / num2;
            else
                Console.WriteLine("Invalid operator.");

            Console.WriteLine("Result: " + result);

            Console.WriteLine("Do you want to perform another operation? (yes/no)");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "no")
                break;
        }
    }
}
