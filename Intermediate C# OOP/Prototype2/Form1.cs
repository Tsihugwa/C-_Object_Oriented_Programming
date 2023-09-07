using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Xml.Serialization;

namespace Sprint2CET211Assignment
{
    public partial class Form1 : Form
    {

        //variables
        Appointments noVid;
        Video yesVid;
        InPerson noNurse;
        Nurse yesNurse;
        List<Appointments> allAppointments = new List<Appointments>();
        

        

        public Form1()
        {
            InitializeComponent();
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listViewSummary.View = View.Details;
            listViewSummary.GridLines = true;
            listViewSummary.FullRowSelect = true;

            listViewSummary.Columns.Add("ID", 60);
            listViewSummary.Columns.Add("Patient name", 120);
            listViewSummary.Columns.Add("Telephone", 100);
            listViewSummary.Columns.Add("Date", 100);
            listViewSummary.Columns.Add("Time", 75);
            listViewSummary.Columns.Add("Duration", 60);
            listViewSummary.Columns.Add("Doctor ID", 75);
            listViewSummary.Columns.Add("Room", 75);
            listViewSummary.Columns.Add("Nurse ID", 75);
            listViewSummary.Columns.Add("Email", 150);

        }

 
        private void tbID_TextChanged(object sender, EventArgs e){}
        private void tbDuration_TextChanged(object sender, EventArgs e){}

        private void rdoNurseYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNurseYes.Checked)
            {
                ClearGB3();
                tbNurseID.Clear();
                tbNurseID.Enabled = true;
            }
        }

        private void rdoNurseNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNurseNo.Checked)
            {
                ClearGB3();
                tbNurseID.Clear();
                tbNurseID.Enabled = false;
            }
        }

        private void rdoVidYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoVidYes.Checked)
            {
                ClearGB2();
                tbEmail.Clear();
                tbEmail.Enabled = true;
            }
        }

        private void rdoVidNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoVidNo.Checked)
            {
                ClearGB2();
                tbEmail.Clear();
                tbEmail.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string input = tbDuration.Text;
                int number;
                if (!int.TryParse(input, out number))
                {
                    throw new Exception("Input a number in Appointment Duration.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string input = tbID.Text;
                int number;
                if (!int.TryParse(input, out number))
                {
                    throw new Exception("Input a number in Appointment ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {

                // code to check duration goes here
                if (Convert.ToInt32(tbDuration.Text) > 60)
                {
                    throw new ArithmeticException("Error! Duration input exceeds limit of 60 minutes");
                }

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

                else
                {
                    // Create an instance of the XmlSerializer class and specify the type of object to serialize
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Appointments>));

                    // Create a FileStream to write the serialized object to a file
                    using (FileStream fs = new FileStream("Appointments.dat", FileMode.Create))
                    {
                        // Serialize the lists of objects and write them to the file
                        serializer.Serialize(fs, allAppointments);
                    }

                    ClearGB2();
                    ClearGB3();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnSummary_Click(object sender, EventArgs e)
        {           
            try
            {
                
                // code to check duration goes here
                if (Convert.ToInt32(tbDuration.Text) > 60)
                {
                    throw new ArithmeticException("Error! Duration input exceeds limit of 60 minutes");
                }
                else if (string.IsNullOrEmpty(tbID.Text) || string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbPhone.Text) || string.IsNullOrEmpty(tbDuration.Text) || string.IsNullOrEmpty(tbDocId.Text) )
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
                    listViewSummary.Items.Add(new ListViewItem(new string[] { tbID.Text, tbName.Text, tbPhone.Text, dateTime.Value.ToShortDateString(), Time.Value.ToShortTimeString(), tbDuration.Text, tbDocId.Text, tbRoom.Text, tbNurseID.Text, tbEmail.Text }));
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message);
            }
        }

       


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearGB1();
            ClearGB2();
            ClearGB3();
            listViewSummary.Clear();
        }

        //create method to clear groupbox controls
        private void ClearGB1()
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

  
    }
}
 