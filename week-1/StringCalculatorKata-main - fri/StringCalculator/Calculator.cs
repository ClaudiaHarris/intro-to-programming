
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Calculator
{
    public int Add(string numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return 0;
        }





        if (numbers.StartsWith("//"))
        {
            char delimeter = numbers[2];


            int number = numbers.Split(delimeter, '\n', ',')
                 .Select(int.Parse)
                 .Sum();

            return number;
        }
        
        int item = numbers.Split('\n', ',')
              .Select(int.Parse)
              .Sum();

        return item;

    }

}
