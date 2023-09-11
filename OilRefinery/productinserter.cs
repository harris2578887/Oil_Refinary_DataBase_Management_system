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
    public partial class productinserter : Form
    {
        string path = "OilRefinery.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\OilRefinery.db";
        
        public productinserter()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtdate_TextChanged(object sender, EventArgs e)
        {

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
                        string stmw = "INSERT INTO Produce(Product_ID, PlantID, Batch_No, Produced_Quantity, Date) VALUES(@prodid, @plantid, @batch, @quantity, @date)";

                        using (SQLiteCommand sqCommand = new SQLiteCommand(stmw, myConn))
                        {



                            sqCommand.Parameters.AddWithValue("@prodid", Int32.Parse(txtid.Text));
                            sqCommand.Parameters.AddWithValue("@batch", Int32.Parse(txtbatch.Text));
                            sqCommand.Parameters.AddWithValue("@plantid", Int32.Parse(txtplant.Text));
                            sqCommand.Parameters.AddWithValue("@quantity", txtquant.Text);
                            sqCommand.Parameters.AddWithValue("@date", ("'" + txtdate.Text + "'"));
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


                    this.Close();
                }
        }
    }
}

