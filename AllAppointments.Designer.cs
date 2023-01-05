
namespace IntermediateSoftwareDevelopmentPrototype1
{
    partial class AllAppointments
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lstAllApp = new System.Windows.Forms.ListView();
            this.rdoInPerson = new System.Windows.Forms.RadioButton();
            this.rdoVirtualApp = new System.Windows.Forms.RadioButton();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.checkBoxAllApp = new System.Windows.Forms.CheckBox();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(1025, 64);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1171, 69);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Sunderland Patients Appointment System";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(2666, 1252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(211, 71);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(805, 1231);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(405, 71);
            this.btnNew.TabIndex = 29;
            this.btnNew.Text = "New Appointment";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lstAllApp
            // 
            this.lstAllApp.HideSelection = false;
            this.lstAllApp.Location = new System.Drawing.Point(116, 286);
            this.lstAllApp.Name = "lstAllApp";
            this.lstAllApp.Size = new System.Drawing.Size(3078, 860);
            this.lstAllApp.TabIndex = 30;
            this.lstAllApp.UseCompatibleStateImageBehavior = false;
            // 
            // rdoInPerson
            // 
            this.rdoInPerson.AutoSize = true;
            this.rdoInPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoInPerson.Location = new System.Drawing.Point(28, 22);
            this.rdoInPerson.Name = "rdoInPerson";
            this.rdoInPerson.Size = new System.Drawing.Size(207, 41);
            this.rdoInPerson.TabIndex = 31;
            this.rdoInPerson.TabStop = true;
            this.rdoInPerson.Text = "In-Person";
            this.rdoInPerson.UseVisualStyleBackColor = true;
            this.rdoInPerson.CheckedChanged += new System.EventHandler(this.rdoInPerson_CheckedChanged);
            // 
            // rdoVirtualApp
            // 
            this.rdoVirtualApp.AutoSize = true;
            this.rdoVirtualApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVirtualApp.Location = new System.Drawing.Point(338, 22);
            this.rdoVirtualApp.Name = "rdoVirtualApp";
            this.rdoVirtualApp.Size = new System.Drawing.Size(379, 41);
            this.rdoVirtualApp.TabIndex = 32;
            this.rdoVirtualApp.TabStop = true;
            this.rdoVirtualApp.Text = "Virtual Appointments\r\n";
            this.rdoVirtualApp.UseVisualStyleBackColor = true;
            this.rdoVirtualApp.CheckedChanged += new System.EventHandler(this.rdoVirtualApp_CheckedChanged);
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.rdoInPerson);
            this.panelFilter.Controls.Add(this.rdoVirtualApp);
            this.panelFilter.Location = new System.Drawing.Point(2432, 188);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(732, 77);
            this.panelFilter.TabIndex = 33;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(2443, 145);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(346, 40);
            this.lblFilter.TabIndex = 34;
            this.lblFilter.Text = "Filter Appointments";
            // 
            // checkBoxAllApp
            // 
            this.checkBoxAllApp.AutoSize = true;
            this.checkBoxAllApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllApp.Location = new System.Drawing.Point(255, 210);
            this.checkBoxAllApp.Name = "checkBoxAllApp";
            this.checkBoxAllApp.Size = new System.Drawing.Size(349, 44);
            this.checkBoxAllApp.TabIndex = 35;
            this.checkBoxAllApp.Text = "All Appointments";
            this.checkBoxAllApp.UseVisualStyleBackColor = true;
            this.checkBoxAllApp.CheckedChanged += new System.EventHandler(this.checkBoxAllApp_CheckedChanged);
            // 
            // AllAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3365, 1415);
            this.Controls.Add(this.checkBoxAllApp);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.lstAllApp);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Name = "AllAppointments";
            this.Text = "AllAppointments";
            this.Load += new System.EventHandler(this.AllAppointments_Load);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ListView lstAllApp;
        private System.Windows.Forms.RadioButton rdoInPerson;
        private System.Windows.Forms.RadioButton rdoVirtualApp;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.CheckBox checkBoxAllApp;
    }
}