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
    public partial class salesmonth : Form
    {
        string path = "OilRefinery.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\OilRefinery.db";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public salesmonth()
        {
            InitializeComponent();
            Showdata();
        }
        private void Showdata()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT SUM(Sale_Amount) FROM SELL WHERE SUBSTR(Sale_Date, 4, 2)= STRFTIME('%m', DATE('now'))";
            cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            Console.WriteLine(dr.GetInt64(0));
            salesmon.Text = dr.GetInt32(0).ToString();
            dr.Close();
            stm = "SELECT SUM(Sale_Amount) FROM SELL WHERE SUBSTR(Sale_Date, 4, 2)= STRFTIME('%m', DATE('now')) AND Product_ID = 1";
            cmd.CommandText = stm;
            dr = cmd.ExecuteReader();
            dr.Read();
            butanemon.Text = dr.GetInt32(0).ToString();
            dr.Close();
            stm = "SELECT SUM(Sale_Amount) FROM SELL WHERE SUBSTR(Sale_Date, 4, 2)= STRFTIME('%m', DATE('now')) AND Product_ID = 2";
            cmd.CommandText = stm;
            dr = cmd.ExecuteReader();
            dr.Read();
            petrolmon.Text = dr.GetInt32(0).ToString();
            dr.Close();
            stm = "SELECT SUM(Sale_Amount) FROM SELL WHERE SUBSTR(Sale_Date, 4, 2)= STRFTIME('%m', DATE('now')) AND Product_ID = 4";
            cmd.CommandText = stm;
            dr = cmd.ExecuteReader();
            dr.Read();
            keromon.Text = dr.GetInt32(0).ToString();
            dr.Close();
            stm = "SELECT SUM(Sale_Amount) FROM SELL WHERE SUBSTR(Sale_Date, 4, 2)= STRFTIME('%m', DATE('now')) AND Product_ID = 5";
            cmd.CommandText = stm;
            dr = cmd.ExecuteReader();
            dr.Read();
            dieselmon.Text = dr.GetInt32(0).ToString();
            dr.Close();
            stm = "SELECT SUM(Sale_Amount) FROM SELL WHERE SUBSTR(Sale_Date, 4, 2)= STRFTIME('%m', DATE('now')) AND Product_ID = 10";
            cmd.CommandText = stm;
            dr = cmd.ExecuteReader();
            dr.Read();
            lpgmon.Text = dr.GetInt32(0).ToString();
            dr.Close();
            stm = "SELECT SUM(Sale_Amount) FROM SELL WHERE SUBSTR(Sale_Date, 4, 2)= STRFTIME('%m', DATE('now')) AND Product_ID = 6";
            cmd.CommandText = stm;
            dr = cmd.ExecuteReader();
            dr.Read();
            lubrimon.Text = dr.GetInt32(0).ToString();
            dr.Close();
            stm = "SELECT SUM(Sale_Amount) FROM SELL WHERE SUBSTR(Sale_Date, 4, 2)= STRFTIME('%m', DATE('now')) AND Product_ID = 8";
            cmd.CommandText = stm;
            dr = cmd.ExecuteReader();
            dr.Read();
            heavymon.Text = dr.GetInt32(0).ToString();
            dr.Close();
            stm = "SELECT SUM(Sale_Amount) FROM SELL WHERE SUBSTR(Sale_Date, 4, 2)= STRFTIME('%m', DATE('now')) AND Product_ID = 9";
            cmd.CommandText = stm;
            dr = cmd.ExecuteReader();
            dr.Read();
            petromon.Text = dr.GetInt32(0).ToString();
            con.Close();
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void heavymon_Click(object sender, EventArgs e)
        {

        }

        private void petromon_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void salesmonth_Load(object sender, EventArgs e)
        {

        }

        private void salemonthclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
