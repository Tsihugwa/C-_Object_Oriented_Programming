
namespace Sprint2CET211Assignment
{
    partial class Form1
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.rdoVidNo = new System.Windows.Forms.RadioButton();
            this.rdoVidYes = new System.Windows.Forms.RadioButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbVidCall = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbRoom = new System.Windows.Forms.TextBox();
            this.lblNsId = new System.Windows.Forms.Label();
            this.tbNurseID = new System.Windows.Forms.TextBox();
            this.rdoNurseNo = new System.Windows.Forms.RadioButton();
            this.rdoNurseYes = new System.Windows.Forms.RadioButton();
            this.lblNurse = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.tbDocId = new System.Windows.Forms.TextBox();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDocID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.listViewSummary = new System.Windows.Forms.ListView();
            this.lblTime = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.DateTimePicker();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1433, 1287);
            this.btnSave.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(269, 63);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(2107, 1287);
            this.btnClear.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(238, 65);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.Location = new System.Drawing.Point(793, 1287);
            this.btnSummary.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(326, 63);
            this.btnSummary.TabIndex = 22;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbEmail);
            this.groupBox3.Controls.Add(this.rdoVidNo);
            this.groupBox3.Controls.Add(this.rdoVidYes);
            this.groupBox3.Controls.Add(this.lblEmail);
            this.groupBox3.Controls.Add(this.tbVidCall);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1886, 502);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox3.Size = new System.Drawing.Size(956, 285);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Virtual Appointment";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(333, 171);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(308, 45);
            this.tbEmail.TabIndex = 4;
            // 
            // rdoVidNo
            // 
            this.rdoVidNo.AutoSize = true;
            this.rdoVidNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVidNo.Location = new System.Drawing.Point(342, 120);
            this.rdoVidNo.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.rdoVidNo.Name = "rdoVidNo";
            this.rdoVidNo.Size = new System.Drawing.Size(105, 42);
            this.rdoVidNo.TabIndex = 3;
            this.rdoVidNo.TabStop = true;
            this.rdoVidNo.Text = "No";
            this.rdoVidNo.UseVisualStyleBackColor = true;
            this.rdoVidNo.CheckedChanged += new System.EventHandler(this.rdoVidNo_CheckedChanged);
            // 
            // rdoVidYes
            // 
            this.rdoVidYes.AutoSize = true;
            this.rdoVidYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVidYes.Location = new System.Drawing.Point(342, 51);
            this.rdoVidYes.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.rdoVidYes.Name = "rdoVidYes";
            this.rdoVidYes.Size = new System.Drawing.Size(121, 42);
            this.rdoVidYes.TabIndex = 2;
            this.rdoVidYes.TabStop = true;
            this.rdoVidYes.Text = "Yes";
            this.rdoVidYes.UseVisualStyleBackColor = true;
            this.rdoVidYes.CheckedChanged += new System.EventHandler(this.rdoVidYes_CheckedChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(32, 179);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(103, 38);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // tbVidCall
            // 
            this.tbVidCall.AutoSize = true;
            this.tbVidCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVidCall.Location = new System.Drawing.Point(22, 57);
            this.tbVidCall.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tbVidCall.Name = "tbVidCall";
            this.tbVidCall.Size = new System.Drawing.Size(175, 38);
            this.tbVidCall.TabIndex = 0;
            this.tbVidCall.Text = "Video Call";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbRoom);
            this.groupBox2.Controls.Add(this.lblNsId);
            this.groupBox2.Controls.Add(this.tbNurseID);
            this.groupBox2.Controls.Add(this.rdoNurseNo);
            this.groupBox2.Controls.Add(this.rdoNurseYes);
            this.groupBox2.Controls.Add(this.lblNurse);
            this.groupBox2.Controls.Add(this.lblRoom);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1886, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox2.Size = new System.Drawing.Size(956, 373);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "In-Person Appointment";
            // 
            // tbRoom
            // 
            this.tbRoom.Location = new System.Drawing.Point(437, 65);
            this.tbRoom.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Size = new System.Drawing.Size(308, 48);
            this.tbRoom.TabIndex = 6;
            // 
            // lblNsId
            // 
            this.lblNsId.AutoSize = true;
            this.lblNsId.Location = new System.Drawing.Point(54, 265);
            this.lblNsId.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblNsId.Name = "lblNsId";
            this.lblNsId.Size = new System.Drawing.Size(166, 40);
            this.lblNsId.TabIndex = 5;
            this.lblNsId.Text = "Nurse ID";
            // 
            // tbNurseID
            // 
            this.tbNurseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNurseID.Location = new System.Drawing.Point(434, 262);
            this.tbNurseID.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tbNurseID.Name = "tbNurseID";
            this.tbNurseID.Size = new System.Drawing.Size(308, 45);
            this.tbNurseID.TabIndex = 4;
            // 
            // rdoNurseNo
            // 
            this.rdoNurseNo.AutoSize = true;
            this.rdoNurseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNurseNo.Location = new System.Drawing.Point(434, 199);
            this.rdoNurseNo.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.rdoNurseNo.Name = "rdoNurseNo";
            this.rdoNurseNo.Size = new System.Drawing.Size(105, 42);
            this.rdoNurseNo.TabIndex = 3;
            this.rdoNurseNo.TabStop = true;
            this.rdoNurseNo.Text = "No";
            this.rdoNurseNo.UseVisualStyleBackColor = true;
            this.rdoNurseNo.CheckedChanged += new System.EventHandler(this.rdoNurseNo_CheckedChanged);
            // 
            // rdoNurseYes
            // 
            this.rdoNurseYes.AutoSize = true;
            this.rdoNurseYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNurseYes.Location = new System.Drawing.Point(434, 142);
            this.rdoNurseYes.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.rdoNurseYes.Name = "rdoNurseYes";
            this.rdoNurseYes.Size = new System.Drawing.Size(121, 42);
            this.rdoNurseYes.TabIndex = 2;
            this.rdoNurseYes.TabStop = true;
            this.rdoNurseYes.Text = "Yes";
            this.rdoNurseYes.UseVisualStyleBackColor = true;
            this.rdoNurseYes.CheckedChanged += new System.EventHandler(this.rdoNurseYes_CheckedChanged);
            // 
            // lblNurse
            // 
            this.lblNurse.AutoSize = true;
            this.lblNurse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNurse.Location = new System.Drawing.Point(54, 154);
            this.lblNurse.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblNurse.Name = "lblNurse";
            this.lblNurse.Size = new System.Drawing.Size(290, 38);
            this.lblNurse.TabIndex = 1;
            this.lblNurse.Text = "Nurse Assistance";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(54, 83);
            this.lblRoom.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(240, 38);
            this.lblRoom.TabIndex = 0;
            this.lblRoom.Text = "Room Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Time);
            this.groupBox1.Controls.Add(this.dateTime);
            this.groupBox1.Controls.Add(this.tbDocId);
            this.groupBox1.Controls.Add(this.tbDuration);
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lblDocID);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblDuration);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(330, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox1.Size = new System.Drawing.Size(1191, 618);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Details";
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(510, 276);
            this.dateTime.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(425, 45);
            this.dateTime.TabIndex = 15;
            // 
            // tbDocId
            // 
            this.tbDocId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDocId.Location = new System.Drawing.Point(510, 498);
            this.tbDocId.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tbDocId.Name = "tbDocId";
            this.tbDocId.Size = new System.Drawing.Size(425, 45);
            this.tbDocId.TabIndex = 14;
            // 
            // tbDuration
            // 
            this.tbDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDuration.Location = new System.Drawing.Point(510, 424);
            this.tbDuration.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(425, 45);
            this.tbDuration.TabIndex = 13;
            this.tbDuration.TextChanged += new System.EventHandler(this.tbDuration_TextChanged);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(510, 199);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(425, 45);
            this.tbPhone.TabIndex = 10;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(510, 122);
            this.tbName.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(425, 45);
            this.tbName.TabIndex = 9;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(510, 57);
            this.tbID.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(425, 45);
            this.tbID.TabIndex = 8;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(25, 65);
            this.lblID.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(254, 38);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Appointment ID";
            // 
            // lblDocID
            // 
            this.lblDocID.AutoSize = true;
            this.lblDocID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocID.Location = new System.Drawing.Point(25, 507);
            this.lblDocID.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblDocID.Name = "lblDocID";
            this.lblDocID.Size = new System.Drawing.Size(189, 38);
            this.lblDocID.TabIndex = 7;
            this.lblDocID.Text = "Doctor\'s ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(25, 131);
            this.lblName.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(251, 38);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Patient\'s Name";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(25, 433);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(148, 38);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Duration";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(25, 205);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(180, 38);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone No.";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(25, 282);
            this.lblDate.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(293, 38);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Appointment Date";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(792, 26);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(951, 55);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Sunderland Patients Appointment System";
            // 
            // listViewSummary
            // 
            this.listViewSummary.HideSelection = false;
            this.listViewSummary.Location = new System.Drawing.Point(173, 829);
            this.listViewSummary.Name = "listViewSummary";
            this.listViewSummary.Size = new System.Drawing.Size(2877, 413);
            this.listViewSummary.TabIndex = 25;
            this.listViewSummary.UseCompatibleStateImageBehavior = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(25, 359);
            this.lblTime.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(93, 38);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            // 
            // Time
            // 
            this.Time.CustomFormat = "HH:mm";
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Time.Location = new System.Drawing.Point(510, 349);
            this.Time.Name = "Time";
            this.Time.ShowUpDown = true;
            this.Time.Size = new System.Drawing.Size(211, 44);
            this.Time.TabIndex = 16;
            this.Time.Value = new System.DateTime(2022, 12, 24, 16, 53, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3226, 1389);
            this.Controls.Add(this.listViewSummary);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.RadioButton rdoVidNo;
        private System.Windows.Forms.RadioButton rdoVidYes;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label tbVidCall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbRoom;
        private System.Windows.Forms.Label lblNsId;
        private System.Windows.Forms.TextBox tbNurseID;
        private System.Windows.Forms.RadioButton rdoNurseNo;
        private System.Windows.Forms.RadioButton rdoNurseYes;
        private System.Windows.Forms.Label lblNurse;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox tbDocId;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDocID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView listViewSummary;
        private System.Windows.Forms.DateTimePicker Time;
        private System.Windows.Forms.Label lblTime;
    }
}

