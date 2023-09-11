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
    public partial class supplysearcher : Form
    {
        string path = "OilRefinery.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\OilRefinery.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        string searcher;
        string Key;
        public supplysearcher(string searchers, string key)
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
            if (searcher == "Supplier_ID")
            {
                stm2 = "SELECT RawMaterial.RName, Supplier.Supplier_Name, Supply.Supply_Quantity, Supply.Supply_Date, Supply.Supply_Amount FROM Supply JOIN RawMaterial ON Supply.RID = RawMaterial.RID JOIN Supplier ON Supply.Supplier_ID = Supplier.Supplier_ID WHERE " + searcher + "=" + Key;
                

            }
            else
            {
                stm2 = "SELECT RawMaterial.RName, Supplier.Supplier_Name, Supply.Supply_Quantity, Supply.Supply_Date, Supply.Supply_Amount FROM Supply JOIN RawMaterial ON Supply.RID = RawMaterial.RID JOIN Supplier ON Supply.Supplier_ID = Supplier.Supplier_ID WHERE " + searcher + "='" + Key + "'";
            }

            Console.WriteLine(stm2);
            cmd = new SQLiteCommand(stm2, con);
            dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {



                supplydata.Rows.Insert(i, (i + 1).ToString(), dr.GetString(1), dr.GetString(0), dr.GetString(2), dr.GetInt32(4).ToString(), dr.GetString(3));
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
