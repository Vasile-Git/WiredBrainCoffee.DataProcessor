using System.Data;

namespace WiredBrainCoffee.DataProcessor.Parsing;

public class CsvLineParserTests
{
    [Fact]
    public void ShouldParseValidLine()
    {
        // Arrange
        string[] csvLines = new[] { "Cappuccino;23-10-2022 8:06:04 AM" };

        // Act
        var machineDataItems = CsvLineParser.Parse(csvLines);

        //Assert
        Assert.NotNull(machineDataItems);
        Assert.Single(machineDataItems);
        Assert.Equal("Cappuccino", machineDataItems[0].CoffeeType);
        Assert.Equal(new DateTime(2022, 10, 23, 8, 6, 4), machineDataItems[0].CreatedAt);
    }

    [Fact]
    public void ShouldSkipEmptyLines()
    {
        // Arrange
        string[] csvLines = new[] { "" };

        // Act
        var machineDataItems = CsvLineParser.Parse(csvLines);

        //Assert
        Assert.NotNull(machineDataItems);
        Assert.Empty(machineDataItems);
    }

    [InlineData("Cappuccino", "Invalid csv line")]
    [InlineData("Cappuccino;InvalidDateTime", "Invalid dateTime in csv line")]
    [Theory]
    public void ShouldThrowExceptionForInvalidLine(string csvLine, string expectedMessagePrefix)
    {
        // Arrange
        var csvLines = new[] { csvLine };

        // Act and Assert
        var exception = Assert.Throws<Exception>(() => CsvLineParser.Parse(csvLines));
        Assert.Equal($"{expectedMessagePrefix}: {csvLine}", exception.Message);
    }
}