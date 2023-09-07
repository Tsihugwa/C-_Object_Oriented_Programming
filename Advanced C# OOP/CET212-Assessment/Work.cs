using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CET212_Assessment
{
	public class Work
	{
		public ConfigRecord configRecord { get; } // Data used when this work is processed - config record
		private IJourneyFileReader IOhandler; // Data used when this work is processed - config record

		public Work(ConfigRecord data, IJourneyFileReader IOhandler)
		{
			this.configRecord = data; // Data is initialised when the work is instantiated
			this.IOhandler = IOhandler;
		}

		public virtual Journey ReadData()
		{
			// Reads the specified file and extracts the constituency data from it to store in a Constituency object
			return IOhandler.ReadJourneyDataFromFile(configRecord);
		}
	}
}
