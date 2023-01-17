using System;

class CountADS
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();

        int alphabetCount = 0;
        int digitCount = 0;
        int specialCharCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (Char.IsLetter(input[i]))
            {
                alphabetCount++;
            }
            else if (Char.IsDigit(input[i]))
            {
                digitCount++;
            }
            else if (!Char.IsWhiteSpace(input[i]))
            {
                specialCharCount++;
            }
        }

        Console.WriteLine("Alphabet count: " + alphabetCount);
        Console.WriteLine("Digit count: " + digitCount);
        Console.WriteLine("Special character count: " + specialCharCount);
    }
}
