

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("3", 3)]

    public void CanAddASingleNumber(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add("");
        Assert.Equal(0, result);
    }
    //nos. 2 and 3 and so on
    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("1,2,3", 6)]
    [InlineData("1,2,3,4,5,6,7,8,9", 45)]
    [InlineData("1\n2", 3)]
    [InlineData("1\n2,3", 6)]
    [InlineData("//#\n1#2#3",6)]
    [InlineData("//#\n1#2,3\n1", 7)]

    public void CanAddTwoNumbers(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }

    

}
