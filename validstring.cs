
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string containing dates as MMDDYYYY :");
        string input = Console.ReadLine();

       
        string pattern = @"\b(0[1-9]|1[0-2])(0[1-9]|[12][0-9]|3[01])(\d{4})\b";

        MatchCollection matches = Regex.Matches(input, pattern);

        
        Console.WriteLine("\nDates found in the string:");
        foreach (Match match in matches)
        {
            string dateStr = match.Value;
            if (IsValidDate(dateStr))
            {
                Console.WriteLine(dateStr);
            }
        }
    }

   
    static bool IsValidDate(string dateStr)
    {
        if (dateStr.Length != 8)
        {
            return false;
        }

        string monthStr = dateStr.Substring(0, 2);
        string dayStr = dateStr.Substring(2, 2);
        string yearStr = dateStr.Substring(4, 4);

        if (!int.TryParse(monthStr, out int month) || month < 1 || month > 12)
        {
            return false;
        }

        if (!int.TryParse(dayStr, out int day) || day < 1 || day > DateTime.DaysInMonth(int.Parse(yearStr), month))
        {
            return false;
        }

        if (!int.TryParse(yearStr, out int year) || year < 1)
        {
            return false;
        }

        return true;
    }
}
