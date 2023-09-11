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
    public partial class salessearchresults : Form
    {
        string path = "OilRefinery.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\OilRefinery.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        string searcher;
        string Key;
        public salessearchresults(string searchers, string key)
        {
            InitializeComponent();
            searcher = searchers;
            Key = key;
            datashow();
        }
        public void datashow()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm2;
            Console.WriteLine(Key);
            if (Key == "Sale_Date")
            {
                stm2 = "SELECT Sell.SaleID, Sell.Batch_No, Sell.Product_ID, Sell.Sale_Quantity, Sell.Sale_Amount, Sell.Sale_Date, Products.Unit, Products.Product_Name FROM Sell, Products WHERE " + searcher + "='" + Key + "' AND Sell.Product_ID = Products.Product_ID";
            }
            else
            {
                stm2 = "SELECT Sell.SaleID, Sell.Batch_No, Sell.Product_ID, Sell.Sale_Quantity, Sell.Sale_Amount, Sell.Sale_Date, Products.Unit, Products.Product_Name FROM Sell, Products WHERE " + searcher + "=" + Key + " AND Sell.Product_ID = Products.Product_ID";
            }
            Console.WriteLine(stm2);
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
                    if (dr.GetInt32(0) == dr2.GetInt32(0))
                    {
                        salessearchdata.Rows.Insert(i, dr.GetInt32(1).ToString(), dr.GetString(7), dr2.GetString(2), dr.GetInt32(3).ToString(), dr.GetString(6), dr.GetString(5), dr.GetInt32(4).ToString());
                        i++;
                    }
                }
            }
            con.Close();
        }
        
        private void salemonthclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salessearchdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
