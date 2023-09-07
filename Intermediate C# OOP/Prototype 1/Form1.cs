using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint1CET211Prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }      
        //variables
        private AppDetails App1;
        private Virtual App2;
        private InPerson App3;
        private Nurse App4;

        private void Form1_Load(object sender, EventArgs e)
        {
            //declare and instantiate all objects
            App1 = new AppDetails();
            App1.AppId =201;
            App1.Name = "Ryan Tsihugwa";
            App1.Date = "12/01/2021";
            App1.Time = "10:30";
            App1.Duration = 10 ;
            App1.PhoneNo = "07458534635";
            App1.DocId = "Dr26";

            App2 = new Virtual();
            App2.AppId = 302;
            App2.Name = "Joan Irungu";
            App2.Date = "09/03/2021";
            App2.Time = "10:50";
            App2.Duration = 10;
            App2.PhoneNo = "07458534730";
            App2.DocId = "Dr21";
            App2.Email = "Irungu@gmail.com";

            App3 = new InPerson();
            App3.AppId = 103;
            App3.Name = "Brenda Kerubo";
            App3.Date = "12/07/2021";
            App3.Time = "10:30";
            App3.Duration = 10;
            App3.PhoneNo = "07458534370";
            App3.DocId = "Dr24";
            App3.Room = "ER23" ;

            App4 = new Nurse();
            App4.AppId = 105;
            App4.Name = "Gloria Asuga";
            App4.Date = "12/10/2021";
            App4.Time = "12:30";
            App4.Duration = 20;
            App4.PhoneNo = "07257534370";
            App4.DocId = "Dr37";
            App4.Room = "ER45";
            App4.NurseId = "NS27";

        }

        private void rdoNurseYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNurseYes.Checked)
            {
                ClearGB3();
                lstDisplay.Items.Clear();
                DisplayNurseId(App4);//call Display metnod for appointment 4

            }                       
        }
        private void rdoNurseNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNurseNo.Checked)
            {
                ClearGB3();
                lstDisplay.Items.Clear();
                DisplayRoom(App3);//call Display metnod for appointment 3

            }            
        }

        private void rdoVidYes_CheckedChanged(object sender, EventArgs e)
        {           
            if (rdoVidYes.Checked)
            {
                ClearGB2();
                lstDisplay.Items.Clear();
                DisplayEmail(App2);//call Display metnod for appointment 2

            }
        }

        private void rdoVidNo_CheckedChanged(object sender, EventArgs e)
        {            
            if (rdoVidNo.Checked)
            {
                ClearGB2();// clear groupbox controls
                lstDisplay.Items.Clear();
                DisplayDetails(App1);//call Display metnod for appointment 1
                
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();//clear listbox before displaying appointment
            lstDisplay.Items.Add(App4.ToString());
            lstDisplay.Items.Add(App3.ToString());
            lstDisplay.Items.Add(App2.ToString());
            lstDisplay.Items.Add(App1.ToString());
            ClearGB1();// clear groupbox controls
            ClearGB2();// clear groupbox controls
            ClearGB3();// clear groupbox controls
        }

       
        private void btnInPerson_Click(object sender, EventArgs e)
        {           
            lstDisplay.Items.Clear();//clear listbox before displaying appointment
            lstDisplay.Items.Add(App4.ToString());
            lstDisplay.Items.Add(App3.ToString());
            ClearGB1();// clear groupbox controls
            ClearGB2();// clear groupbox controls
            ClearGB3();// clear groupbox controls
        }

        private void btnVirtual_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();//clear listbox before displaying appointment
            lstDisplay.Items.Add(App2.ToString());
            lstDisplay.Items.Add(App1.ToString());
            ClearGB1();// clear groupbox controls
            ClearGB2();// clear groupbox controls
            ClearGB3();// clear groupbox controls
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();    //clear listbox        
            ClearGB1();// clear groupbox controls
            ClearGB2();// clear groupbox controls
            ClearGB3();// clear groupbox controls
        }

        //create method to display appointment
        private void DisplayDetails(AppDetails App1)
        {
            lstDisplay.Items.Clear();
            lstDisplay.Items.Add(lblID.Text + ": " + App1.AppId.ToString());
            lstDisplay.Items.Add(lblName.Text + ": " + App1.Name);
            lstDisplay.Items.Add(lblPhone.Text + ": " + App1.PhoneNo.ToString());
            lstDisplay.Items.Add(lblDate.Text + ": " + App1.Date.ToString());
            lstDisplay.Items.Add(lblTime.Text + ": " + App1.Time);
            lstDisplay.Items.Add(lblDuration.Text + ": " + App1.Duration.ToString());
            lstDisplay.Items.Add(lblDocID.Text + ": " + App1.DocId);
            
        }
        //create method to display appointment
        private void DisplayRoom(InPerson App3)
        {
            lstDisplay.Items.Clear();
            lstDisplay.Items.Add(lblID.Text + ": " + App3.AppId.ToString());
            lstDisplay.Items.Add(lblName.Text + ": " + App3.Name);
            lstDisplay.Items.Add(lblPhone.Text + ": " + App3.PhoneNo.ToString());
            lstDisplay.Items.Add(lblDate.Text + ": " + App3.Date.ToString());
            lstDisplay.Items.Add(lblTime.Text + ": " + App3.Time);
            lstDisplay.Items.Add(lblDuration.Text + ": " + App3.Duration.ToString());
            lstDisplay.Items.Add(lblDocID.Text + ": " + App3.DocId);
            lstDisplay.Items.Add(lblRoom.Text + ": " + App3.Room);
            
        }
        //create method to display appointment
        private void DisplayNurseId(Nurse App4)
        {

            lstDisplay.Items.Clear();
            lstDisplay.Items.Add(lblID.Text + ": " + App4.AppId.ToString());
            lstDisplay.Items.Add(lblName.Text + ": " + App4.Name);
            lstDisplay.Items.Add(lblPhone.Text + ": " + App4.PhoneNo.ToString());
            lstDisplay.Items.Add(lblDate.Text + ": " + App4.Date.ToString());
            lstDisplay.Items.Add(lblTime.Text + ": " + App4.Time);
            lstDisplay.Items.Add(lblDuration.Text + ": " + App4.Duration.ToString());
            lstDisplay.Items.Add(lblDocID.Text + ": " + App4.DocId);
            lstDisplay.Items.Add(lblRoom.Text + ": " + App4.Room);
            lstDisplay.Items.Add(lblNurse.Text + "; " + App4.NurseId);
          
        }
        //create method to display appointment
        private void DisplayEmail(Virtual App2)
        {

            lstDisplay.Items.Clear();
            lstDisplay.Items.Add(lblID.Text + ": " + App2.AppId.ToString());
            lstDisplay.Items.Add(lblName.Text + ": " + App2.Name);
            lstDisplay.Items.Add(lblPhone.Text + ": " + App2.PhoneNo.ToString());
            lstDisplay.Items.Add(lblDate.Text + ": " + App2.Date.ToString());
            lstDisplay.Items.Add(lblTime.Text + ": " + App2.Time);
            lstDisplay.Items.Add(lblDuration.Text + ": " + App2.Duration.ToString());
            lstDisplay.Items.Add(lblDocID.Text + ": " + App2.DocId);
            lstDisplay.Items.Add(lblEmail.Text + ": " + App2.Email);
            
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
     
        private void lstDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void lblNurse_Click(object sender, EventArgs e)
        {
        }
    }
}
