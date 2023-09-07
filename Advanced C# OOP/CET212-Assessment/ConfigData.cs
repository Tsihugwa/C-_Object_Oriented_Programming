using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CET212_Assessment
{
    public class ConfigData
    {
        //declare list object and variable
        public List<ConfigRecord> configRecords { get; }

        public int NextRecord { get; set; }

        public ConfigData()
        {
            this.NextRecord = 0;
            configRecords = new List<ConfigRecord>();
        }
    }
}
