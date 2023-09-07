using System;

namespace CET212_Assessment
{
    public class ConfigRecord
    {
        //declare variable
        public String Filename { get; }
        
        //create method for the Config Class
        public ConfigRecord(String Filename)
        {
            this.Filename = Filename;
        }

        public ConfigRecord()
        {
        }
        //to string method
        public override String ToString()
        {
            return String.Format("{0}", Filename);
        }
    }
}
