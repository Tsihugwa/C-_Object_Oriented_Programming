using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CET212_Assessment
{
    public interface IUserInterface
    {
        //declare the interface methods
        void SetupConfigData();
        void RunProducerConsumer();
        void DisplayDrivers();
        void DisplayDates();
        void DisplayLongestJourney();
        void DisplayDriverJourneys();
        void DisplayDriverDetails();

    }
}
