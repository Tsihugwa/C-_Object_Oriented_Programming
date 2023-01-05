using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare string variable for password and username
            const string username = "sta001";            
            const string password = "givemethekeys123";
            //validating the text input in the textboxes if no input is added
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Input Password or Username ");
            }
            //Validating the text input in the textboxes and comparing it to whats in the string username and password
            else if (textBox1.Text.Equals(username))
            {
                if ( textBox2.Text.Equals(password))
                {
                    //telling the program what to do when the text input is equal to the string username and password
                    BookingPage fm1 = new BookingPage();
                    fm1.Show();
                    this.Hide();
                }
               
            }
           // what happens when the above conditions are not met 
            else
            {
                MessageBox.Show("Input correct username or password");

            }
            
            
           
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
