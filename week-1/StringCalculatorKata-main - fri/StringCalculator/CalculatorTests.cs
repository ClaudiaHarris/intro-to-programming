

using System.Diagnostics.CodeAnalysis;

namespace StringCalculator;
public class CalculatorTests
{
    Calculator calculator = new Calculator();
    [Fact]
    public void EmptyStringReturnsZero()
    {
    
        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("2",2)]

    public void TakeTwoIntegers(string str, int expected)
    {

         var returned = calculator.Add(str);

        Assert.Equal(returned, expected);
    }

    [Theory]
    [InlineData("1,2", 3)]

    public void TakeMoreThanTwoIntegers(string str, int expected)
    {

        var returned = calculator.Add(str);

        Assert.Equal(returned, expected);
    }

    [Theory]
    [InlineData("1,2,3", 6)]
    [InlineData("2,4,6,8", 20)]

    public void TakeManyIntegers(string str, int expected)
    {

        var returned = calculator.Add(str);

        Assert.Equal(returned, expected);
    }



    [Theory]
    [InlineData("//#\n1#2#3", 6)]
    [InlineData("//#\n2,4#6\n8", 20)]

    public void MixedDelimeters(string str, int expected)
    {

        var returned = calculator.Add(str);

        Assert.Equal(returned, expected);
    }

    





}
