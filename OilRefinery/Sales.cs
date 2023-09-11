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

namespace OilRefinery
{
    public partial class Sales : Form
    {
        string path = "OilRefinery.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\OilRefinery.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        string username;
        User sale;
        public Sales(string usern)
        {
            sale = new User();
            username = usern;
            InitializeComponent();
            displayinfo();
            
        }

        private void displayinfo()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM Employee";
            cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if(dr.GetString(5) == username)
                {
                    sale.setid(dr.GetInt32(0));
                    sale.setName(dr.GetString(1));
                    sale.setEmail(dr.GetString(2));
                    sale.setContact(dr.GetInt64(3));
                    sale.setSalary(dr.GetInt32(4));
                    sale.setUsername(dr.GetString(5));
                    sale.setDeptid(dr.GetInt32(6));
                   
                }
            }
            string stm2 = "SELECT Sell.SaleID, Sell.Batch_No, Sell.Product_ID, Sell.Sale_Quantity, Sell.Sale_Amount, Sell.Sale_Date, Products.Unit, Products.Product_Name FROM Sell, Products WHERE Sell.Product_ID = Products.Product_ID";
            cmd = new SQLiteCommand(stm2, con);
            dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                
                string stm3 = "SELECT * FROM Sales";
                SQLiteCommand cmd2 = new SQLiteCommand(stm3, con);
                SQLiteDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    if(dr.GetInt32(0) == dr2.GetInt32(0))
                    {
                        salesdata.Rows.Insert(i, dr.GetInt32(1).ToString(), dr.GetString(7), dr2.GetString(2), dr.GetInt32(3).ToString(),dr.GetString(6), dr.GetString(5), dr.GetInt32(4).ToString());
                        i++;
                    }
                }
            }
            con.Close();
            con.Dispose();
            Setdata();
        }
        private void Setdata()
        {
            txtname.Text = sale.getName().ToString();
            txtid.Text = sale.getid().ToString();
            txtemail.Text = sale.getEmail();
            txtdept.Text = sale.getdeptname();
            txtsalary.Text = sale.getSalary().ToString();
            txtusername.Text = sale.getUsername();
            txtcontact.Text = sale.getContact().ToString();
            txtdeptid.Text = sale.getDeptid().ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new salesmonth().Show();
        }

        private void searchsales_Click(object sender, EventArgs e)
        {
            string Key = txtsearcher.Text;
            string searchers = searcher.SelectedItem.ToString();
            new salessearchresults(searchers, Key).Show();
        }

        private void insertsales_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Close();
                
            }
            new Salesinserter().Show();
        }
    }
}
