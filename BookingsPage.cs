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
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class BookingPage : Form
    {
        //declaring variables used throughout the booking page
        float TotalCharge;
        int BaseCost;
        int carTypecost;
        int FuelP;
        int Extras;

        public BookingPage()
        {
            InitializeComponent();
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void BookingPage_Load(object sender, EventArgs e)
        {
        }
        //what happens when you click on the exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult drReply = MessageBox.Show("Exit program?", "Confirmation",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drReply == DialogResult.Yes)
            {
                Application.Exit();
            }
            //when you click on exit, summary button and save buttons are disabled
            btnSummary.Enabled = false;
            btnSave.Enabled = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
 
        }
 
        //what happens when you click on summary button
        private void btnSummary_Click(object sender, EventArgs e)
        {
            //declaring local variables
            string firstName = tbFirstName.Text;
            string surName = tbSurname.Text;
            string address = tbAddress.Text;
            string age = tbAge.Text;
            //converting the inputs to string to enable writing and reading
            string drivingLicense = rdoYes.Checked.ToString();
            string carType = lstCar.SelectedItem.ToString();
            string Fuel = lstFuel.SelectedItem.ToString();
            //Cost of booking per day
            int Duration;
            int Dailycost = 25;

            Duration = Convert.ToInt32(lstBPeriod.SelectedItem) ;
            if (lstBPeriod.SelectedIndex.ToString() == null)
            {
                
                MessageBox.Show("Input booking duration.");
            }
            //calculation for cost according to the number of days chosen
            else if (lstBPeriod.SelectedIndex >=1 || lstBPeriod.SelectedIndex<=28)
            {
                BaseCost = Convert.ToInt32(lstBPeriod.SelectedItem) * Dailycost;
            }
           
            //local variables for the different cars
            int CityCar = 0;
            int FamilyCar = 50;
            int SportsCar =75 ;
            int SUV = 65;
            //Cost of booking with preffered car calculation for different choices of the car types
            if (lstCar.SelectedItem.ToString() =="City Car")
            {
                carTypecost = CityCar;
            }
            else if(lstCar.SelectedItem.ToString() == "Family Car")
            {
                carTypecost = FamilyCar;
            }
            else if(lstCar.SelectedItem.ToString() == "Sports Car")
            {
                carTypecost =  SportsCar;
            }
            else
            {
                carTypecost =  SUV;
            }

            //declaring local variables for different fuel types
            int Petrol = 0;
            int Diesel = 0;
            int Hybrid = +30;
            int Electric = +50;
            //Cost of booking with Preffered car and Fuel type
            if (lstFuel.SelectedItem.ToString() == "Petroleum" ||lstFuel.SelectedItem.ToString() == "Diesel")
            {
                FuelP =  Petrol + Diesel;
            }
            else if(lstFuel.SelectedItem.ToString()== "Hybrid")
            {
                FuelP =  Hybrid;
            }
            else
            {
                FuelP =  Electric;
            }

            //declaring local variables for the optional preferences
            int Milage = +10;
            int Breakdown = +2;          
            string optionals = lstOptionals.SelectedItem.ToString();
            //calculation of cost for the optional preferences
            if (lstOptionals.SelectedItem.ToString() == "Unlimited Mileage")
            {
                Extras = Milage;
            }
            else if (lstOptionals.SelectedItem.ToString() == "Breakdown Cover")
            {
                Extras = Breakdown;
            }
            else
            {
                Extras = 0;

            }

            //total  price 
            TotalCharge = BaseCost + carTypecost + FuelP + Extras;

            //what happens when the text boxes are left empty
            if (string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrEmpty(tbSurname.Text) || string.IsNullOrEmpty(tbAddress.Text) || string.IsNullOrEmpty(tbAge.Text))
                {
                    tbFirstName.Focus();
                    tbFirstName.BackColor = Color.Red;
                    tbFirstName.BackColor = System.Drawing.Color.Red;

                    tbSurname.Focus();
                    tbSurname.BackColor = Color.Red;
                    tbSurname.BackColor = System.Drawing.Color.Red;

                    tbAddress.Focus();
                    tbAddress.BackColor = Color.Red;
                    tbAddress.BackColor = System.Drawing.Color.Red;

                    tbAge.Focus();
                    tbAge.BackColor = Color.Red;
                    tbAge.BackColor = System.Drawing.Color.Red;
            }
          
            //coverting the age text box to interger to enable validation of the minimum age for booking a car and allocating an integer to it
            int V = Int32.Parse(tbAge.Text);
            //age can only be 2 digits
            while (!Regex.IsMatch(age, "^\\d{2}$"))
            {
                MessageBox.Show("Invalid entry! Try again", "Confirm Exit");
            }
            //age is  equals to or more than 21
            if (V < 21)
            {
                MessageBox.Show("Sorry, minimum age to make a booking is 21");
                Application.Exit();
            }
            //stopping the program if the client has no valid driver's license
            if (rdoNo.Checked)
            {
                MessageBox.Show("Not eligibile withoud valid Driving License");
                Application.Exit();
            }
            //writing the summary in a message box
            else
            {     
                btnExit.Enabled = false;
                DialogResult = MessageBox.Show("Client Name: " + firstName +" " +surName + "\n\rAge: " + age + "\n\rAddress: " + address +
                    "\n\rDuration: " + Duration +" day(s)"+ "\n\rCar preference: " + carType + "\n\rFuel Type: " + Fuel + "\n\rOptional Preferences: " + optionals + "\n\r Rent cost per day: " + BaseCost+ "\n\rCar type cost: "+ carTypecost + "\n\rFuel preference cost: " + FuelP + "\n\rExtras " + Extras + "\n\rTotal cost: " + TotalCharge);
            }    
        }
        //what happens when you click on the save button
        private void btnSave_Click(object sender, EventArgs e)
        {
            //writing the data input into a text file
            try
            {
                //telling the program where to write the data input
                StreamWriter outputFile;
                outputFile = File.CreateText("BookingSummary.txt");

                outputFile.WriteLine("First Name: " + tbFirstName.Text);
                outputFile.WriteLine("Surname: " + tbSurname.Text);
                outputFile.WriteLine("Age: " + tbAge.Text);
                outputFile.WriteLine("Address: " + tbAddress.Text);
                outputFile.WriteLine("Days booked: " + lstBPeriod.SelectedItem.ToString() );
                outputFile.WriteLine("Car Type: " + lstCar.SelectedItem.ToString() );
                outputFile.WriteLine("Fuel preference: " + lstFuel.SelectedItem.ToString() );
                outputFile.WriteLine("Optional preference: " + lstOptionals.SelectedItem.ToString());
                //telling the program when to stop writing
                outputFile.Close();

            }
            //handling any exceptions or errors
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

        private void lblAge_Click(object sender, EventArgs e)
        {

        }

        private void rdoNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFname_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lstBPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstCar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkMileage_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbOtionals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cklOptionals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ckl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
