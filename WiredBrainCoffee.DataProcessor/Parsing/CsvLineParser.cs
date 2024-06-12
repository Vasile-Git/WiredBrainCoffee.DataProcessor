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

            string[] formats = { "MM/dd/yyyy h:mm:ss tt", "dd-MM-yyyy h:mm:ss tt" };
            if (!DateTime.TryParseExact(lineItems[1], formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTime))
            {
                throw new Exception($"Invalid dateTime: {csvLine}");
            }


            return new MachineDataItem(lineItems[0], dateTime);
        }
    }
}
