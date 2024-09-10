using System;
using System.Runtime.InteropServices;
using Xunit;
using Xunit.Sdk;

namespace LoggingKata.Test
{
    public class TacoParserTests

    {
    [Fact]
    public void ShouldReturnNonNullObject()
    {
        //Arrange
        var tacoParser = new TacoParser();

        //Act
        var actual = tacoParser.Parse("31.597099,-84.176122,Taco Bell Albany...");

        //Assert
        Assert.NotNull(actual);

    }

    [Theory]
    [InlineData("34.376395,-84.913185,Taco Bell Adairsvill...",-84.913185 )]
    [InlineData("31.570771,-84.10353,Taco Bell Albany...",-84.10353 )]
    [InlineData("31.597099,-84.176122,Taco Bell Albany...",-84.176122)]
    [InlineData("34.071477,-84.296345,Taco Bell Alpharett...", -84.296345)]
    //Add additional inline data. Refer to your CSV file.
    public void ShouldParseLongitude(string line, double expected)
    {
        // TODO: Complete the test with Arrange, Act, Assert steps below.
        //       Note: "line" string represents input data we will Parse 
        //       to extract the Longitude.  
        //       Each "line" from your .csv file
        //       represents a TacoBell location

        //Arrange
        var longitude = new TacoParser();

        //Act
        var actual = longitude.Parse(line);

        //Assert
        Assert.Equal(expected, actual.Location.Longitude);
    }


    //TODO: Create a test called ShouldParseLatitude


    [Theory]
    [InlineData("34.376395,-84.913185,Taco Bell Adairsvill...", 34.376395)]
    [InlineData("31.570771,-84.10353,Taco Bell Albany...", 31.570771)]
    [InlineData("31.597099,-84.176122,Taco Bell Albany...", 31.597099)]
    [InlineData("34.071477,-84.296345,Taco Bell Alpharett...", 34.071477)]

    public void ShouldParseLatitude(string line, double expected)
    {
        //Arrang
        var latitude = new TacoParser();

        //Act
        var actual = latitude.Parse(line);

        //Assert
        Assert.Equal(expected, actual.Location.Latitude);
    }

    }
}
