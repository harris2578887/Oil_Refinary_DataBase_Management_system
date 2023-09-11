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
    public partial class supplierinserter : Form
    {
        string path = "OilRefinery.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\OilRefinery.db";
        public supplierinserter()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtrid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtquant_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection myConn = new SQLiteConnection(cs))

            {

                try
                {

                    myConn.Open();
                    string stmw = "INSERT INTO Supplier(Supplier_ID, Supplier_Name, Certificate_No, Supplier_Contact, City) VALUES(@id, @name, @cert, @contact, @city)";

                    using (SQLiteCommand sqCommand = new SQLiteCommand(stmw, myConn))
                    {



                        sqCommand.Parameters.AddWithValue("@id", Int32.Parse(txtid.Text));
                        sqCommand.Parameters.AddWithValue("@name", txtname.Text);
                        sqCommand.Parameters.AddWithValue("@cert", Int32.Parse(txtcert.Text));
                        sqCommand.Parameters.AddWithValue("@contact", Int64.Parse(txtcontact.Text));
                        sqCommand.Parameters.AddWithValue("@city", txtcity.Text);

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
