using System;

class Reverse
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence: ");
        string input = Console.ReadLine();

        
        char[] modifiedSentence = input.ToCharArray();
        for (int i = 0; i < modifiedSentence.Length; i++)
        {
            if (Char.IsLower(modifiedSentence[i]))
            {
                modifiedSentence[i] = Char.ToUpper(modifiedSentence[i]);
            }
            else if (Char.IsUpper(modifiedSentence[i]))
            {
                modifiedSentence[i] = Char.ToLower(modifiedSentence[i]);
            }
        }

        
        Console.WriteLine(modifiedSentence);
    }
}