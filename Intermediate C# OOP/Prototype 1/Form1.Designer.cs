
namespace Sprint1CET211Prototype
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDocID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.tbDocId = new System.Windows.Forms.TextBox();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbRoom = new System.Windows.Forms.TextBox();
            this.lblNsId = new System.Windows.Forms.Label();
            this.tbNurseID = new System.Windows.Forms.TextBox();
            this.rdoNurseNo = new System.Windows.Forms.RadioButton();
            this.rdoNurseYes = new System.Windows.Forms.RadioButton();
            this.lblNurse = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.rdoVidNo = new System.Windows.Forms.RadioButton();
            this.rdoVidYes = new System.Windows.Forms.RadioButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbVidCall = new System.Windows.Forms.Label();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInPerson = new System.Windows.Forms.Button();
            this.btnVirtual = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(247, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(343, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sunderland Patients Appointment System";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(8, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(94, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Appointment ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(8, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Patient\'s Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(8, 72);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(67, 13);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone No.";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(8, 99);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(108, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Appointment Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(8, 126);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(34, 13);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(8, 152);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(55, 13);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Duration";
            // 
            // lblDocID
            // 
            this.lblDocID.AutoSize = true;
            this.lblDocID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocID.Location = new System.Drawing.Point(8, 178);
            this.lblDocID.Name = "lblDocID";
            this.lblDocID.Size = new System.Drawing.Size(71, 13);
            this.lblDocID.TabIndex = 7;
            this.lblDocID.Text = "Doctor\'s ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTime);
            this.groupBox1.Controls.Add(this.tbDocId);
            this.groupBox1.Controls.Add(this.tbDuration);
            this.groupBox1.Controls.Add(this.tbTime);
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
            this.groupBox1.Location = new System.Drawing.Point(54, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 217);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Details";
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(161, 97);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(137, 20);
            this.dateTime.TabIndex = 15;
            // 
            // tbDocId
            // 
            this.tbDocId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDocId.Location = new System.Drawing.Point(161, 175);
            this.tbDocId.Name = "tbDocId";
            this.tbDocId.Size = new System.Drawing.Size(137, 20);
            this.tbDocId.TabIndex = 14;
            // 
            // tbDuration
            // 
            this.tbDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDuration.Location = new System.Drawing.Point(161, 149);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(137, 20);
            this.tbDuration.TabIndex = 13;
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTime.Location = new System.Drawing.Point(161, 123);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(137, 20);
            this.tbTime.TabIndex = 12;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(161, 70);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(137, 20);
            this.tbPhone.TabIndex = 10;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(161, 43);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(137, 20);
            this.tbName.TabIndex = 9;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(161, 20);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(137, 20);
            this.tbID.TabIndex = 8;
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
            this.groupBox2.Location = new System.Drawing.Point(507, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 131);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "In-Person Appointment";
            // 
            // tbRoom
            // 
            this.tbRoom.Location = new System.Drawing.Point(138, 23);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Size = new System.Drawing.Size(100, 21);
            this.tbRoom.TabIndex = 6;
            // 
            // lblNsId
            // 
            this.lblNsId.AutoSize = true;
            this.lblNsId.Location = new System.Drawing.Point(17, 93);
            this.lblNsId.Name = "lblNsId";
            this.lblNsId.Size = new System.Drawing.Size(63, 15);
            this.lblNsId.TabIndex = 5;
            this.lblNsId.Text = "Nurse ID";
            // 
            // tbNurseID
            // 
            this.tbNurseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNurseID.Location = new System.Drawing.Point(137, 92);
            this.tbNurseID.Name = "tbNurseID";
            this.tbNurseID.Size = new System.Drawing.Size(100, 20);
            this.tbNurseID.TabIndex = 4;
            // 
            // rdoNurseNo
            // 
            this.rdoNurseNo.AutoSize = true;
            this.rdoNurseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNurseNo.Location = new System.Drawing.Point(137, 70);
            this.rdoNurseNo.Name = "rdoNurseNo";
            this.rdoNurseNo.Size = new System.Drawing.Size(41, 17);
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
            this.rdoNurseYes.Location = new System.Drawing.Point(137, 50);
            this.rdoNurseYes.Name = "rdoNurseYes";
            this.rdoNurseYes.Size = new System.Drawing.Size(46, 17);
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
            this.lblNurse.Location = new System.Drawing.Point(17, 54);
            this.lblNurse.Name = "lblNurse";
            this.lblNurse.Size = new System.Drawing.Size(105, 13);
            this.lblNurse.TabIndex = 1;
            this.lblNurse.Text = "Nurse Assistance";
            this.lblNurse.Click += new System.EventHandler(this.lblNurse_Click);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(17, 29);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(86, 13);
            this.lblRoom.TabIndex = 0;
            this.lblRoom.Text = "Room Number";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbEmail);
            this.groupBox3.Controls.Add(this.rdoVidNo);
            this.groupBox3.Controls.Add(this.rdoVidYes);
            this.groupBox3.Controls.Add(this.lblEmail);
            this.groupBox3.Controls.Add(this.tbVidCall);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(507, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 100);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Virtual Appointment";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(105, 60);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 4;
            // 
            // rdoVidNo
            // 
            this.rdoVidNo.AutoSize = true;
            this.rdoVidNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVidNo.Location = new System.Drawing.Point(108, 42);
            this.rdoVidNo.Name = "rdoVidNo";
            this.rdoVidNo.Size = new System.Drawing.Size(41, 17);
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
            this.rdoVidYes.Location = new System.Drawing.Point(108, 18);
            this.rdoVidYes.Name = "rdoVidYes";
            this.rdoVidYes.Size = new System.Drawing.Size(46, 17);
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
            this.lblEmail.Location = new System.Drawing.Point(10, 63);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // tbVidCall
            // 
            this.tbVidCall.AutoSize = true;
            this.tbVidCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVidCall.Location = new System.Drawing.Point(7, 20);
            this.tbVidCall.Name = "tbVidCall";
            this.tbVidCall.Size = new System.Drawing.Size(64, 13);
            this.tbVidCall.TabIndex = 0;
            this.tbVidCall.Text = "Video Call";
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(3, 302);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(850, 173);
            this.lstDisplay.TabIndex = 11;
            this.lstDisplay.SelectedIndexChanged += new System.EventHandler(this.lstDisplay_SelectedIndexChanged);
            // 
            // btnSummary
            // 
            this.btnSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.Location = new System.Drawing.Point(190, 510);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(103, 22);
            this.btnSummary.TabIndex = 12;
            this.btnSummary.Text = "All Appointment";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(605, 510);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnInPerson
            // 
            this.btnInPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPerson.Location = new System.Drawing.Point(326, 504);
            this.btnInPerson.Name = "btnInPerson";
            this.btnInPerson.Size = new System.Drawing.Size(101, 34);
            this.btnInPerson.TabIndex = 15;
            this.btnInPerson.Text = "InPerson Appointments";
            this.btnInPerson.UseVisualStyleBackColor = true;
            this.btnInPerson.Click += new System.EventHandler(this.btnInPerson_Click);
            // 
            // btnVirtual
            // 
            this.btnVirtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirtual.Location = new System.Drawing.Point(458, 504);
            this.btnVirtual.Name = "btnVirtual";
            this.btnVirtual.Size = new System.Drawing.Size(101, 34);
            this.btnVirtual.TabIndex = 16;
            this.btnVirtual.Text = "Virtual Appointmnents";
            this.btnVirtual.UseVisualStyleBackColor = true;
            this.btnVirtual.Click += new System.EventHandler(this.btnVirtual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 624);
            this.Controls.Add(this.btnVirtual);
            this.Controls.Add(this.btnInPerson);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblDocID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDocId;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbNurseID;
        private System.Windows.Forms.RadioButton rdoNurseNo;
        private System.Windows.Forms.RadioButton rdoNurseYes;
        private System.Windows.Forms.Label lblNurse;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.RadioButton rdoVidNo;
        private System.Windows.Forms.RadioButton rdoVidYes;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label tbVidCall;
        private System.Windows.Forms.TextBox tbRoom;
        private System.Windows.Forms.Label lblNsId;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInPerson;
        private System.Windows.Forms.Button btnVirtual;
    }
}

