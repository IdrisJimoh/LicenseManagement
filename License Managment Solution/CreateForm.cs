using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace License_Managment_Solution
{
    public partial class CreateForm : Form
    {
        Dashboard dashboardForm;
        public CreateForm(Dashboard mainF)
        {
            InitializeComponent();
            dashboardForm = mainF;
        }



        private SQLiteDataAdapter myAdapter;
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();



        private void CreateForm_Load(object sender, EventArgs e)
        {

        }



        //Set Connection
        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=lms.db; Version=3; New=False; Compression=True");
        }


        //Set ExecuteQuery
        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();

        }

        //Set Loaddb
        //public void Load_dataBase()
        //{
        //    SetConnection();
        //    sql_con.Open();
        //    sql_cmd = sql_con.CreateCommand();
        //    string commandText = "select * from newrecordtable";
        //    myAdapter = new SQLiteDataAdapter(commandText,sql_con);
        //    DS.Reset();
        //    myAdapter.Fill(DS);
        //    DT = DS.Tables[0];

        //    Dashboard myDashboard = new Dashboard();
        //    myDashboard.Datagridview1.DataSource = DT;
        //    sql_con.Close();
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard myDashboard = new Dashboard();
            this.Hide();
            myDashboard.Show();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
          

            if (SoftwareName.Text == "")
            {
                MessageBox.Show("Software Name Field Empty, Please Type Software Name");
                SoftwareName.BackColor = Color.Yellow;
                SoftwareName.Focus();
                return;
            }

            if (SoftwareVersion.Text == "")
            {
                MessageBox.Show("Software Version Field Empty, Please Type Software Version");
                SoftwareVersion.BackColor = Color.Yellow;
                SoftwareVersion.Focus();
                return;
            }

            if (CostofLicense.Text == "")
            {
                MessageBox.Show("Cost Of License Field Empty, Please Type Cost Of License");
                CostofLicense.BackColor = Color.Yellow;
                CostofLicense.Focus();
                return;
            }

            if (PurchaseDate.Text == "")
            {
                MessageBox.Show("Purchase Date Field Empty, Please Type Purchase Date");
                PurchaseDate.BackColor = Color.Yellow;
                PurchaseDate.Focus();
                return;
            }

            if (LicenseCode.Text == "")
            {
                MessageBox.Show("License Code Field Empty, Please Type License Code");
                LicenseCode.BackColor = Color.Yellow;
                LicenseCode.Focus();
                return;
            }

            if (SerialNumber.Text == "")
            {
                MessageBox.Show("Serial Number Field Empty, Please Type Serial Number");
                SerialNumber.BackColor = Color.Yellow;
                SerialNumber.Focus();
                return;
            }

            if (NumberofLicensePurchased.Text == "")
            {
                MessageBox.Show("Number Of License Purchased Field Empty, Please Type Number Of License Purchased");
                NumberofLicensePurchased.BackColor = Color.Yellow;
                NumberofLicensePurchased.Focus();
                return;
            }

            if (NumberofLicenseUsed.Text == "")
            {
                MessageBox.Show("Number Of License Used Field Empty, Please Type Number Of License Used");
                NumberofLicenseUsed.BackColor = Color.Yellow;
                NumberofLicenseUsed.Focus();
                return;
            }

            if (NumberofLicenseRemaining.Text == "")
            {
                MessageBox.Show("Number Of License Remaining Field Empty, Please Type No Of License Remaining");
                NumberofLicenseRemaining.BackColor = Color.Yellow;
                NumberofLicenseRemaining.Focus();
                return;
            }

            string query = $@"insert into newrecordtable(""SoftwareName"",""SoftwareVersion"",
            ""CostofLicense"",""PurchaseDate"",""LicenseCode"",""SerialNumber"",
            ""NumberofLicensePurchased"",""NumberofLicenseUsed"",""NumberofLicenseRemaining"") values('{SoftwareName.Text}', 
'{SoftwareVersion.Text}', {CostofLicense.Text}, '{PurchaseDate.Text}', {LicenseCode.Text}, {SerialNumber.Text}, {NumberofLicensePurchased.Text}, {NumberofLicenseUsed.Text}, {NumberofLicenseRemaining.Text})
            ";


            ExecuteQuery(query);

            dashboardForm.LoadFromDataBase();

            dashboardForm.Datagridview1.Refresh();

            MessageBox.Show("Saved successfully!");

            this.Hide();

            dashboardForm.Show();

        }

       

        private void SoftwareName_TextChanged(object sender, EventArgs e)
        {
            SoftwareName.BackColor = Color.White;
        }

        private void SoftwareVersion_TextChanged(object sender, EventArgs e)
        {
            SoftwareVersion.BackColor = Color.White;
        }

        private void CostofLicense_TextChanged(object sender, EventArgs e)
        {
            CostofLicense.BackColor = Color.White;
        }

        private void PurchaseDate_TextChanged(object sender, EventArgs e)
        {
            PurchaseDate.BackColor = Color.White;
        }

        private void LicenseCode_TextChanged(object sender, EventArgs e)
        {
            LicenseCode.BackColor = Color.White;
        }

        private void SerialNumber_TextChanged(object sender, EventArgs e)
        {
            SerialNumber.BackColor = Color.White;
        }

        private void NumberofLicensePurchased_TextChanged(object sender, EventArgs e)
        {
            NumberofLicensePurchased.BackColor = Color.White;
        }

        private void NumberofLicenseUsed_TextChanged(object sender, EventArgs e)
        {
            NumberofLicenseUsed.BackColor = Color.White;
        }

        private void NumberofLicenseRemaining_TextChanged(object sender, EventArgs e)
        {
            NumberofLicenseRemaining.BackColor = Color.White;
        }








    }
}
