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
    public partial class materialinserter : Form
    {

        string path = "OilRefinery.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\OilRefinery.db";
        public materialinserter()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection myConn = new SQLiteConnection(cs))

            {

                try
                {

                    myConn.Open();
                    string stmw = "INSERT INTO Provide(IRID, PlantID, Input_Quantity, Date) VALUES(@irid, @plantid, @quantity, @date)";

                    using (SQLiteCommand sqCommand = new SQLiteCommand(stmw, myConn))
                    {



                        sqCommand.Parameters.AddWithValue("@irid", Int32.Parse(txtid.Text));
                        sqCommand.Parameters.AddWithValue("@plantid", Int32.Parse(txtplantid.Text));
                        sqCommand.Parameters.AddWithValue("@quantity", Int32.Parse(txtquantity.Text));
                        sqCommand.Parameters.AddWithValue("@date", txtdate.Text);
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

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
