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
    public partial class Production : Form
    {
        string path = "OilRefinery.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\OilRefinery.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        string username;
        User sale;
        plant p1;
        public Production(string usern)
        {
            p1 = new plant();
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
                if (dr.GetString(5) == username)
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
            string stm2 = "SELECT  Produce.Batch_No, Products.Unit, Products.Product_Name, Produce.PlantID, Produce.Produced_Quantity, Produce.Date FROM Produce, Products WHERE Produce.Product_ID = Products.Product_ID";
            cmd = new SQLiteCommand(stm2, con);
            dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {

                string stm3 = "SELECT * FROM Produce";
                SQLiteCommand cmd2 = new SQLiteCommand(stm3, con);
                SQLiteDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    if (dr.GetInt32(0) == dr2.GetInt32(0))
                    {
                        salesdata.Rows.Insert(i, dr.GetInt32(0).ToString(), dr.GetString(2), dr.GetString(1), dr.GetInt32(4).ToString(), dr.GetString(5));
                        i++;
                    }
                }
                dr2.Close();
            }

            stm = "SELECT * FROM Plant";
            cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            p1.ID = dr.GetInt32(0);
            p1.Name = dr.GetString(1);
            p1.Location = dr.GetString(2);
            p1.Capacity = dr.GetInt32(3);
            p1.yield = dr.GetDouble(4);
            p1.NoofEmps = dr.GetInt32(5);
            dr.Close();
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
            txtuser.Text = sale.getUsername();
            txtcontact.Text = sale.getContact().ToString();
            txtdeptid.Text = sale.getDeptid().ToString();

            txtpname.Text = p1.Name;
            txtcapacity.Text = p1.Capacity.ToString();
            txtyield.Text = p1.yield.ToString();
            txtloc.Text = p1.Location;
            txtemps.Text = p1.NoofEmps.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void salesdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchsales_Click(object sender, EventArgs e)
        {
            string Key = txtsearcher.Text;
            string searchers = searcher.SelectedItem.ToString();
            new productsearcher(searchers, Key).Show();
        }

        private void insertsales_Click(object sender, EventArgs e)
        {
            
            new productinserter().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new productmonth().Show();
        }
    }
}
