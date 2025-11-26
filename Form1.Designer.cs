namespace Program1
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtCarType = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblWorkHours = new System.Windows.Forms.Label();
            this.txtWorkHours = new System.Windows.Forms.TextBox();
            this.lblPartsCost = new System.Windows.Forms.Label();
            this.txtPartsCost = new System.Windows.Forms.TextBox();
            this.lblStaffAssigned = new System.Windows.Forms.Label();
            this.txtStaffAssigned = new System.Windows.Forms.TextBox();
            this.lblSeniorCitizen = new System.Windows.Forms.Label();
            this.txtSeniorCitizen = new System.Windows.Forms.TextBox();
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWelcome.Location = new System.Drawing.Point(189, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(201, 18);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Smiths Auto Repair!";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(126, 52);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(80, 16);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Client Name";
            // 
            // txtCarType
            // 
            this.txtCarType.Location = new System.Drawing.Point(312, 77);
            this.txtCarType.Name = "txtCarType";
            this.txtCarType.Size = new System.Drawing.Size(100, 22);
            this.txtCarType.TabIndex = 2;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(312, 49);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(100, 22);
            this.txtClientName.TabIndex = 3;
            this.txtClientName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Location = new System.Drawing.Point(126, 77);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(63, 16);
            this.lblCarType.TabIndex = 4;
            this.lblCarType.Text = "Car Type";
            // 
            // lblWorkHours
            // 
            this.lblWorkHours.AutoSize = true;
            this.lblWorkHours.Location = new System.Drawing.Point(126, 112);
            this.lblWorkHours.Name = "lblWorkHours";
            this.lblWorkHours.Size = new System.Drawing.Size(78, 16);
            this.lblWorkHours.TabIndex = 5;
            this.lblWorkHours.Text = "Work Hours";
            // 
            // txtWorkHours
            // 
            this.txtWorkHours.Location = new System.Drawing.Point(312, 112);
            this.txtWorkHours.Name = "txtWorkHours";
            this.txtWorkHours.Size = new System.Drawing.Size(100, 22);
            this.txtWorkHours.TabIndex = 6;
            // 
            // lblPartsCost
            // 
            this.lblPartsCost.AutoSize = true;
            this.lblPartsCost.Location = new System.Drawing.Point(121, 146);
            this.lblPartsCost.Name = "lblPartsCost";
            this.lblPartsCost.Size = new System.Drawing.Size(68, 16);
            this.lblPartsCost.TabIndex = 7;
            this.lblPartsCost.Text = "Parts Cost";
            // 
            // txtPartsCost
            // 
            this.txtPartsCost.Location = new System.Drawing.Point(312, 140);
            this.txtPartsCost.Name = "txtPartsCost";
            this.txtPartsCost.Size = new System.Drawing.Size(100, 22);
            this.txtPartsCost.TabIndex = 8;
            // 
            // lblStaffAssigned
            // 
            this.lblStaffAssigned.AutoSize = true;
            this.lblStaffAssigned.Location = new System.Drawing.Point(121, 177);
            this.lblStaffAssigned.Name = "lblStaffAssigned";
            this.lblStaffAssigned.Size = new System.Drawing.Size(93, 16);
            this.lblStaffAssigned.TabIndex = 9;
            this.lblStaffAssigned.Text = "Staff Assigned";
            // 
            // txtStaffAssigned
            // 
            this.txtStaffAssigned.Location = new System.Drawing.Point(312, 171);
            this.txtStaffAssigned.Name = "txtStaffAssigned";
            this.txtStaffAssigned.Size = new System.Drawing.Size(100, 22);
            this.txtStaffAssigned.TabIndex = 10;
            this.txtStaffAssigned.TextChanged += new System.EventHandler(this.txtStaffAssigned4_TextChanged);
            // 
            // lblSeniorCitizen
            // 
            this.lblSeniorCitizen.AutoSize = true;
            this.lblSeniorCitizen.Location = new System.Drawing.Point(121, 209);
            this.lblSeniorCitizen.Name = "lblSeniorCitizen";
            this.lblSeniorCitizen.Size = new System.Drawing.Size(143, 16);
            this.lblSeniorCitizen.TabIndex = 11;
            this.lblSeniorCitizen.Text = "\"Senior Citizen? (0 or 1)";
            // 
            // txtSeniorCitizen
            // 
            this.txtSeniorCitizen.Location = new System.Drawing.Point(312, 209);
            this.txtSeniorCitizen.Name = "txtSeniorCitizen";
            this.txtSeniorCitizen.Size = new System.Drawing.Size(100, 22);
            this.txtSeniorCitizen.TabIndex = 12;
            this.txtSeniorCitizen.TextChanged += new System.EventHandler(this.txtSeniorCitizen_TextChanged);
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Location = new System.Drawing.Point(217, 248);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(132, 23);
            this.btnGetQuote.TabIndex = 13;
            this.btnGetQuote.Text = "Get Quote!";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            this.btnGetQuote.Click += new System.EventHandler(this.btnGetQuote_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(146, 278);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(68, 16);
            this.lblTotalCost.TabIndex = 14;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Enabled = false;
            this.txtTotalCost.Location = new System.Drawing.Point(331, 278);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(100, 22);
            this.txtTotalCost.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.btnGetQuote);
            this.Controls.Add(this.txtSeniorCitizen);
            this.Controls.Add(this.lblSeniorCitizen);
            this.Controls.Add(this.txtStaffAssigned);
            this.Controls.Add(this.lblStaffAssigned);
            this.Controls.Add(this.txtPartsCost);
            this.Controls.Add(this.lblPartsCost);
            this.Controls.Add(this.txtWorkHours);
            this.Controls.Add(this.lblWorkHours);
            this.Controls.Add(this.lblCarType);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.txtCarType);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.label1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txtCarType;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.Label lblWorkHours;
        private System.Windows.Forms.TextBox txtWorkHours;
        private System.Windows.Forms.Label lblPartsCost;
        private System.Windows.Forms.TextBox txtPartsCost;
        private System.Windows.Forms.Label lblStaffAssigned;
        private System.Windows.Forms.TextBox txtStaffAssigned;
        private System.Windows.Forms.Label lblSeniorCitizen;
        private System.Windows.Forms.TextBox txtSeniorCitizen;
        private System.Windows.Forms.Button btnGetQuote;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox txtTotalCost;
    }
}

