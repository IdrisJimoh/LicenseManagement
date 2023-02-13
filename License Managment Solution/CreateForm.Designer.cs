namespace License_Managment_Solution
{
    partial class CreateForm
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.SerialNumber = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.LicenseCode = new System.Windows.Forms.TextBox();
            this.SoftwareName = new System.Windows.Forms.TextBox();
            this.PurchaseDate = new System.Windows.Forms.TextBox();
            this.SoftwareVersion = new System.Windows.Forms.TextBox();
            this.CostofLicense = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.NumberofLicenseRemaining = new System.Windows.Forms.TextBox();
            this.NumberofLicenseUsed = new System.Windows.Forms.TextBox();
            this.NumberofLicensePurchased = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(271, 801);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(388, 52);
            this.SubmitButton.TabIndex = 21;
            this.SubmitButton.Text = "Submit Software Details";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(521, 4);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(384, 54);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "License Details Entry";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(853, 315);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(156, 32);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "License Code";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(853, 212);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(167, 32);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "Purchase Date";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(853, 116);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(176, 32);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Cost of License";
            // 
            // SerialNumber
            // 
            this.SerialNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumber.Location = new System.Drawing.Point(572, 453);
            this.SerialNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(291, 34);
            this.SerialNumber.TabIndex = 14;
            this.SerialNumber.TextChanged += new System.EventHandler(this.SerialNumber_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(373, 315);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(193, 32);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Software Version";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(391, 212);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(179, 32);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Software Name";
            // 
            // LicenseCode
            // 
            this.LicenseCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseCode.Location = new System.Drawing.Point(799, 350);
            this.LicenseCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LicenseCode.Name = "LicenseCode";
            this.LicenseCode.Size = new System.Drawing.Size(291, 34);
            this.LicenseCode.TabIndex = 12;
            this.LicenseCode.TextChanged += new System.EventHandler(this.LicenseCode_TextChanged);
            // 
            // SoftwareName
            // 
            this.SoftwareName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftwareName.Location = new System.Drawing.Point(337, 246);
            this.SoftwareName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SoftwareName.Name = "SoftwareName";
            this.SoftwareName.Size = new System.Drawing.Size(291, 34);
            this.SoftwareName.TabIndex = 4;
            this.SoftwareName.TextChanged += new System.EventHandler(this.SoftwareName_TextChanged);
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseDate.Location = new System.Drawing.Point(799, 246);
            this.PurchaseDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.Size = new System.Drawing.Size(291, 34);
            this.PurchaseDate.TabIndex = 10;
            this.PurchaseDate.TextChanged += new System.EventHandler(this.PurchaseDate_TextChanged);
            // 
            // SoftwareVersion
            // 
            this.SoftwareVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftwareVersion.Location = new System.Drawing.Point(337, 350);
            this.SoftwareVersion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SoftwareVersion.Name = "SoftwareVersion";
            this.SoftwareVersion.Size = new System.Drawing.Size(291, 34);
            this.SoftwareVersion.TabIndex = 6;
            this.SoftwareVersion.TextChanged += new System.EventHandler(this.SoftwareVersion_TextChanged);
            // 
            // CostofLicense
            // 
            this.CostofLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostofLicense.Location = new System.Drawing.Point(799, 150);
            this.CostofLicense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CostofLicense.Name = "CostofLicense";
            this.CostofLicense.Size = new System.Drawing.Size(291, 34);
            this.CostofLicense.TabIndex = 8;
            this.CostofLicense.TextChanged += new System.EventHandler(this.CostofLicense_TextChanged);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(536, 662);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(337, 32);
            this.Label10.TabIndex = 19;
            this.Label10.Text = "Number of License Remaining";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(784, 558);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(277, 32);
            this.Label9.TabIndex = 17;
            this.Label9.Text = "Number of License Used";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(300, 558);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(333, 32);
            this.Label8.TabIndex = 15;
            this.Label8.Text = "Number of License Purchased";
            // 
            // NumberofLicenseRemaining
            // 
            this.NumberofLicenseRemaining.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberofLicenseRemaining.Location = new System.Drawing.Point(536, 697);
            this.NumberofLicenseRemaining.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumberofLicenseRemaining.Name = "NumberofLicenseRemaining";
            this.NumberofLicenseRemaining.Size = new System.Drawing.Size(349, 34);
            this.NumberofLicenseRemaining.TabIndex = 20;
            this.NumberofLicenseRemaining.TextChanged += new System.EventHandler(this.NumberofLicenseRemaining_TextChanged);
            // 
            // NumberofLicenseUsed
            // 
            this.NumberofLicenseUsed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberofLicenseUsed.Location = new System.Drawing.Point(761, 592);
            this.NumberofLicenseUsed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumberofLicenseUsed.Name = "NumberofLicenseUsed";
            this.NumberofLicenseUsed.Size = new System.Drawing.Size(349, 34);
            this.NumberofLicenseUsed.TabIndex = 18;
            this.NumberofLicenseUsed.TextChanged += new System.EventHandler(this.NumberofLicenseUsed_TextChanged);
            // 
            // NumberofLicensePurchased
            // 
            this.NumberofLicensePurchased.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberofLicensePurchased.Location = new System.Drawing.Point(300, 592);
            this.NumberofLicensePurchased.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumberofLicensePurchased.Name = "NumberofLicensePurchased";
            this.NumberofLicensePurchased.Size = new System.Drawing.Size(349, 34);
            this.NumberofLicensePurchased.TabIndex = 16;
            this.NumberofLicensePurchased.TextChanged += new System.EventHandler(this.NumberofLicensePurchased_TextChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(617, 417);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(168, 32);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "Serial Number";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(713, 801);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(388, 52);
            this.button1.TabIndex = 22;
            this.button1.Text = "Back To License Records";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 884);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.NumberofLicenseRemaining);
            this.Controls.Add(this.NumberofLicenseUsed);
            this.Controls.Add(this.NumberofLicensePurchased);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.SerialNumber);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.LicenseCode);
            this.Controls.Add(this.SoftwareName);
            this.Controls.Add(this.PurchaseDate);
            this.Controls.Add(this.SoftwareVersion);
            this.Controls.Add(this.CostofLicense);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.SubmitButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateForm";
            this.Load += new System.EventHandler(this.CreateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox SerialNumber;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox LicenseCode;
        private System.Windows.Forms.TextBox SoftwareName;
        private System.Windows.Forms.TextBox PurchaseDate;
        private System.Windows.Forms.TextBox SoftwareVersion;
        private System.Windows.Forms.TextBox CostofLicense;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.TextBox NumberofLicenseRemaining;
        private System.Windows.Forms.TextBox NumberofLicenseUsed;
        private System.Windows.Forms.TextBox NumberofLicensePurchased;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Button button1;
    }
}