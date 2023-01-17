using System;
using System.Linq;

class StringReverse
{
    public static string reverseByWords(string sentence)
    {
        string[] words = sentence.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }

    public static void Main(string[] args)
    {
        string show = reverseByWords("My name is Pavan R and I live in Bangalore");
        Console.WriteLine(show);
        
    }
}

