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
    public partial class supplyinserter : Form
    {
        string path = "OilRefinery.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\OilRefinery.db";
        public supplyinserter()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtcity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection myConn = new SQLiteConnection(cs))

            {

                try
                {

                    myConn.Open();
                    string stmw = "INSERT INTO Supply(RID, Supplier_ID, Supply_Quantity, Supply_Date, Supply_Amount) VALUES(@rid, @supid, @quantity, @date, @amount)";

                    using (SQLiteCommand sqCommand = new SQLiteCommand(stmw, myConn))
                    {



                        sqCommand.Parameters.AddWithValue("@rid", Int32.Parse(txtid.Text));
                        sqCommand.Parameters.AddWithValue("@supid", Int32.Parse(txtsuppid.Text));
                        sqCommand.Parameters.AddWithValue("@quantity", txtquant.Text);
                        sqCommand.Parameters.AddWithValue("@date", txtdate.Text);
                        sqCommand.Parameters.AddWithValue("@amount", Int32.Parse(txtamount.Text));

                        var res = sqCommand.ExecuteNonQuery();

                    }
                    myConn.Close();
                    myConn.Dispose();

                }
                catch (Exception w)
                {
                    Console.WriteLine(w);
                    // do exception handling
                }


                this.Close();
            }
        }
    }
}
