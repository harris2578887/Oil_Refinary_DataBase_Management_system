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
    public partial class materialsearcher : Form
    {
        string path = "OilRefinery.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\OilRefinery.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        string searcher;
        string Key;
        public materialsearcher(string searchers, string key)
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
            if (searcher == "Plant_Name")
            {
                stm2 = "SELECT Provide.IRID, Plant.Plant_Name, Provide.Input_Quantity, Provide.Date FROM Provide, Plant WHERE Provide.PlantID = Plant.PlantID AND " + searcher + "='" + Key + "'";

            }
            else
            {
                stm2 = "SELECT Provide.IRID, Plant.Plant_Name, Provide.Input_Quantity, Provide.Date FROM Provide, Plant WHERE Provide.PlantID = Plant.PlantID AND " + searcher + "=" + Key;
            }

            Console.WriteLine(stm2);
            cmd = new SQLiteCommand(stm2, con);
            dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {


                materialdata.Rows.Insert(i, dr.GetInt32(0).ToString(), dr.GetString(1), dr.GetString(2), dr.GetString(3));
                i++;


            }
            con.Close();
        }

        private void salemonthclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
