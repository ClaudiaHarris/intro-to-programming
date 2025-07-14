
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Calculator
{
    public int Add(string numbers)

    {
        List<char> delimeters = [',', '\n'];

        if (numbers == "")
        {
            return 0;
        }

        if (HasCustomDelimeters(numbers))
        {
            var delimeter = numbers[2];
            delimeters.Add(delimeter);
            numbers = numbers[4..];
        }




        var response = numbers.Split([..delimeters])
              .Select(int.Parse)
              .Sum();

        return response;

    }
    private bool HasCustomDelimeters(string numbers)
    {
        return numbers.StartsWith("//");
    }

}
