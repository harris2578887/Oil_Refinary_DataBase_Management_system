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
    public partial class Management : Form
    {
        string path = "OilRefinery.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\OilRefinery.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        string username;
        User sale;
        public Management(string usern)
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

            //For Inventory
            string stm2 = "SELECT Inventory.IRID, Inventory.Storage_Quantity, RawMaterial.RName FROM Inventory, RawMaterial WHERE Inventory.RID = RawMaterial.RID";
            cmd = new SQLiteCommand(stm2, con);
            dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
            
                inventorydata.Rows.Insert(i, dr.GetInt32(0).ToString(), dr.GetString(2), dr.GetString(1));
                i++;
                    
                
            }

            //For Suppliers
            stm2 = "SELECT * FROM Supplier";
            cmd = new SQLiteCommand(stm2, con);
            dr = cmd.ExecuteReader();
            i = 0;
            while (dr.Read())
            {
               
                supplierdata.Rows.Insert(i, dr.GetInt32(0).ToString(), dr.GetString(1), dr.GetInt64(3).ToString(), dr.GetInt32(2).ToString(), dr.GetString(4));
                i++;
                
            }

            //For Used Materials
            stm2 = "SELECT Provide.IRID, Plant.Plant_Name, Provide.Input_Quantity, Provide.Date FROM Provide, Plant WHERE Provide.PlantID = Plant.PlantID";
            cmd = new SQLiteCommand(stm2, con);
            dr = cmd.ExecuteReader();
            i = 0;
            while (dr.Read())
            {

                materialdata.Rows.Insert(i, dr.GetInt32(0).ToString(), dr.GetString(1), dr.GetString(2), dr.GetString(3));
                i++;

            }

            //For Used Supply
            stm2 = "SELECT RawMaterial.RName, Supplier.Supplier_Name, Supply.Supply_Quantity, Supply.Supply_Date, Supply.Supply_Amount FROM Supply JOIN RawMaterial ON Supply.RID = RawMaterial.RID JOIN Supplier ON Supply.Supplier_ID = Supplier.Supplier_ID";
            cmd = new SQLiteCommand(stm2, con);
            dr = cmd.ExecuteReader();
            i = 0;
            while (dr.Read())
            {

                supplydata.Rows.Insert(i, (i+1).ToString(), dr.GetString(1), dr.GetString(0), dr.GetString(2), dr.GetInt32(4).ToString(), dr.GetString(3));
                i++;

            }
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
        }

        private void searchsales_Click(object sender, EventArgs e)
        {
            new inventorysearcher(searcher.Text, txtsearcher.Text).Show();
        }

        private void insertsales_Click(object sender, EventArgs e)
        {
            new inventoryinserter().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new suppliersearcher(supsearcher.Text, supkey.Text).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new supplierinserter().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new materialsearcher(matsearcher.Text, matkey.Text).Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new materialinserter().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new supplysearcher(supplysearcher.Text, supplykey.Text).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new supplyinserter().Show();
        }
    }
}
