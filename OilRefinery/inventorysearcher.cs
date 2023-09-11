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
    public partial class inventorysearcher : Form
    {
        string path = "OilRefinery.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\OilRefinery.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        string searcher;
        string Key;
        public inventorysearcher(string searchers, string key)
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
            if (searcher == "RName")
            {
                stm2 = "SELECT Inventory.IRID, Inventory.Storage_Quantity, RawMaterial.RName FROM Inventory, RawMaterial WHERE Inventory.RID = RawMaterial.RID AND " + searcher + "='" + Key + "'";

            }
            else {
                stm2 = "SELECT Inventory.IRID, Inventory.Storage_Quantity, RawMaterial.RName FROM Inventory, RawMaterial WHERE Inventory.RID = RawMaterial.RID AND " + searcher + "=" + Key;
            }
            
            Console.WriteLine(stm2);
            cmd = new SQLiteCommand(stm2, con);
            dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {


                inventorydata.Rows.Insert(i, dr.GetInt32(0).ToString(), dr.GetString(2), dr.GetString(1));
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
