namespace License_Managment_Solution
{
    partial class Dashboard
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
            this.Datagridview1 = new System.Windows.Forms.DataGridView();
            this.DashboardLabel = new System.Windows.Forms.LinkLabel();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // Datagridview1
            // 
            this.Datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagridview1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Datagridview1.Location = new System.Drawing.Point(61, 91);
            this.Datagridview1.Name = "Datagridview1";
            this.Datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datagridview1.Size = new System.Drawing.Size(941, 317);
            this.Datagridview1.TabIndex = 3;
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.AutoSize = true;
            this.DashboardLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.DashboardLabel.Location = new System.Drawing.Point(213, 25);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(757, 60);
            this.DashboardLabel.TabIndex = 1;
            this.DashboardLabel.TabStop = true;
            this.DashboardLabel.Text = "Anwab License Management Solution";
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(148, 476);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(212, 43);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Create New License";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(425, 476);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(212, 43);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "Edit Existing License";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Location = new System.Drawing.Point(701, 476);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(212, 43);
            this.Button3.TabIndex = 7;
            this.Button3.Text = "Delete License Record";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(912, 40);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 41);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 565);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.DashboardLabel);
            this.Controls.Add(this.Datagridview1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel DashboardLabel;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.DataGridView Datagridview1;
    }
}