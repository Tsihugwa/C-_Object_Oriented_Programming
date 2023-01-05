using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SplashScreen : Form
    {
        

        public SplashScreen()
        {
            InitializeComponent();
           
        }

       

        private void Review_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLoading_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //tells the program to close the welcome page after the time alocated in the timer elapses
            timer1.Start();
            this.Close();
        }
    }
}
