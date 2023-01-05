using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntermediateSoftwareDevelopmentPrototype1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //declare variable
        private string filename = "Appointments.dat";

        //Button to close window
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //button to open new appointmnet window
        private void btnNewAppointments_Click(object sender, EventArgs e)
        {            
            NewAppointment na = new NewAppointment();
            na.Show();
            this.Hide();
            
        }

        //button to open all appointments window
        private void btnAppointments_Click(object sender, EventArgs e)
        {
            try
            {
                //deserialize the data in the file and display in all appointment form
                List<Appointments> objectList = new List<Appointments>();
                using (FileStream stream = File.OpenRead(filename))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    objectList = (List<Appointments>)formatter.Deserialize(stream);


                }
                AllAppointments form = new AllAppointments(objectList);
                form.Show();
            }
            catch
            {
                MessageBox.Show("No data available to display");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
