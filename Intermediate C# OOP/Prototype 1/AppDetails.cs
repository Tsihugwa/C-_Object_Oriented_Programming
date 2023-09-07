using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1CET211Prototype
{
    class AppDetails
    {

        private int appId; //Private variables
        public int AppId//public properties
        {
            get { return appId; }
            set { appId = value; }
        }

        private string name; //Private variables
        public string Name//public properties
        {
            get { return name; }
            set { name = value; }
        }

        private string date; //Private variables
        public string Date//public properties
        {
            get { return date; }
            set { date = value; }
        }

        private string time; //Private variables
        public string Time//public properties
        {
            get { return time; }
            set { time = value; }
        }

        private int duration; //Private variables
        public int Duration//public properties
        {
            get { return duration; }
            set { duration = value; }
        }

        private string phoneNo; //Private variables
        public string PhoneNo//public properties
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }

        private string docId; //Private variables
        public string DocId//public properties
        {
            get { return docId; }
            set { docId = value; }
        }

        //constructor with no parameters
        public AppDetails() { }
        public AppDetails(int AppId, string Name, string Date, string Time, int Duration, string PhoneNo, string DocId)//constructor with parameters
        {
            this.appId = AppId;
            this.name = Name;
            this.date = Date;
            this.time = Time;
            this.duration = Duration;
            this.phoneNo = PhoneNo;
            this.docId = DocId;
        }
        //ToString() Method
        // Allow me to summarise this class
        public override string ToString()
        {
            string Appointment1;
            Appointment1 = "Appointment ID: " + AppId + " | Patient Name: " + Name + " | Date: " + Date + " | Time: " + Time + " | Duration: " + Duration + " | Phone No: " + PhoneNo + " | Doctor ID" + DocId;

            return Appointment1;
        }
    }

    class Virtual: AppDetails
    {
        private string email;//Private variables
        public string Email//public properties
        {
            get {return email; }
            set {email= value; }
        }

        public Virtual() { }//constructor with no parameters

        public Virtual(int AppId, string Name, string Date, string Time, int Duration, string PhoneNo, string DocId, string Email) : base(AppId, Name, Date, Time, Duration,PhoneNo, DocId)//constructor with parameters
        {
            this.email = Email;
        }
        //ToString() Method
        // Allow me to summarise this class
        public override string ToString()
        {
            string Appointment2;
            Appointment2 = "Appointment ID: " + AppId + " | Patient Name: " + Name + " | Date: " + Date + " | Time: " + Time + " | Duration: " + Duration + " | Phone No: " + PhoneNo + " | Doctor ID" + DocId+ " | Email: " + Email; 
            return Appointment2;
        }
    }
    class InPerson:AppDetails
    {

        private string room;//Private variables
        public string Room //public properties
        { 
            get { return room; } 
            set { room = value; } 
        }
       
        public InPerson() { }//constructor with no parameters
        public InPerson(string Room, int AppId, string Name, string Date, string Time, int Duration, string PhoneNo, string DocId): base(AppId, Name, Date, Time, Duration, PhoneNo, DocId)//constructor with parameters
        {
            this.room = Room;
        }

        public InPerson(int AppId, string Name, string Date, string Time, int Duration, string PhoneNo, string DocId) : base(AppId, Name, Date, Time, Duration, PhoneNo, DocId)
        {
        }

        //ToString() Method
        // Allow me to summarise this class
        public override string ToString()
        {
            string Appointment3;
            Appointment3 = "Appointment ID: " + AppId + " | Patient Name: " + Name + " | Date: " + Date + " | Time: " + Time + " | Duration: " + Duration + " | Phone No: " + PhoneNo + " | Doctor ID" + DocId + " | Room No: " + Room;
            return Appointment3;
        }

    }

    class Nurse:InPerson
    {
        private string nurseId;//Private variables
        public string NurseId//public properties
        {
            get { return nurseId; }
            set { nurseId = value; }
        }
        public Nurse() { }//constructor with no parameters
        public Nurse( int AppId, string Name, string Date, string Time, int Duration, string PhoneNo, string DocId, string NurseId, string Room) : base(AppId, Name, Date, Time, Duration, PhoneNo, DocId)//constructor with parameters
        {
            this.nurseId = NurseId;

        }

        //ToString() Method
        // Allow me to summarise this class
        public override string ToString()
        {
            string Appointment4;
            Appointment4 = "Appointment ID: " + AppId + " | Patient Name: " + Name + " | Date: " + Date + " | Time: " + Time + " | Duration: " + Duration + " | Phone No: " + PhoneNo + " | Doctor ID" + DocId + " | Room No: " + Room+ " | Nurse Id: " + NurseId;
            return Appointment4;
        }

    }

}
