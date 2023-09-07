using System;
using System.Collections.Generic;
using System.Linq;

namespace CET212_Assessment
{
    public class JourneyList
    {
        //Declare objects
        public List<Journey> Journeys { get; }
        //Create method for the class
        public JourneyList()
        {
            this.Journeys = new List<Journey>();
            
        }

        //method to calculate total distance per date
        public List<String> CalculateTotalDistancesPerDate()
        {
            //declare variables
            var datesDistanceList = new List<string>();
            //get values from the lists and calculate distances per date
            var dateTotals =
                from journey in this.Journeys
                from driver in journey.Drivers
                group driver by driver.JourneyDate into dates
                let totalDistance = (from driv in dates select (double)driv.JourneyDistance).Sum()
                orderby dates.Key descending
                select new
                {

                    Date = dates.Key,
                    TotalDistance = totalDistance
                };

            foreach (var d in dateTotals)
            {
                datesDistanceList.Add(String.Format("{0}: {1} miles", d.Date, d.TotalDistance));
            }
            return datesDistanceList;
        }

        //method to get longest journey
        public Tuple<string, DateTime, double> GetLongestJourney(JourneyList journeyList)
        {
            var longestJourney = journeyList.Journeys
                .SelectMany(journey => journey.Drivers.Select(driver => new { Journey = journey, Driver = driver }))
                .OrderByDescending(journeyAndDriver => journeyAndDriver.Driver.JourneyDistance)
                .FirstOrDefault();
            //run through list to get all values
            if (longestJourney == null)
            {
                return null;
            }
            //return values
            return Tuple.Create(
                longestJourney.Journey.DriverName,
                longestJourney.Driver.JourneyDate,
                longestJourney.Driver.JourneyDistance);
        }


        //method to get drivers alphabetically and total distances covered
        public List<string> GetDriversAlphabetically()
        {
            var driverDistanceRecord = new List<string>();

            var driverDistances =
                from journey in this.Journeys
                from driver in journey.Drivers
                group driver by journey.DriverName into driverGroup
                let totalDistance = (from driv in driverGroup select (double)driv.JourneyDistance).Sum()
                orderby driverGroup.Key ascending
                select new
                {
                    DriverName = driverGroup.Key,
                    TotalDistance = totalDistance
                };

            //run through list to get all values
            foreach (var d in driverDistances)
            {
                driverDistanceRecord.Add(String.Format("{0}: {1} miles", d.DriverName, d.TotalDistance));
            }
            //return values
            return driverDistanceRecord;
        }


    }
}
