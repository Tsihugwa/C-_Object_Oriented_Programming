using System;

namespace IntermediateSoftwareDevelopmentPrototype1
{
    
    [Serializable]
    public class Appointments : ICostable
    {
        //private variables
        private int id;
        private string date;
        private string time;
        private int duration;
        private string name;
        private string phone;
        private string docId;
        private decimal cost;

        public int Id//public properties
        {
            get { return id; }
            set { id = value; }
        }
        public string Name//public properties
        {
            get { return name; }
            set { name = value; }
        }
        public string Date//public properties
        {
            get { return date; }
            set { date = value; }
        }
        public string Time//public properties
        {
            get { return time; }
            set { time = value; }
        }
        public int Duration//public properties
        {
            get { return duration; }
            set { duration = value; }
        }
        public string Phone//public properties
        {
            get { return phone; }
            set { phone = value; }
        }
        public string DocId//public properties
        {
            get { return docId; }
            set { docId = value; }
        }
        public decimal Cost//public properties
        {
            get { return cost; }
            set { cost = value; }
        }

        //constructor with no parameters
        public Appointments() { }
        public Appointments(int Id, string Name, string Date, string Time, int Duration, string PhoneNo, string DocId)//constructor with parameters
        {
            this.id = Id;
            this.name = Name;
            this.date = Date;
            this.time = Time;
            this.duration = Duration;
            this.phone = PhoneNo;
            this.docId = DocId;
        }

        public decimal CalculateCost()
        {
            // Calculate the cost for Video and Appointments appointments
            decimal staffCost = duration * 10; // Assume that the doctor fee per minute is £10
            return staffCost;
        }

    }

    [Serializable]
    public class Video : Appointments, ICostable
    {
        //private variables
        private string email;
        public string Email//public properties
        {
            get { return email; }
            set { email = value; }
        }
        public Video() { }//constructor with no parameters
        public Video(int Id, string Name, string Date, string Time, int Duration, string Phone, string DocId, string Email) : base(Id, Name, Date, Time, Duration, Phone, DocId)//constructor with parameters
        {
            this.email = Email;
        }

        public new decimal CalculateCost()
        {
            // Calculate the cost for Video and Appointments appointments
            decimal staffCost = Duration * 10; // Assume that the doctor fee per minute is £10
            return staffCost;
        }
    }

    [Serializable]
    public class InPerson : Appointments, ICostable
    {
        //private variables
        private string room;
        public string Room //public properties
        {
            get { return room; }
            set { room = value; }
        }

        public InPerson() { }//constructor with no parameters
        public InPerson(string Room, int Id, string Name, string Date, string Time, int Duration, string Phone, string DocId) : base(Id, Name, Date, Time, Duration, Phone, DocId)//constructor with parameters
        {
            this.room = Room;
        }

        public InPerson(int Id, string Name, string Date, string Time, int Duration, string Phone, string DocId) : base(Id, Name, Date, Time, Duration, Phone, DocId)
        {

        }


        public new decimal CalculateCost()
        {
            decimal staffCost = 0;
            if (Duration <= 10)
            {
                staffCost = Duration * 25; // Doctor fee per minute is £25 for appointments of 10 minutes or less
            }
            else
            {
                staffCost = Duration * 20; // Doctor fee per minute is £20 for appointments longer than 10 minutes
            }
            return staffCost;
        }
        
    }

    [Serializable]
    public class Nurse : InPerson, ICostable
    {
        //private variables
        private string nurseId;
        public string NurseId//public properties
        {
            get { return nurseId; }
            set { nurseId = value; }
        }
        public Nurse() { }//constructor with no parameters
        public Nurse(int App, string Name, string Date, string Time, int Duration, string Phone, string DocId, string NurseId, string Room) : base(App, Name, Date, Time, Duration, Phone, DocId)//constructor with parameters
        {
            this.nurseId = NurseId;
        }

        public new decimal CalculateCost()
        {
            decimal staffCost = 0;
            if (Duration <= 10)
            {
                staffCost = Duration * 25; // Doctor fee per minute is £25 for appointments of 10 minutes or less
            }
            else
            {
                staffCost = Duration * 20; // Doctor fee per minute is £20 for appointments longer than 10 minutes
            }
            staffCost += 25; // Add a fixed fee of £25 if a nurse is required
            return staffCost;
        }
    }

}
