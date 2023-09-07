using System;
using System.Collections.Generic;

namespace CET212_Assessment
{
    public class Journey
    {
        //Declare varibales and list objects
        public String DriverName { get; }
        public List<Driver> Drivers { get; }
        //Method for the Journey Class 
        public Journey(String driverName)
        {
            this.DriverName = driverName;
            this.Drivers = new List<Driver>();
        }
        //to string method
        public override string ToString()
        {
            return String.Format("Journey: {0}", this.DriverName);
        }
    }
}
