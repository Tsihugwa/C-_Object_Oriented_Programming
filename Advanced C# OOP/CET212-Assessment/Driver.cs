using System;

namespace CET212_Assessment
{
    //tthis class holds the driver's journey details except the name
    public class Driver
    {
        //declare variables
        public String CollectionAddress { get; }
        public DateTime JourneyDate { get; }
        
        public Double JourneyDistance { get; }
        public String DeliveryAddress { get; }
        

        public Driver( String collectionAddress, DateTime journeyDate, Double journeyDistance, String deliveryAddress)
        {           
           
        }
        //Driver method with parameters
        public Driver(DateTime journeyDate, string collectionAddress, string deliveryAddress, double journeyDistance)
        {
            JourneyDate = journeyDate;
            CollectionAddress = collectionAddress;
            DeliveryAddress = deliveryAddress;
            JourneyDistance = journeyDistance;
        }

        
        //to string method
        public override string ToString()
        {
            return string.Format("Journey Date{0} \r\n Collection Address{1} \r\n Delivery Address{2} \r\n Distance{3}", this.JourneyDate.ToShortDateString(), this.CollectionAddress, this.DeliveryAddress, this.JourneyDistance);
        }
    }
}
