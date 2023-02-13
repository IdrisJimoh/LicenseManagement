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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private SQLiteDataAdapter myAdapter;
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();



        //Set Connection
        

        //public void Load_dataBase()
        //{
        //    //SetConnection();
        //    sql_con.Open();
        //    sql_cmd = sql_con.CreateCommand();
        //    string commandText = "select * from newrecordtable";
        //    myAdapter = new SQLiteDataAdapter(commandText, sql_con);
        //    DS.Reset();
        //    myAdapter.Fill(DS);
        //    DT = DS.Tables[0];
        //    Datagridview1.DataSource = DT;
        //    sql_con.Close();
        //}

        private void Dashboard_Load(object sender, EventArgs e)
        {


            LoadFromDataBase();
            //CreateForm newform = new CreateForm();
            //newform.Load_dataBase();

           
           
        }
        //Set Connection
        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=lms.db; Version=3; New=False; Compression=True");
        }
        public void LoadFromDataBase()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string commandText = "select * from newrecordtable";
            myAdapter = new SQLiteDataAdapter(commandText, sql_con);
            DS.Reset();
            myAdapter.Fill(DS);
            DT = DS.Tables[0];

        //    Dashboard myDashboard = new Dashboard();
            this.Datagridview1.DataSource = DT;
            sql_con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 loginform = new Form1();
            this.Hide();
            loginform.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            CreateForm licenseform = new CreateForm(this);
            this.Hide();
            licenseform.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
