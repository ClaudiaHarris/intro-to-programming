
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

public class Calculator
{
    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }
        string[] delimiters = { ",", "\n" };

        if (numbers.StartsWith("//"))
        {
            int delimiterInator = numbers.IndexOf("\n");
            string customDelimiter = numbers.Substring(2, delimiterInator - 2);
            delimiters = new string[] { customDelimiter, ",", "\n" };
            numbers = numbers.Substring(delimiterInator + 1);
        }

        var numberArray = numbers.Split(delimiters, StringSplitOptions.None);
        int sum = 0;

        foreach (var num in numberArray)
        {
            if (!string.IsNullOrEmpty(num))
            {
                sum += int.Parse(num);
            }
        }

        
       return sum;
    }
}
