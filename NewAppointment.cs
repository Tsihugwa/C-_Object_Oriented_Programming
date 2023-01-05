using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntermediateSoftwareDevelopmentPrototype1
{
    public partial class NewAppointment : Form
    {
        public NewAppointment()
        {
            InitializeComponent();

        }

        //declare objects 
        Appointments noVid;
        Video yesVid;
        InPerson noNurse;
        Nurse yesNurse;
        private string filename = "Appointments.dat";
        List<Appointments> allAppointments = new List<Appointments>();

        private void NewAppointment_Load(object sender, EventArgs e)
        {
            listViewSummary.View = View.Details;
            listViewSummary.GridLines = true;
            listViewSummary.FullRowSelect = true;

            listViewSummary.Columns.Add("ID", 60);
            listViewSummary.Columns.Add("Patient name", 120);
            listViewSummary.Columns.Add("Amount", 100);
        }

        public void Objects()
        {

            try
            {

                //create object for the classes
                noVid = new Appointments();
                noVid.Id = Int32.Parse(tbID.Text);
                noVid.Name = tbName.Text;
                noVid.Phone = tbPhone.Text;
                noVid.Date = dateTime.Value.ToShortDateString();
                noVid.Time = Time.Value.ToShortTimeString();
                noVid.Duration = Int32.Parse(tbDuration.Text);
                noVid.DocId = tbDocId.Text;

                yesVid = new Video();
                yesVid.Id = Int32.Parse(tbID.Text);
                yesVid.Name = tbName.Text;
                yesVid.Phone = tbPhone.Text;
                yesVid.Date = dateTime.Value.ToShortDateString();
                yesVid.Time = Time.Value.ToShortTimeString();
                yesVid.Duration = Int32.Parse(tbDuration.Text);
                yesVid.DocId = tbDocId.Text;
                yesVid.Email = tbEmail.Text;

                noNurse = new InPerson();
                noNurse.Id = Int32.Parse(tbID.Text);
                noNurse.Name = tbName.Text;
                noNurse.Phone = tbPhone.Text;
                noNurse.Date = dateTime.Value.ToShortDateString();
                noNurse.Time = Time.Value.ToShortTimeString();
                noNurse.Duration = Int32.Parse(tbDuration.Text);
                noNurse.DocId = tbDocId.Text;

                yesNurse = new Nurse();
                yesNurse.Id = Int32.Parse(tbID.Text);
                yesNurse.Name = tbName.Text;
                yesNurse.Phone = tbPhone.Text;
                yesNurse.Date = dateTime.Value.ToShortDateString();
                yesNurse.Time = Time.Value.ToShortTimeString();
                yesNurse.Duration = Int32.Parse(tbDuration.Text);
                yesNurse.DocId = tbDocId.Text;
                yesNurse.Room = tbRoom.Text;
                yesNurse.NurseId = tbNurseID.Text;


                allAppointments.Add(noVid);
                allAppointments.Add(yesVid);
                allAppointments.Add(noNurse);
                allAppointments.Add(yesNurse);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSummary_Click_1(object sender, EventArgs e)
        {

            try
            {
                //declare variables
                string input = tbDuration.Text;
                int number;
                int id = Int32.Parse(tbID.Text);
                string inputs = tbID.Text;
                int numbers;
                // Regular expression to check if doctor's id has first two letters is in correct format
                string docId = @"^[A-Za-z]{2}[0-9]+$";
                // Regular expression to check if email is in correct format
                string roomNo = @"^[A-Za-z]{2}[0-9]+$";
                
                //Regex to make sure name textbox inly has letters
                string name = "^[a-zA-Z]*$";

                //check textboxes are in correct format
                if (!int.TryParse(input, out number))
                {
                    throw new Exception("Input a number in Appointment Duration.");
                }

                else if (!int.TryParse(inputs, out numbers))
                {
                    // Display error message if email is not in correct format
                    throw new Exception("Input a number in Appointment ID.");

                }

                else if (!Regex.IsMatch(tbName.Text, name))
                {
                    // Display error message if email is not in correct format
                    MessageBox.Show("Name must have letters only.");

                    // Clear the email textbox
                    tbName.Clear();
                }

                else if (!Regex.IsMatch(tbDocId.Text, docId))
                {
                    // Display error message if email is not in correct format
                    MessageBox.Show("Doctor ID must start with two letters followed by numbers.");

                    // Clear the email textbox
                    tbDocId.Clear();
                }

                else if (!Regex.IsMatch(tbDocId.Text, roomNo))
                {
                    MessageBox.Show("Room number must start with two letters followed by numbers.");

                    // Clear the email textbox
                    tbRoom.Clear();
                }

                // code to check duration goes here
                else if (Convert.ToInt32(tbDuration.Text) > 60)
                {
                    throw new ArithmeticException("Error! Duration input exceeds limit of 60 minutes");
                }

                //check if textboxes are null
                else if (string.IsNullOrEmpty(tbID.Text) || string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbPhone.Text) || string.IsNullOrEmpty(tbDuration.Text) || string.IsNullOrEmpty(tbDocId.Text))
                {
                    throw new Exception("One or more of the text boxes are null or empty.");
                }

                else if (rdoNurseYes.Checked && string.IsNullOrEmpty(tbNurseID.Text))
                {
                    throw new Exception("Input nurse ID.");

                }

                else if (rdoNurseYes.Checked && string.IsNullOrEmpty(tbRoom.Text))
                {
                    throw new Exception("Input room number.");

                }

                else if (rdoNurseNo.Checked && string.IsNullOrEmpty(tbRoom.Text))
                {
                    throw new Exception("Input room number.");
                }

                else if (rdoVidYes.Checked && string.IsNullOrEmpty(tbEmail.Text))
                {
                    throw new Exception("Input patient's email.");
                }

                else
                {
                    //display cost of appointmnets in Summary view
                    decimal cost;
                    if (rdoNurseNo.Checked)
                    {
                        InPerson inPersonAppointment = new InPerson();
                        inPersonAppointment.Duration = int.Parse(tbDuration.Text);
                        cost = inPersonAppointment.CalculateCost();

                        listViewSummary.Items.Add(new ListViewItem(new string[] { tbID.Text, tbName.Text, cost.ToString() }));
                    }

                    else if (rdoNurseYes.Checked)
                    {
                        Nurse nurseAppointment = new Nurse();
                        nurseAppointment.Duration = int.Parse(tbDuration.Text);
                        cost = nurseAppointment.CalculateCost();

                        listViewSummary.Items.Add(new ListViewItem(new string[] { tbID.Text, tbName.Text, cost.ToString() }));
                    }

                    else if (rdoVidNo.Checked)
                    {
                        Appointments appointment = new Appointments();
                        appointment.Duration = int.Parse(tbDuration.Text);
                        cost = appointment.CalculateCost();

                        listViewSummary.Items.Add(new ListViewItem(new string[] { tbID.Text, tbName.Text, cost.ToString() }));
                    }

                    else if (rdoVidYes.Checked)
                    {
                        Video video = new Video();
                        video.Duration = int.Parse(tbDuration.Text);
                        cost = video.CalculateCost();

                        listViewSummary.Items.Add(new ListViewItem(new string[] { tbID.Text, tbName.Text, cost.ToString() }));
                    }

                    else
                    {
                        throw new Exception("Choose the type of appointment to make.");
                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                //declare variables
                string input = tbDuration.Text;
                int number;
                int id = Int32.Parse(tbID.Text);
                string inputs = tbID.Text;
                int numbers;
                // Regular expression to check if doctor's id has first two letters is in correct format
                string docId = @"^[A-Za-z]{2}[0-9]+$";
                // Regular expression to check if email is in correct format
                string roomNo = @"^[A-Za-z]{2}[0-9]+$";
                // Regular expression to check if email is in correct format
                string emailRegex = @"^[\w!#$%&'+-/=?^_{|}~]+(\.[\w!#$%&'*+\-/=?\^_{|}~]+)" + "@" + @"((([-\w]+.)+[a-zA-Z]{2,4})|(([0-9]{1,3}.){3}[0-9]{1,3}))$";
                //Regex to make sure name textbox inly has letters
                string name = "^[a-zA-Z]*$";

                //check correct textbox input format
                if (!int.TryParse(input, out number))
                {
                    throw new Exception("Input a number in Appointment Duration.");
                }

                else if (!int.TryParse(inputs, out numbers))
                {
                    // Display error message if email is not in correct format
                    throw new Exception("Input a number in Appointment ID.");
                }

                else if (!Regex.IsMatch(tbName.Text, name))
                {
                    // Display error message if email is not in correct format
                    MessageBox.Show("Name must have letters only.");

                    // Clear the email textbox
                    tbName.Clear();
                }

                else if (!Regex.IsMatch(tbDocId.Text, docId))
                {
                    // Display error message if email is not in correct format
                    MessageBox.Show("Doctor ID must start with two letters followed by numbers.");

                    // Clear the email textbox
                    tbDocId.Clear();
                }

                else if (!Regex.IsMatch(tbDocId.Text, roomNo))
                {
                    MessageBox.Show("Room number must start with two letters followed by numbers.");

                    // Clear the email textbox
                    tbRoom.Clear();
                }
                else if (rdoVidYes.Checked)
                {
                    // Check if email is in correct format
                    if (!Regex.IsMatch(tbEmail.Text, emailRegex))
                    {
                        // Display error message if email is not in correct format
                        MessageBox.Show("Please enter a valid email address");

                        // Clear the email textbox
                        tbEmail.Clear();
                    }
                }
                // code to check duration goes here
                else if (Convert.ToInt32(tbDuration.Text) > 60)
                {
                    throw new ArithmeticException("Error! Duration input exceeds limit of 60 minutes");
                }

                //check if textbox input is null and display error messages
                else if (string.IsNullOrEmpty(tbID.Text) || string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbPhone.Text)
                 || string.IsNullOrEmpty(tbDuration.Text) || string.IsNullOrEmpty(tbDocId.Text))
                {
                    throw new Exception("One or more of the text boxes are null or empty.");
                }

                else if (rdoNurseYes.Checked && string.IsNullOrEmpty(tbNurseID.Text))
                {
                    throw new Exception("Input nurse ID.");

                }

                else if (rdoNurseYes.Checked && string.IsNullOrEmpty(tbRoom.Text))
                {
                    throw new Exception("Input room number.");

                }

                else if (rdoNurseNo.Checked && string.IsNullOrEmpty(tbRoom.Text))
                {
                    throw new Exception("Input room number.");
                }

                else if (rdoVidYes.Checked && string.IsNullOrEmpty(tbEmail.Text))
                {
                    throw new Exception("Input patient's email.");
                }

                else if (!rdoNurseNo.Checked && !rdoNurseYes.Checked && !rdoVidNo.Checked && !rdoVidYes.Checked)
                {
                    throw new Exception("Choose the type of appointment to be made");
                }

                // Check if the tbID value is already present in the list of appointments
                List<Appointments> appointmentsList;
                if (File.Exists(filename))
                {
                    // Deserialize the file and store the data in a list
                    using (Stream stream = File.Open(filename, FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        appointmentsList = (List<Appointments>)bin.Deserialize(stream);
                    }
                }
                else
                {
                    // If the file does not exist, create a new list
                    List<Appointments> allAppointments = new List<Appointments>();
                }

                // Check if the tbID input value is already in the list
                bool tbIDExists = allAppointments.Any(a => a.Id == Int32.Parse(tbID.Text));

                if (!tbIDExists)
                {
                    // If the tbID input value is not in the list, add it to the list

                    Objects();
                    // Serialize the updated list back to the file
                    using (Stream stream = File.Open(filename, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(stream, allAppointments);
                    }
                }
                else
                {
                    // If the tbID input value is already in the list, show an error message
                    throw new Exception("Error: Appointment with the same ID already exists!");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //functionality of Clear button
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearGB1();
            ClearGB2();
            ClearGB3();
            listViewSummary.Clear();
        }

        //create method to clear groupbox controls
        public void ClearGB1()
        {
            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox textbox = (TextBox)ctr;
                    textbox.Text = null;
                }
            }
        }
        //create method to clear groupbox controls
        public void ClearGB2()
        {
            foreach (Control ctr in groupBox2.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox textbox = (TextBox)ctr;
                    textbox.Text = null;
                }
                if (ctr is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)ctr;
                    radioButton.Checked = false;
                }
            }
        }
        //create method to clear groupbox controls
        public void ClearGB3()
        {
            foreach (Control ctr in groupBox3.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox textbox = (TextBox)ctr;
                    textbox.Text = null;
                }
                if (ctr is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)ctr;
                    radioButton.Checked = false;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Close();
        }

        //control what happens when radio button is clicked
        private void rdoVidYes_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdoVidYes.Checked)
            {
                ClearGB2();
                tbEmail.Clear();
                tbEmail.Enabled = true;
            }
        }

        //control what happens when radio button is clicked
        private void rdoVidNo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdoVidNo.Checked)
            {
                ClearGB2();
                tbEmail.Clear();
                tbEmail.Enabled = false;
            }
        }

        //control what happens when radio button is clicked
        private void rdoNurseYes_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdoNurseYes.Checked)
            {
                ClearGB3();
                tbNurseID.Clear();
                tbNurseID.Enabled = true;
            }
        }

        //control what happens when radio button is clicked
        private void rdoNurseNo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdoNurseNo.Checked)
            {
                ClearGB3();
                tbNurseID.Clear();
                tbNurseID.Enabled = false;
            }
        }

        
    }
}
