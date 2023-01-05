using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntermediateSoftwareDevelopmentPrototype1
{
    public partial class AllAppointments : Form
    {
        //declare variable
        private List<Appointments> objectList;

        //add parameters to the AllAppointmnets method
        public AllAppointments(List<Appointments> objectList)
        {
            InitializeComponent();
           
            this.objectList = objectList;           
        }


        public void AllAppointments_Load(object sender, EventArgs e)
        {
            //create ListView properties
            lstAllApp.View = View.Details;
            lstAllApp.GridLines = true;
            lstAllApp.FullRowSelect = true;

            lstAllApp.Columns.Add("ID", 60);
            lstAllApp.Columns.Add("Patient name", 120);
            lstAllApp.Columns.Add("Telephone", 100);
            lstAllApp.Columns.Add("Date", 100);
            lstAllApp.Columns.Add("Time", 75);
            lstAllApp.Columns.Add("Duration", 60);
            lstAllApp.Columns.Add("Doctor ID", 75);
            lstAllApp.Columns.Add("Room", 75);
            lstAllApp.Columns.Add("Nurse ID", 75);
            lstAllApp.Columns.Add("Email", 150);
            lstAllApp.Columns.Add("Cost", 70);

            //load objectlist to listview using all four classes of appointments to represent each type of appointment
            try
            {
                foreach (Appointments app in objectList)
                {

                    if (app is Appointments)
                    {
                        lstAllApp.Items.Add(new ListViewItem(new string[] { app.Id.ToString(), app.Name, app.Phone, app.Date, app.Time, app.Duration.ToString(), app.DocId, "", "", "", "" }));
                    }
                    else if (app is Video)
                    {
                        Video vid = (Video)app;
                        lstAllApp.Items.Add(new ListViewItem(new string[] { app.Id.ToString(), app.Name, app.Phone, app.Date, app.Time, app.Duration.ToString(), app.DocId, "", "", "", vid.Email }));
                    }
                    else if (app is InPerson)
                    {
                        InPerson inp = (InPerson)app;
                        lstAllApp.Items.Add(new ListViewItem(new string[] { app.Id.ToString(), app.Name, app.Phone, app.Date, app.Time, app.Duration.ToString(), app.DocId, "", inp.Room, "", "" }));
                    }
                    else if (app is Nurse)
                    {
                        Nurse nurse = (Nurse)app;
                        lstAllApp.Items.Add(new ListViewItem(new string[] { app.Id.ToString(), app.Name, app.Phone, app.Date, app.Time, app.Duration.ToString(), app.DocId, nurse.Room, "", nurse.NurseId, "" }));
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Button to open new window
        private void btnNew_Click(object sender, EventArgs e)
        {
            NewAppointment na = new NewAppointment();
            na.Show();
            this.Hide();
        }

        //Button to exit window
        private void btnExit_Click(object sender, EventArgs e)
        {
        
            Form1 fm = new Form1();
            fm.Show();
            this.Close();
        
        }

        //Panel to clear panel input
        private void PanelClear()
        {
            foreach(Control ctr in panelFilter.Controls)
            {
                if (ctr is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)ctr;
                    radioButton.Checked = false;
                }
            }
            
        }

        //Button to display InPerson appointments
        private void rdoInPerson_CheckedChanged(object sender, EventArgs e)
        {
            // Clear the list view
            lstAllApp.Items.Clear();
            checkBoxAllApp.Checked = false;

            try
            {
                foreach (Appointments app in objectList)
                {
                    //add only InPerson appointments
                    if (app is InPerson)
                    {

                        InPerson inp = (InPerson)app;
                        lstAllApp.Items.Add(new ListViewItem(new string[] { app.Id.ToString(), app.Name, app.Phone, app.Date, app.Time, app.Duration.ToString(), app.DocId, "", inp.Room, "", "" }));

                    }

                    else if (app is Nurse)
                    {
                        Nurse nurse = (Nurse)app;
                        lstAllApp.Items.Add(new ListViewItem(new string[] { app.Id.ToString(), app.Name, app.Phone, app.Date, app.Time, app.Duration.ToString(), app.DocId, nurse.Room, "", nurse.NurseId, "" }));
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Button to display Virtual Appointments
        private void rdoVirtualApp_CheckedChanged(object sender, EventArgs e)
        {
            // Clear the list view
            lstAllApp.Items.Clear();
            checkBoxAllApp.Checked = false;

            try
            {
                // Add only the appointments and video to the list view
                foreach (Appointments app in objectList)
                {
                    if (app is Appointments)
                    {

                        lstAllApp.Items.Add(new ListViewItem(new string[] { app.Id.ToString(), app.Name, app.Phone, app.Date, app.Time, app.Duration.ToString(), app.DocId, "", "", "", "" }));
                    }
                    else if (app is Video)
                    {
                        Video vid = (Video)app;
                        lstAllApp.Items.Add(new ListViewItem(new string[] { app.Id.ToString(), app.Name, app.Phone, app.Date, app.Time, app.Duration.ToString(), app.DocId, "", "", "", vid.Email }));
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Button to display all appointments
        private void checkBoxAllApp_CheckedChanged(object sender, EventArgs e)
        {
            // Clear the list view
            lstAllApp.Items.Clear();
            PanelClear();

            foreach (Appointments app in objectList)
            {
                try
                {
                    //Load all types of appointmnets
                    if (app is Appointments)
                    {
                        lstAllApp.Items.Add(new ListViewItem(new string[] { app.Id.ToString(), app.Name, app.Phone, app.Date, app.Time, app.Duration.ToString(), app.DocId, "", "", "", "" }));
                    }
                    else if (app is Video)
                    {
                        Video vid = (Video)app;
                        lstAllApp.Items.Add(new ListViewItem(new string[] { app.Id.ToString(), app.Name, app.Phone, app.Date, app.Time, app.Duration.ToString(), app.DocId, "", "", "", vid.Email }));
                    }
                    else if (app is InPerson)
                    {
                        InPerson inp = (InPerson)app;
                        lstAllApp.Items.Add(new ListViewItem(new string[] { app.Id.ToString(), app.Name, app.Phone, app.Date, app.Time, app.Duration.ToString(), app.DocId, "", inp.Room, "", "" }));
                    }
                    else if (app is Nurse)
                    {
                        Nurse nurse = (Nurse)app;
                        lstAllApp.Items.Add(new ListViewItem(new string[] { app.Id.ToString(), app.Name, app.Phone, app.Date, app.Time, app.Duration.ToString(), app.DocId, nurse.Room, "", nurse.NurseId, "" }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
