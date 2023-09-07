using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace CET212_Assessment
{
    public class XMLJourneyFileReader : IJourneyFileReader
    {
        public Journey ReadJourneyDataFromFile(ConfigRecord configRecord)
        {
            // Open the file to read from on the local file system, if this file is missing then return
            // immediately from this method
            if (!File.Exists(configRecord.Filename))
            {
                // Cannot open the file as it does not exist for whatever reason, so return immediately.
                return null;
            }

            // Open file and load into memory as XML
            XDocument xmlDoc = XDocument.Load(configRecord.Filename);

            // Create driver (should only be one in file but retrieve first to be sure)
            var driverElement = xmlDoc.Descendants("Driver").FirstOrDefault();
            if (driverElement == null)
            {
                // Driver element not found in the XML file
                return null;
            }

            string driverName = driverElement.Attribute("name")?.Value;
            if (string.IsNullOrEmpty(driverName))
            {
                // Driver name attribute not found or is empty
                return null;
            }

            Journey journey = new Journey(driverName);

            // Obtain journeys from this driver
            var journeys = driverElement.Descendants("Journey");
            foreach (var journeyElement in journeys)
            {
                var dateValue = journeyElement.Attribute("date")?.Value;
                DateTime date;
                if (!DateTime.TryParse(dateValue, out date))
                {
                    // Invalid or missing date value in the XML file
                    continue;
                }

                var collectionValue = journeyElement.Element("Collection")?.Value;
                if (string.IsNullOrEmpty(collectionValue))
                {
                    // Collection element not found or is empty
                    continue;
                }

                var deliveryValue = journeyElement.Element("Delivery")?.Value;
                if (string.IsNullOrEmpty(deliveryValue))
                {
                    // Delivery element not found or is empty
                    continue;
                }

                var distanceValue = journeyElement.Element("Distance")?.Value;
                double distance;
                if (!double.TryParse(distanceValue, out distance))
                {
                    // Invalid or missing distance value in the XML file
                    continue;
                }

                Driver driver = new Driver(date, collectionValue, deliveryValue, distance);
                journey.Drivers.Add(driver);
            }

            return journey;
        }
    }
}

