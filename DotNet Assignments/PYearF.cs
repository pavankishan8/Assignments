using System;
using System.Globalization;

class PYearF
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a date (dd/mm/yyyy): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        
        Console.WriteLine("Dates of the past 15 years:");
        for (int i = -15; i < 0; i++)
        {
            Console.WriteLine(date.AddYears(i).ToString("dd/MM/yyyy"));
        }


        Console.WriteLine("Current date: " + date.ToString("dd/MM/yyyy"));


        Console.WriteLine("Dates of the next 15 years:");
        for (int i = 1; i <= 15; i++)
        {
            Console.WriteLine(date.AddYears(i).ToString("dd/MM/yyyy"));
        }
    }
}

