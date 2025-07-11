


public class Calculator(ILogger _logger)
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

        var response = numbers.Split([.. delimiters]) //string[]

           
                .Select(int.Parse) //makes int array
                .Sum();
        //log this sucker out

        _logger.Write(response.ToString());
        return response; 

    }

    private bool HasCustomDelimeters(string numbers)
    {
        return numbers.StartsWith("//");
    }

}
