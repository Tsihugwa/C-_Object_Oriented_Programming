using System;
using System.Threading;
using System.Windows.Forms;

namespace CET212_Assessment
{
    public partial class Form1 : Form, IUserInterface
    {
        public IJourneyFileReader IOhandler { get; }
        private ConfigData configData;
        private JourneyList journeyList;

        public Form1(IJourneyFileReader IOhandler)
        {
            InitializeComponent();
            this.IOhandler = IOhandler;
        }

        public void SetupConfigData()
        {
            // Make sure configData is a new empty object
            configData = new ConfigData();

            // Generate configuration data using filename for each constituency XML file - note: the actual
            // XML files must be located in the bin/Debug folder of the project (so they can be found)
            configData.configRecords.Add(new ConfigRecord("Journey1.xml"));
            configData.configRecords.Add(new ConfigRecord("Journey2.xml"));
            configData.configRecords.Add(new ConfigRecord("Journey3.xml"));
            configData.configRecords.Add(new ConfigRecord("Journey4.xml"));
            configData.configRecords.Add(new ConfigRecord("Journey5.xml"));
            configData.configRecords.Add(new ConfigRecord("Journey6.xml"));
        }

        public void RunProducerConsumer()
        {
            //Create constituency list to hold individual Constituency objects read from XML files
            journeyList = new JourneyList();

            // Create progress manager with number of files to process
            var progManager = new ProgressManager(configData.configRecords.Count);

            // Create a PCQueue instance, give it a capacity of 4
            var pcQueue = new PCQueue(4);

            // Create 2 Producer instances and 2 Consumer instances, these will begin executing on
            // their respective threads as soon as they are instantiated
            Producer[] producers = { new Producer("P1", pcQueue, configData, IOhandler),
                                     new Producer("P2", pcQueue, configData, IOhandler) };

            Consumer[] consumers = { new Consumer("C1", pcQueue, journeyList, progManager),
                                     new Consumer("C2", pcQueue, journeyList, progManager) };

            // Keep producing and consuming until all work items are completed
            while (progManager.ItemsRemaining > 0) ;

            // Deactivate the PCQueue so it does not prevent waiting producer and/or consumer threads
            // from completing
            pcQueue.Active = false;

            // Iterate through consumers and signal them to finish
            foreach (var c in consumers)
            {
                c.Finished = true;
            }

            // Wait for all consumers to finish
            while (Consumer.RunningThreads > 0)
            {
                lock (pcQueue)
                {
                    // Pulse the PCQueue to signal any waiting threads
                    Monitor.Pulse(pcQueue);
                }
            }

            // Iterate through producers and signal them to finish
            foreach (var p in producers)
            {
                p.Finished = true;
            }

            // Wait for all producers to finish
            while (Producer.RunningThreads > 0)
            {
                lock (pcQueue)
                {
                    // Pulse the PCQueue to signal any waiting threads
                    Monitor.Pulse(pcQueue);
                }
            }
        }
        //method to diaplay drivers
        public void DisplayDrivers()
        {

            DriversListBox.Items.Clear();
            foreach (var journey in journeyList.Journeys)
            {
                DriversListBox.Items.Add(journey);
            }
        }
        //method to display journeys
        public void DisplayDriverJourneys()
        {

            ListOfDriversAndTotalDistanceListBox.Items.Clear();

            foreach(var driverTotalDistance in journeyList.GetDriversAlphabetically())
            {
                ListOfDriversAndTotalDistanceListBox.Items.Add(driverTotalDistance);
            }
        }
        //method to display longest journey
        public void DisplayLongestJourney()
        {
            // Get the longest journey from the journey list
            var longestJourney = journeyList.GetLongestJourney(journeyList);

            if (longestJourney != null)
            {
                // Set the label text to display the driver name, journey date and distance
                LongestDistancelbl.Text = string.Format("Driver: {0}\nDate: {1}\nDistance: {2} miles", longestJourney.Item1, longestJourney.Item2, longestJourney.Item3);
            }
            else
            {
                // If there is no longest journey, set the label text to display a message
                LongestDistancelbl.Text = "No journey found.";
            }
        }
        //method to display dates
        public void DisplayDates()
        {
            DatesWithTotalDistancesListBox.Items.Clear();

            foreach(var journeyDate in journeyList.CalculateTotalDistancesPerDate())
            {
                DatesWithTotalDistancesListBox.Items.Add(journeyDate);
            }

        }
        //method to display driver details when driver is clicked in list box
        public void DisplayDriverDetails()
        {
            DriversJourneyDetailsListBox.Items.Clear();

            var journey = (Journey)
                DriversListBox.SelectedItem;

            foreach (var j in journey.Drivers)
            {
                DriversJourneyDetailsListBox.Items.Add(j);
            }

        }
        //button to configure data
        private void configBtn_Click(object sender, EventArgs e)
        {
            DriversListBox.Items.Clear();

            SetupConfigData();

            progressLbl.Text = "Config data loaded. Waiting for user to press load";
            RunProducerConsumerBtn.Enabled = true;
            driverBtn.Enabled = false;
            configBtn.Enabled = false;
            dateBtn.Enabled = false;
            DriverTotalDistancebtn.Enabled = false;
            longestJourneyBtn.Enabled = false;


        }
        //button to  run RunProducerConsumer
        private void RunProducerConsumerBtn_Click(object sender, EventArgs e)
        {

            // Clear any items in listbox
            DriversListBox.Items.Clear();

            progressLbl.Text = "Running producer/consumer queue...";
            progressLbl.Refresh();

            // Run producer/consumer queue to load constituency data
            RunProducerConsumer();

            progressLbl.Text = "Driver data loaded";
            RunProducerConsumerBtn.Enabled = false;
            driverBtn.Enabled = true;
            configBtn.Enabled = false;
            dateBtn.Enabled = true;
            DriverTotalDistancebtn.Enabled = true;
            longestJourneyBtn.Enabled = true;
        }
        //driver lsit deiplay button
        private void driverBtn_Click(object sender, EventArgs e)
        {
            DisplayDrivers();
        }
        //date list details display button
        private void dateBtn_Click(object sender, EventArgs e)
        {
            DisplayDates();
        }
        //total distance diplay button
        private void DriverTotalDistancebtn_Click(object sender, EventArgs e)
        {
            DisplayDriverJourneys();
        }
        //longest journey display button
        private void longestJourneyBtn_Click(object sender, EventArgs e)
        {
            DisplayLongestJourney();
        }
        //driver details display
        private void DriversListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDriverDetails();
        }
    }

    
}
