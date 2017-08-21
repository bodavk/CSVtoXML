
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XLSCSVtoXML
{
    public class CSVtoXMLConverter
    {
        private StreamReader textReader;

        /// <summary>
        /// Returns xml file from a file located on parsed address
        /// </summary>
        /// <param name="givenFileAddress">address of a CSV file (without @)</param>
        /// <returns>XML file</returns>
        public XElement ConvertCSVtoXML(string givenFileAddress)
        {
            var lines = File.ReadAllLines(@givenFileAddress).ToList();
            var formatedLines = new List<string>();
            foreach (var line in lines)
            {
                var formatedLine = line.TrimEnd(',');
                formatedLines.Add(formatedLine);
            }
            var headers = formatedLines[0].Split(',').Select(x => x.Trim('\"').Replace(" ", string.Empty)).ToArray();
            var xml = new XElement("File",
              formatedLines.Where((line, index) => index > 0).
                  Select(line => new XElement("Item",
                     line.Split(',').Select((field, index) => new XElement(headers[index], field)))));
            return xml;
        }
        
    }
}
