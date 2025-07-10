

namespace StringCalculator;
public class CalculatorTests
    
{
    private Calculator _calculator = new();

    [Fact]
    public void EmptyStringReturnsZero()
    {
        

        var result = _calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1",1)]
    [InlineData("2",2)]
    [InlineData("23",23)]
    public void CanAddSingleInteger(string numbers, int expected)
    {
        
        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("2,2", 4)]
    [InlineData("12,10", 22)]

    public void CanAddTwoNumbers(string numbers, int expected)
    {
        
        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n2", 3)]

    public void NewLineDelimiter(string numbers, int expected)
    {

        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }


    [Theory]
    [InlineData("//;\n1;2", 3)]
    [InlineData("//;\n1;4", 5)]
    [InlineData("//*\n1*2", 3)]

    public void CustomDelimiters(string numbers, int expected)
    {

        var result = _calculator.Add(numbers);
        Assert.Equal(expected, result);
    }
}
 