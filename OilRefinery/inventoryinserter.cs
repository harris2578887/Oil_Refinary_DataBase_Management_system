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
    public partial class inventoryinserter : Form
    {

        string path = "OilRefinery.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\OilRefinery.db";
        public inventoryinserter()
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
                    string stmw = "INSERT INTO Inventory(IRID, Storage_Quantity, RID, DepartmentID) VALUES(@irid, @quantity, @rid, 3)";

                    using (SQLiteCommand sqCommand = new SQLiteCommand(stmw, myConn))
                    {



                        sqCommand.Parameters.AddWithValue("@irid", Int32.Parse(txtid.Text));
                        sqCommand.Parameters.AddWithValue("@quantity", Int32.Parse(txtquant.Text));
                        sqCommand.Parameters.AddWithValue("@rid", Int32.Parse(txtrid.Text));

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
