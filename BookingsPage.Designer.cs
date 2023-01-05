
namespace WindowsFormsApp1
{
    partial class BookingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBookingdetails = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblExtras = new System.Windows.Forms.Label();
            this.btnSummary = new System.Windows.Forms.Button();
            this.rdoYes = new System.Windows.Forms.RadioButton();
            this.rdoNo = new System.Windows.Forms.RadioButton();
            this.lstBPeriod = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCustomerDetails = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.ckl = new System.Windows.Forms.Panel();
            this.lstOptionals = new System.Windows.Forms.ListBox();
            this.lblRentalSpecs = new System.Windows.Forms.Label();
            this.lblCartype = new System.Windows.Forms.Label();
            this.lstFuel = new System.Windows.Forms.ListBox();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lstCar = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.ckl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBookingdetails
            // 
            this.lblBookingdetails.AutoSize = true;
            this.lblBookingdetails.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingdetails.Location = new System.Drawing.Point(308, 9);
            this.lblBookingdetails.Name = "lblBookingdetails";
            this.lblBookingdetails.Size = new System.Drawing.Size(172, 27);
            this.lblBookingdetails.TabIndex = 0;
            this.lblBookingdetails.Text = "Booking Details";
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicense.Location = new System.Drawing.Point(47, 184);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(136, 22);
            this.lblLicense.TabIndex = 5;
            this.lblLicense.Text = "Driver\'s License";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(9, 44);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(148, 22);
            this.lblPeriod.TabIndex = 6;
            this.lblPeriod.Text = "Booking Period: ";
            // 
            // lblExtras
            // 
            this.lblExtras.AutoSize = true;
            this.lblExtras.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtras.Location = new System.Drawing.Point(370, 188);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(145, 22);
            this.lblExtras.TabIndex = 9;
            this.lblExtras.Text = "Optional Extras: ";
            // 
            // btnSummary
            // 
            this.btnSummary.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.Location = new System.Drawing.Point(711, 570);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(115, 45);
            this.btnSummary.TabIndex = 10;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // rdoYes
            // 
            this.rdoYes.AutoSize = true;
            this.rdoYes.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoYes.Location = new System.Drawing.Point(240, 182);
            this.rdoYes.Name = "rdoYes";
            this.rdoYes.Size = new System.Drawing.Size(62, 26);
            this.rdoYes.TabIndex = 15;
            this.rdoYes.TabStop = true;
            this.rdoYes.Text = "Yes";
            this.rdoYes.UseVisualStyleBackColor = true;
            this.rdoYes.CheckedChanged += new System.EventHandler(this.rdoYes_CheckedChanged);
            // 
            // rdoNo
            // 
            this.rdoNo.AutoSize = true;
            this.rdoNo.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNo.Location = new System.Drawing.Point(340, 181);
            this.rdoNo.Name = "rdoNo";
            this.rdoNo.Size = new System.Drawing.Size(60, 26);
            this.rdoNo.TabIndex = 16;
            this.rdoNo.TabStop = true;
            this.rdoNo.Text = "No";
            this.rdoNo.UseVisualStyleBackColor = true;
            this.rdoNo.CheckedChanged += new System.EventHandler(this.rdoNo_CheckedChanged);
            // 
            // lstBPeriod
            // 
            this.lstBPeriod.AllowDrop = true;
            this.lstBPeriod.FormattingEnabled = true;
            this.lstBPeriod.ItemHeight = 20;
            this.lstBPeriod.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28"});
            this.lstBPeriod.Location = new System.Drawing.Point(163, 44);
            this.lstBPeriod.Name = "lstBPeriod";
            this.lstBPeriod.ScrollAlwaysVisible = true;
            this.lstBPeriod.Size = new System.Drawing.Size(120, 84);
            this.lstBPeriod.TabIndex = 17;
            this.lstBPeriod.SelectedIndexChanged += new System.EventHandler(this.lstBPeriod_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbCustomerDetails);
            this.panel1.Controls.Add(this.tbAge);
            this.panel1.Controls.Add(this.tbAddress);
            this.panel1.Controls.Add(this.tbSurname);
            this.panel1.Controls.Add(this.tbFirstName);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblSurname);
            this.panel1.Controls.Add(this.lblFname);
            this.panel1.Location = new System.Drawing.Point(48, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 129);
            this.panel1.TabIndex = 26;
            // 
            // lbCustomerDetails
            // 
            this.lbCustomerDetails.AutoSize = true;
            this.lbCustomerDetails.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerDetails.Location = new System.Drawing.Point(260, 9);
            this.lbCustomerDetails.Name = "lbCustomerDetails";
            this.lbCustomerDetails.Size = new System.Drawing.Size(165, 25);
            this.lbCustomerDetails.TabIndex = 23;
            this.lbCustomerDetails.Text = "Customer Details";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(496, 85);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(175, 26);
            this.tbAge.TabIndex = 22;
            this.tbAge.TextChanged += new System.EventHandler(this.tbAge_TextChanged);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(496, 54);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(175, 26);
            this.tbAddress.TabIndex = 21;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(158, 81);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(191, 26);
            this.tbSurname.TabIndex = 20;
            this.tbSurname.TextChanged += new System.EventHandler(this.tbSurname_TextChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(158, 52);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(191, 26);
            this.tbFirstName.TabIndex = 19;
            this.tbFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(389, 85);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 22);
            this.lblAge.TabIndex = 18;
            this.lblAge.Text = "Age";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(389, 52);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 22);
            this.lblAddress.TabIndex = 17;
            this.lblAddress.Text = "Address";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(22, 85);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(81, 22);
            this.lblSurname.TabIndex = 16;
            this.lblSurname.Text = "Surname";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(22, 54);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(99, 22);
            this.lblFname.TabIndex = 15;
            this.lblFname.Text = "First Name";
            this.lblFname.Click += new System.EventHandler(this.lblFname_Click);
            // 
            // ckl
            // 
            this.ckl.Controls.Add(this.lstOptionals);
            this.ckl.Controls.Add(this.lblRentalSpecs);
            this.ckl.Controls.Add(this.lblCartype);
            this.ckl.Controls.Add(this.lblPeriod);
            this.ckl.Controls.Add(this.lstFuel);
            this.ckl.Controls.Add(this.lblFuel);
            this.ckl.Controls.Add(this.lblExtras);
            this.ckl.Controls.Add(this.lstBPeriod);
            this.ckl.Controls.Add(this.lstCar);
            this.ckl.Location = new System.Drawing.Point(12, 213);
            this.ckl.Name = "ckl";
            this.ckl.Size = new System.Drawing.Size(814, 319);
            this.ckl.TabIndex = 27;
            this.ckl.Paint += new System.Windows.Forms.PaintEventHandler(this.ckl_Paint);
            // 
            // lstOptionals
            // 
            this.lstOptionals.FormattingEnabled = true;
            this.lstOptionals.ItemHeight = 20;
            this.lstOptionals.Items.AddRange(new object[] {
            "Unlimited Mileage",
            "Breakdown Cover"});
            this.lstOptionals.Location = new System.Drawing.Point(532, 188);
            this.lstOptionals.Name = "lstOptionals";
            this.lstOptionals.Size = new System.Drawing.Size(163, 64);
            this.lstOptionals.TabIndex = 27;
            this.lstOptionals.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // lblRentalSpecs
            // 
            this.lblRentalSpecs.AutoSize = true;
            this.lblRentalSpecs.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalSpecs.Location = new System.Drawing.Point(295, 12);
            this.lblRentalSpecs.Name = "lblRentalSpecs";
            this.lblRentalSpecs.Size = new System.Drawing.Size(197, 25);
            this.lblRentalSpecs.TabIndex = 26;
            this.lblRentalSpecs.Text = "Rental Specifications";
            // 
            // lblCartype
            // 
            this.lblCartype.AutoSize = true;
            this.lblCartype.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartype.Location = new System.Drawing.Point(12, 190);
            this.lblCartype.Name = "lblCartype";
            this.lblCartype.Size = new System.Drawing.Size(113, 22);
            this.lblCartype.TabIndex = 7;
            this.lblCartype.Text = "Type of Car: ";
            // 
            // lstFuel
            // 
            this.lstFuel.AllowDrop = true;
            this.lstFuel.FormattingEnabled = true;
            this.lstFuel.ItemHeight = 20;
            this.lstFuel.Items.AddRange(new object[] {
            "Petroleum",
            "Diesel",
            "Hybrid",
            "Full Electric"});
            this.lstFuel.Location = new System.Drawing.Point(654, 44);
            this.lstFuel.Name = "lstFuel";
            this.lstFuel.ScrollAlwaysVisible = true;
            this.lstFuel.Size = new System.Drawing.Size(120, 84);
            this.lstFuel.TabIndex = 25;
            this.lstFuel.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuel.Location = new System.Drawing.Point(553, 44);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(97, 22);
            this.lblFuel.TabIndex = 8;
            this.lblFuel.Text = "Fuel Type: ";
            // 
            // lstCar
            // 
            this.lstCar.AllowDrop = true;
            this.lstCar.FormattingEnabled = true;
            this.lstCar.ItemHeight = 20;
            this.lstCar.Items.AddRange(new object[] {
            "City Car",
            "Family Car",
            "Sports Car",
            "SUV"});
            this.lstCar.Location = new System.Drawing.Point(131, 188);
            this.lstCar.Name = "lstCar";
            this.lstCar.ScrollAlwaysVisible = true;
            this.lstCar.Size = new System.Drawing.Size(120, 84);
            this.lstCar.TabIndex = 18;
            this.lstCar.SelectedIndexChanged += new System.EventHandler(this.lstCar_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(28, 570);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 45);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(495, 570);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 41);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BookingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 640);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ckl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdoNo);
            this.Controls.Add(this.rdoYes);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.lblBookingdetails);
            this.Name = "BookingPage";
            this.Text = "BookingPage";
            this.Load += new System.EventHandler(this.BookingPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ckl.ResumeLayout(false);
            this.ckl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookingdetails;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblExtras;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.RadioButton rdoYes;
        private System.Windows.Forms.RadioButton rdoNo;
        private System.Windows.Forms.ListBox lstBPeriod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lbCustomerDetails;
        private System.Windows.Forms.Panel ckl;
        private System.Windows.Forms.Label lblRentalSpecs;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstOptionals;
        private System.Windows.Forms.Label lblCartype;
        private System.Windows.Forms.ListBox lstFuel;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.ListBox lstCar;
        private System.Windows.Forms.Button btnSave;
    }
}