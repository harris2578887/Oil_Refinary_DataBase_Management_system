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
using OilRefinery;

namespace OilRefinery
{
    public partial class Form1 : Form
    {
        string path = "OilRefinery.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\OilRefinery.db";
        SQLiteConnection con;
        SQLiteConnection con2;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        SQLiteCommand cmd2;
        SQLiteDataReader dr2;
        int deptid;
        
        public Form1()
        {
            InitializeComponent();
            
        }
       
        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        private void GrantAccess(string user)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM Employee";
            cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if(dr.GetString(5) == user)
                {
                    deptid = dr.GetInt32(6);
                    
                }
            }
            if(deptid == 1)
            {
                new Sales(user).Show();
            }
            else if(deptid == 2)
            {
                new Production(user).Show();
            }
            else if(deptid == 3)
            {
                new Management(user).Show();
            }
            con.Close();
            con.Dispose();

        }

       

        private void loginbtn_Click(object sender, EventArgs e)
        {
            var con2 = new SQLiteConnection(cs);
            con2.Open();
            string stm = "SELECT * FROM Login";
            cmd2 = new SQLiteCommand(stm, con2);
            dr2 = cmd2.ExecuteReader();
            
            while (dr2.Read())
            {
               
                if (dr2.GetString(0) == txtusername.Text && dr2.GetString(1) == txtpassword.Text)
                {
                    Console.WriteLine("Access Granted!");
                    GrantAccess(txtusername.Text);
                    this.Hide();
                }
            }
            warn.Text = "Incorrect Username or Password";
            con2.Close();
            con2.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void warn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
        
    
}
