using WiredBrainCoffee.DataProcessor.Model;

namespace WiredBrainCoffee.DataProcessor.Processing;

public class MachineDataProcessorTests
{
    [Fact]
    public void ShouldSaveCountPerCoffeeType()
    { 
        // Arrange
        var machineDataProcessor = new MachineDataProcessor();
        var items = new[]
        {
            new MachineDataItem("Cappuccino", new DateTime(2022, 10, 27, 8, 6, 4)),
            new MachineDataItem("Cappuccino", new DateTime(2022, 10, 27, 9, 7, 4)),
            new MachineDataItem("Espresso", new DateTime(2022, 10, 27, 10, 8, 4))
        };

        // Act
        machineDataProcessor.ProcessItems(items);

        // Assert

    }
}
