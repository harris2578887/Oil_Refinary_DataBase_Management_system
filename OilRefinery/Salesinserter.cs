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

    public partial class Salesinserter : Form
    {
        string path = "OilRefinery.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\OilRefinery.db";
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public Salesinserter()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection myConn = new SQLiteConnection(cs))
            {
                try
                {
                    myConn.Open();
                    string stmw = "INSERT INTO Sell(SaleID, Batch_No, Product_ID, Sale_Quantity, Sale_Amount, Sale_Date) VALUES(@id, @batch, @prodid, @quantity, @amount, @date)";
                    
                    using (SQLiteCommand sqCommand = new SQLiteCommand(stmw, myConn))
                    {
                        
                        
                        sqCommand.Parameters.AddWithValue("@id", Int32.Parse(txtid.Text));
                        sqCommand.Parameters.AddWithValue("@batch", Int32.Parse(txtbatch.Text));
                        sqCommand.Parameters.AddWithValue("@prodid", Int32.Parse(txtprod.Text));
                        sqCommand.Parameters.AddWithValue("@quantity", Int32.Parse(txtquant.Text));
                        sqCommand.Parameters.AddWithValue("@amount", Int32.Parse(txtamount.Text));
                        sqCommand.Parameters.AddWithValue("@date", txtdate.Text);
                        var res = sqCommand.ExecuteNonQuery();
                        Console.WriteLine(res);
                    }
                    myConn.Close();
                    myConn.Dispose();
                }
                catch (Exception w)
                {
                    Console.WriteLine(w);
                    // do exception handling
                }
                var con = new SQLiteConnection(cs);
                con.Open();
                string stm = "INSERT INTO Sales(SaleID, DepartmentID, Sale_Type) VALUES(@id, 1, @type)";
                cmd = new SQLiteCommand(stm, con);
                cmd.Parameters.AddWithValue("@id", txtid.Text);
                cmd.Parameters.AddWithValue("@type", txttype.Text);
                dr = cmd.ExecuteReader();
                con.Close();
                con.Dispose();
                this.Close();
            }
        }


    }
}
