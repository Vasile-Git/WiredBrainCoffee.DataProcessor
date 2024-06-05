using System.Globalization;
using System.Runtime.InteropServices.JavaScript;
using WiredBrainCoffee.DataProcessor.Model;

namespace WiredBrainCoffee.DataProcessor.Parsing
{
    public class CsvLineParser
    {
        public static MachineDataItem[] Parse(string[] csvlines)
        {
            var machineDataItems = new List<MachineDataItem>();

            foreach (var csvLine in csvlines)
            {
                if (string.IsNullOrEmpty(csvLine))
                {
                    continue;
                }
                var machineDataItem = Parse(csvLine);

                machineDataItems.Add(machineDataItem);
            }

            return machineDataItems.ToArray();
        }

        private static MachineDataItem Parse(string csvLine)
        {
            var lineItems = csvLine.Split(';');

            if (lineItems.Length != 2)
            {
                throw new Exception($"Invalid csv line: {csvLine}");
            }

            if (!DateTime.TryParse(lineItems[1], out DateTime dateTime))
            //if (!DateTime.TryParseExact(lineItems[1], "dd-MM-yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTime))
            {
                throw new Exception($"Invalid dateTime in csv line: {csvLine}");
            }

            return new MachineDataItem(lineItems[0], dateTime);
        }
    }
}
