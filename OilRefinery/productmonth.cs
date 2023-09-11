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
    public partial class productmonth : Form
    {
        string path = "OilRefinery.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\OilRefinery.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public productmonth()
        {
            InitializeComponent();
            Showdata();
        }
        private void Showdata()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT SUM(Produced_Quantity) FROM Produce WHERE SUBSTR(Date, 4, 2)= STRFTIME('%m', DATE('now'))";
            cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
            dr.Read();
       
            salesmon.Text = dr.GetInt32(0).ToString();
            dr.Close();
            stm = "SELECT SUM(Produced_Quantity) FROM Produce WHERE SUBSTR(Date, 4, 2)= STRFTIME('%m', DATE('now')) AND Product_ID = 1";
            cmd.CommandText = stm;
            dr = cmd.ExecuteReader();
            dr.Read();
            butanemon.Text = dr.GetInt32(0).ToString();
            dr.Close();
            stm = "SELECT SUM(Produced_Quantity) FROM Produce WHERE SUBSTR(Date, 4, 2)= STRFTIME('%m', DATE('now')) AND Product_ID = 2";
            cmd.CommandText = stm;
            dr = cmd.ExecuteReader();
            dr.Read();
            petrolmon.Text = dr.GetInt32(0).ToString();
            dr.Close();
            stm = "SELECT SUM(Produced_Quantity) FROM Produce WHERE SUBSTR(Date, 4, 2)= STRFTIME('%m', DATE('now')) AND Product_ID = 4";
            cmd.CommandText = stm;
            dr = cmd.ExecuteReader();
            dr.Read();
            keromon.Text = dr.GetInt32(0).ToString();
            dr.Close();
            stm = "SELECT SUM(Produced_Quantity) FROM Produce WHERE SUBSTR(Date, 4, 2)= STRFTIME('%m', DATE('now')) AND Product_ID = 5";
            cmd.CommandText = stm;
            dr = cmd.ExecuteReader();
            dr.Read();
            dieselmon.Text = dr.GetInt32(0).ToString();
            dr.Close();
            stm = "SELECT SUM(Produced_Quantity) FROM Produce WHERE SUBSTR(Date, 4, 2)= STRFTIME('%m', DATE('now')) AND Product_ID = 10";
            cmd.CommandText = stm;
            dr = cmd.ExecuteReader();
            dr.Read();
            lpgmon.Text = dr.GetInt32(0).ToString();
            dr.Close();
            stm = "SELECT SUM(Produced_Quantity) FROM Produce WHERE SUBSTR(Date, 4, 2)= STRFTIME('%m', DATE('now')) AND Product_ID = 6";
            cmd.CommandText = stm;
            dr = cmd.ExecuteReader();
            dr.Read();
            lubrimon.Text = dr.GetInt32(0).ToString();
            dr.Close();
            stm = "SELECT SUM(Produced_Quantity) FROM Produce WHERE SUBSTR(Date, 4, 2)= STRFTIME('%m', DATE('now')) AND Product_ID = 8";
            cmd.CommandText = stm;
            dr = cmd.ExecuteReader();
            dr.Read();
            heavymon.Text = dr.GetInt32(0).ToString();
            dr.Close();
            stm = "SELECT SUM(Produced_Quantity) FROM Produce WHERE SUBSTR(Date, 4, 2)= STRFTIME('%m', DATE('now')) AND Product_ID = 9";
            cmd.CommandText = stm;
            dr = cmd.ExecuteReader();
            dr.Read();
            petromon.Text = dr.GetInt32(0).ToString();
            con.Close();
        }
    }
}
