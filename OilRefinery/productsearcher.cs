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
    public partial class productsearcher : Form
    {
        string path = "OilRefinery.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\OilRefinery.db";
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        string searcher;
        string Key;
        public productsearcher(string searchers, string key)
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
            if (searcher == "Date")
            {
                stm2 = "SELECT Produce.Batch_No, Produce.Produced_Quantity, Produce.Date, Products.Product_Name, Products.Unit FROM Produce, Products WHERE Produce.Product_ID = Products.Product_ID AND " + searcher + "='" + Key + "'";
            }
            else if(searcher == "Product_Name")
            {
                stm2 = "SELECT Produce.Batch_No, Produce.Produced_Quantity, Produce.Date, Products.Product_Name, Products.Unit FROM Produce, Products WHERE Produce.Product_ID = Products.Product_ID AND Products." + searcher + "='" + Key + "'";
            }
            else
            {
                stm2 = "SELECT Produce.Batch_No, Produce.Produced_Quantity, Produce.Date, Products.Product_Name, Products.Unit FROM Produce, Products WHERE Produce.Product_ID = Products.Product_ID AND " + searcher + "=" + Key;
            }
            Console.WriteLine(stm2);
            cmd = new SQLiteCommand(stm2, con);
            dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                
                  productsearchdata.Rows.Insert(i, dr.GetInt32(0).ToString(), dr.GetString(3), dr.GetString(4), dr.GetInt32(1).ToString(), dr.GetString(2));
                  i++;
                    
                
            }
            con.Close();
        }
        private void salemonthclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
