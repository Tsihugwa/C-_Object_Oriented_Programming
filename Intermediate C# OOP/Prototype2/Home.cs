using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Sprint2CET211Assignment
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }



        private void Home_Load(object sender, EventArgs e)
        {
            lstViewSummary.View = View.Details;
            lstViewSummary.GridLines = true;
            lstViewSummary.FullRowSelect = true;

            lstViewSummary.Columns.Add("ID", 60);
            lstViewSummary.Columns.Add("Patient name", 120);
            lstViewSummary.Columns.Add("Telephone", 100);
            lstViewSummary.Columns.Add("Date", 100);
            lstViewSummary.Columns.Add("Time", 75);
            lstViewSummary.Columns.Add("Duration", 60);
            lstViewSummary.Columns.Add("Doctor ID", 75);
            lstViewSummary.Columns.Add("Room", 75);
            lstViewSummary.Columns.Add("Nurse ID", 75);
            lstViewSummary.Columns.Add("Email", 150);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
        }
        
    }
}