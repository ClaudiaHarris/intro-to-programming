
public class Calculator
{
    public int Add(string numbers)
    {
        List<char> delimiters = [',', '\n'];

        if (numbers == "")
        {
            return 0;
                           
        }
            
        if (numbers.StartsWith("//"))
        {
            var delimiter = numbers[2];
            delimiters.Add(delimiter);
            numbers = numbers[4..];
        }

        return numbers.Split([.. delimiters]) //string[]

           
                .Select(int.Parse) //makes int array
                .Sum();

    }
}
