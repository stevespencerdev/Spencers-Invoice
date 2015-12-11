using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Invoice
{
    public partial class SearchInvoice : Form
    {
        public SearchInvoice()
        {
            InitializeComponent();
            SearchFill();
            
           
            
        }

        void SearchFill() // filling email address drop down with what's in sql 
        {
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                SqlCommand cmd = new SqlCommand("SELECT * FROM DropDown", con);
                SqlDataReader dr;


                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        NameSearchcomboBox.Items.Add(dr["FullName"]);

                    }

                }
                catch
                {

                }

                finally
                {
                    con.Close();

                }


            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NamePaymentcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT InvoiceNumber, Discription, PreviousBal, NewTotalBal, InvoiceDate, TotalPaid FROM Invoice WHERE (Name = '" + NameSearchcomboBox.Text + "')", con);
                //SqlDataAdapter sda = new SqlDataAdapter("SELECT *  FROM Invoice WHERE (InvoiceNumber = '" + InvoiceNumbercomboBox.Text + "')", con);
                //SqlDataAdapter sda = new SqlDataAdapter("SELECT InvoiceNumber FROM Invoice WHERE (InvoiceNumber = '" + NamePaymentcomboBox.Text + "')", con);
                // ("select * from Invoice", con searchtbx);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                SearchInvoicedataGridView.DataSource = dt;
                con.Close();

                try
                {
                    con.Close();
                }
                catch
                { }

                finally
                {
                    con.Close();
                }

                if (NameSearchcomboBox.SelectedItem != null)
                {

                    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Invoice WHERE (Name = '" + NameSearchcomboBox.Text + "')", con);
                    SqlDataReader dr;


                    try
                    {
                        con.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {


                            SearchInvoiceNumbercomboBox.Items.Add(dr["InvoiceNumber"]);

                            //comboBoxemailtst.Items.Add(dr["Email"]);



                        }
                    }
                    catch
                    {

                    }
                    finally
                    {
                        con.Close();
                        SearchInvoiceNumbercomboBox.Text = string.Empty;
                    }
                }
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT *  FROM Invoice WHERE (InvoiceNumber = '" + SearchInvoiceNumbercomboBox.Text + "')", con);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            SearchInvoicedataGridView.DataSource = dt;
            con.Close();

            try
            {
                con.Close();
            }
            catch
            { }

            finally
            {
                con.Close();
            }
        }

        private void Importbutton_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
            SqlCommand cmd = new SqlCommand("SELECT *  FROM Invoice WHERE (InvoiceNumber = '" + SearchInvoiceNumbercomboBox.Text + "')", con);
            SqlDataReader dr;


            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {


                    ActivitylistBox.Items.Add(dr["Discription"]);
                    DatelistBox.Items.Add(dr["InvoiceDate"]);
                    InvoicelistBox.Items.Add(dr["InvoiceNumber"]);
                    InvoiceidlistBox.Items.Add(dr["idInvoice"]);
                    PrevBallistBox.Items.Add(dr["PreviousBal"]);
                    TotalDuelistBox.Items.Add(dr["NewTotalBal"]);
                   // listBox1.Items.Add(dr["InvoiceNumber"]);
                }
            }
            catch
            {

            }
            
            SearchInvoiceNumbercomboBox.Items.Clear();
           
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE Invoice 
                SET Discription= '" + ActivityEdittextBox.Text + "' WHERE (InvoiceNumber = '" + invoicenumedittextBox.Text + "')", con);
                    
                    
                cmd.ExecuteNonQuery();
                MessageBox.Show("Discription was Updated");

                try
                {
                    con.Close();
                    ActivitylistBox.ClearSelected();
                    
                    

                }

                finally
                {
                    con.Close();

                }
            }
            if(ActivityEdittextBox.Text != null)

            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE Invoice 
                SET PreviousBal= '" + prevbaleditextBox.Text + "' WHERE (InvoiceNumber = '" + invoicenumedittextBox.Text + "')", con);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Previous Balance was Updated");
              

                try
                {
                    con.Close();
                    prevbaleditextBox.Clear();



                }

                finally
                {
                    con.Close();

                }
            }
            if (prevbaleditextBox.Text != null)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE Invoice
                SET NewTotalBal= '" + TotalAmountEdittextBox.Text + "' WHERE (InvoiceNumber = '" + invoicenumedittextBox.Text + "')", con);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Total Balance was Updated");

                try
                {
                    con.Close();
                    prevbaleditextBox.Clear();



                }

                finally
                {
                    con.Close();

                }
            }

            
            //SearchInvoice SI = new SearchInvoice();
            //SI.Close();
            

        }

        private void EditInvoicecheckBox_CheckedChanged(object sender, EventArgs e)
        {
                     
            if(EditInvoicecheckBox.Checked)
            {
                EditInvoicepanel.Visible = true;
                ActivitylistBox.Text = ActivityEdittextBox.Text;
                
            }
            if(!EditInvoicecheckBox.Checked )
            {
                EditInvoicepanel.Visible = false;
            }
        }

        private void InvoicelistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            invoicenumedittextBox.Text = InvoicelistBox.Text;

          
        }

        private void ActivitylistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivityEdittextBox.Text = ActivitylistBox.Text;
        }

        private void PrevBallistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            prevbaleditextBox.Text = PrevBallistBox.Text;
        }

        private void TotalDuelistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TotalAmountEdittextBox.Text = TotalDuelistBox.Text;
        }

        private void Reloadbutton_Click(object sender, EventArgs e)
        {
            SearchInvoice SI = new SearchInvoice();
            this.Dispose();
            SI.Show();
        }
    }
}
