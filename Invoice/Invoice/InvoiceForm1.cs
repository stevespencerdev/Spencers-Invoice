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
using System.IO;
using System.Drawing.Printing;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Invoice
{
    public partial class invoice : Form
    {
        public invoice()
        {
            InitializeComponent();
            SearchFill();
            InvoiceNumberLoad();
            invoiceIdLoad();
            EstimateLawnBid();
           
            
        }

       
       void EstimateLawnBid()
        {
           
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Bids ORDER BY EstimateNum DESC", con);
            SqlDataReader dr;



            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    Bid bid = new Bid();
                    bid.EstimateLawnNumcomboBox.Visible = true;
                   // bid.EstimateNumberSnowcomboBox.Visible = false;
                   // bid.EstimateLawnNumcomboBox.Items.Add(dr["idCustomer"]);
                }
            }
            catch
            {

            }

        }

        void SearchFill()
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


                    NamecomboBox.Items.Add(dr["FullName"]);
                }
            }
            catch
            {

            }
        }

        void InvoiceNumberLoad()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
            SqlCommand cmd = new SqlCommand("SELECT TOP 5 * FROM Invoice ORDER BY InvoiceNumber DESC", con);
            SqlDataReader dr;


            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {


                    comboBox1.Items.Add(dr["InvoiceNumber"]);
                    
                }
            }
            catch
            {

            }
           
        }

        void invoiceIdLoad()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
            SqlCommand cmd = new SqlCommand("SELECT TOP 5 * FROM Invoice ORDER BY idInvoice DESC", con);
            SqlDataReader dr;


            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {


                    invoiceIDcomboBox.Items.Add(dr["idInvoice"]);

                }
            }
            catch
            {

            }
        }
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    richTextBox1.Text = filetext;

                }
            }
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            


            //Billing name and address
            BillToFormtbx.Text = BillTotbx.Text;
            BillTotbx.Text = " ";
            BillTotbx.TextAlign = HorizontalAlignment.Left;

            //Date
            DatetextBoxInvoice.Text = dateTimePickerlawn.Text;
            

            //Invoice Number 
            InvoiceNumtextBoxForm.Text = InvoiceNumtextBox.Text;
            InvoiceNumtextBox.Text = " ";

            //Date for Account Summary

            DateTextBox2Form.Text = SummarydateTimePicker.Text;
           
           

           
           

            //Account Summary
            AccountSummaryFormtextbox.Text = AccountSummarytextbox.Text;
          
            

            //Amount/Account Summary
            AmountFormtextBox.Text = AmounttextBox.Text;
            
           

            //Activity 

            ActivityFormtextBox.Text = ActivitytextBox.Text;
            ActivitytextBox.Text = " ";

            //Activity/Amount

            AmountformtextBox2.Text = AmounttextBox2.Text;
            AmounttextBox2.Text = " ";

            //Total

            TotalFormtextBox.Text = TotaltextBox.Text;
            TotaltextBox.Text = " ";

            MessageBox.Show("Make sure you take a screen shot of invoice before saving");

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            //Billing Name and address
            BillTotbx.Text = BillToFormtbx.Text;
            BillToFormtbx.Text = " ";

            //Date
          

            //Invoice Number 
            InvoiceNumtextBox.Text = InvoiceNumtextBoxForm.Text;
            InvoiceNumtextBoxForm.Text = " ";



            //Date for Account Summary
           


            //Account Summary
            //AccountSummarytextbox.Text = AccountSummaryFormtextbox.Text;

            //Amount/Account Summary
            AmounttextBox.Text = AmountFormtextBox.Text;
            AmountFormtextBox.Text = " ";
            //Activity 

            ActivitytextBox.Text = ActivityFormtextBox.Text;
            ActivityFormtextBox.Text = " ";

            //Activity/Amount

            AmounttextBox2.Text = AmountformtextBox2.Text;
            AmountformtextBox2.Text = " ";

            //Total

            TotaltextBox.Text = TotalFormtextBox.Text;
            TotalFormtextBox.Text = " ";


        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            PrintDialog pd = new PrintDialog();
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = doc;
            pd.Document = doc;
            //doc.PrintPage += new PrintPageEventHandler();

            if (ppd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }


        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            PrintDialog pd = new PrintDialog();
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = doc;
            pd.Document = doc;
            //doc.PrintPage += new PrintPageEventHandler();

            if (ppd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (InvoiceNumtextBox.Text == "")
            {
                MessageBox.Show("Please provide Invoice Number");
                InvoiceNumtextBox.Focus();
                InvoiceNumtextBox.BackColor = Color.Yellow;
            }

            if (InvoiceIdTextbox.Text == "")
            {
                MessageBox.Show("Please provide id Number");
                InvoiceIdTextbox.Focus();
                InvoiceIdTextbox.BackColor = Color.Yellow;
            }
            if (ActivitytextBox.Text == "")
            {
                MessageBox.Show("Please provide data");
                ActivitytextBox.Focus();
                ActivitytextBox.BackColor = Color.Yellow;
            }

            //if (AmounttextBox2.Text == "")
            //{
            //    MessageBox.Show("Please provide data");
            //    AmounttextBox2.Focus();
            //    AmounttextBox2.BackColor = Color.Yellow;
            //}

            if (PreviousBaltextBox.Text == "")
            {
                MessageBox.Show("Please provide Balance");
                PreviousBaltextBox.Focus();
                PreviousBaltextBox.BackColor = Color.Yellow;
            }
           
            if (NamecomboBox.Text == "")
            {
                MessageBox.Show("Please provide the name");
                NamecomboBox.Focus();
                NamecomboBox.BackColor = Color.Yellow;
            }
            if (TotalAmountDuetextBox.Text == "")
            {
                MessageBox.Show("Please provide the new amount due");
                TotalAmountDuetextBox.Focus();
                TotalAmountDuetextBox.BackColor = Color.Yellow;
            }

            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Invoice (idInvoice, InvoiceNumber, Discription, NewAmount, PreviousBal, InvoiceDate, NewTotalBal, Name ) VALUES ('" + this.InvoiceIdTextbox.Text + "','" + this.InvoiceNumtextBox.Text + "','" + this.ActivitytextBox.Text + "','" + this.TotaltextBox.Text + "','" + this.PreviousBaltextBox.Text + "','" + this.dateTimePickerlawn.Text + "','" + this.TotalAmountDuetextBox.Text + "','" + this.NamecomboBox.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Invoice Added!");

                InvoiceNumberLoad();
            }


        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            MonthsdataGridView.Visible = true;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
            conn.Open();
            SqlDataAdapter sdaa = new SqlDataAdapter("SELECT Name, InvoiceNumber, NewTotalBal, TotalPaid FROM Invoice WHERE (Name = '" + NamecomboBox.Text + "')", conn);
            DataTable dtt = new DataTable();
            sdaa.Fill(dtt);
            dataGridView1.DataSource = dtt;
            conn.Close();



            try
            {
                //MarchcheckBox.Checked = false;

            }
            catch
            {

            }

            
            if (NamecomboBox.Text == "Ashley Burton")
            {


                BillTotbx.Text = @"Ashley Burton 
510 E 8000 S
Sandy UT.";
                BillTotbx.TextAlign = HorizontalAlignment.Left;
                BillTotbx.Lines.Clone();
            }
            if (NamecomboBox.Text == "Casey Vandemerwe")
            {
                BillTotbx.Text = @"Casey Vandemerwe 
6916 S 1520 W 
West Jordan UT.";
            }
            if (NamecomboBox.Text == "Pizza Hut SJ")
            {
                BillTotbx.Text = @" Pizza Hut 10309 S
Redwood Rd. 
South Jordan UT.";
            }
            if (NamecomboBox.Text == "Ray")
            {
                BillTotbx.Text = @"Ray 
11651 Briarglen Dr.
Sandy UT.";
            }
            if (NamecomboBox.Text == "Sallie Rawlings")
            {
                BillTotbx.Text = @"Sallie Rawlings 
29 Wonderwood Way 
Sandy UT.";
            }

            if (NamecomboBox.Text == "Shelly Kormeluk")
            {
                BillTotbx.Text = @"Shelly Kormeluk 
11793 Hidden Brook Blvd. 
Sandy UT.";
            }

            if (NamecomboBox.Text == "Steve Dailey")
            {
                BillTotbx.Text = @"Steve Dailey 
11175 Farmsworth
Sandy UT.";
            }

            if (NamecomboBox.Text == "Nick Kormeluk")
            {
                BillTotbx.Text = @"Nick Kormeluk 
3208 E Willow Crest RD.
Cottonwood Heights UT.";
            }

            if (NamecomboBox.Text == "Pizza Hut Sandy")
            {
                BillTotbx.Text = @"Pizza Hut  
10500 S 1300 E
Sandy UT.";
            }

            if (NamecomboBox.Text == "Jess Aylett Home")
            {
                BillTotbx.Text = @"Jess Aylett 
2469 High Mountain Dr.
Sandy UT.";
            }

            if (NamecomboBox.Text == "Pizza Hut Kearns")
            {
                BillTotbx.Text = @"Pizza Hut 
4655 W 5415 S
Kearns UT.";
            }

            if (NamecomboBox.Text == "Heather")
            {
                BillTotbx.Text = @"Heather 
5552 W Morning Light Dr. 
Sandy UT.";
            }

            if (NamecomboBox.Text == "Lane Halsey")
            {
                BillTotbx.Text = @"Lane Halsey 
14311 Crown Rose Dr.
Herriman UT.";
            }

            if (NamecomboBox.Text == "Matt Sorensen")
            {
                BillTotbx.Text = @"Matt Sorensen 
10362 S Mckinley Park PL
South Jordan UT.";
            }

            if (NamecomboBox.Text == "Sandi Cartwright")
            {
                BillTotbx.Text = @"Sandi Cartwright
10348 Mckinley Park Pl  
South Jordan UT.";
            }

            if (NamecomboBox.Text == "Brent")
            {
                BillTotbx.Text = @"Brent
10290 Mckinley Park Pl
South Jordan UT.";
            }
            if (NamecomboBox.Text == "Jess Aylett Draper")
            {
                BillTotbx.Text = @"Jess Aylett
48 E 13200 S
Draper UT.";
            }
            if (NamecomboBox.Text == "Pizza Hut West Valley 3390 S")
            {
                BillTotbx.Text = @"Pizza Hut
2730 W 3500 S
West Valley UT.";
            }
            if (NamecomboBox.Text == "Rana Nizam")
            {
                BillTotbx.Text = @"Rana Nizam
11114 S FarmsWorth Lane
Sandy UT.";
            }
            if (NamecomboBox.Text == "Mike Brinton")
            {
                BillTotbx.Text = @"Mike Brinton
1977 E Evergreen Ave 
SLC UT.";
            }
            if (NamecomboBox.Text == "Carma Brown")
            {
                BillTotbx.Text = @"Carma Brown
7895 Willowcrest Rd.
Cottonwood Hieghts UT.";
            }

          

        }

        private void Validatebutton_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT idInvoice FROM Invoice where idInvoice = '" + InvoiceIdTextbox.Text + "' ", con);
            cmd.Parameters.AddWithValue("idInvoice", InvoiceTextbox.Text);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                Checkbutton.Visible = false;
                Redbutton.Visible = true;


            }
            else
            {
                Checkbutton.Visible = true;
                Redbutton.Visible = false;

                //MessageBox.Show("This number works");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Login log = new Login();
            //log.ApplicationcomboBox.Text = "Lawn";
            //EmailLawn email = new EmailLawn();
            //email.Show();

            //if (log.ApplicationcomboBox.Text == "Lawn")
            //{

            //    SqlConnection con = new SqlConnection();
            //    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
            //    SqlCommand cmd = new SqlCommand("SELECT * FROM DropDown", con);
            //    SqlDataReader dr;
            //    email.togglelbl.Text = "Lawn Email";

            //    try
            //    {
            //        con.Open();
            //        dr = cmd.ExecuteReader();
            //        while (dr.Read())
            //        {


            //            email.comboBoxemailtst.Items.Add(dr["FullName"]);
            //            email.comboBoxemailtst.Items.Add(dr["Email"]);



            //        }

            //    }
            //    catch
            //    {

            //    }

            //    finally
            //    {
            //        con.Close();
            //    }


            //}

          

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
        }

        private void searchInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchInvoice SI = new SearchInvoice();
            SI.Show();
        }

        private void Augustcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
            //con.Open();

            if (Augustcheckbox.Checked)
            {
                MonthsdataGridView.Visible = true;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT August, PriceAugust FROM Months WHERE (Name = '" + NamecomboBox.Text + "')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MonthsdataGridView.DataSource = dt;
                con.Close();

            }
            try
            {
                //Augustcheckbox.Checked = false;
                
            }
            catch
            {

            }
        }

        private void HideGridcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MonthsdataGridView.Visible = false;
        }

        private void ShowGridcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MonthsdataGridView.Visible = true;
        }

        private void InsertradioButton_CheckedChanged(object sender, EventArgs e)
        {
           

            if (MarchcheckBox.Checked)
            {
                  DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"UPDATE Months 
                        SET March= '" + ActivitytextBox.Text + "' WHERE (Name = '" + NamecomboBox.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Updated The Month of March!");

                        try
                        {
                            con.Close();
                            ActivitytextBox.Clear();
                            MarchcheckBox.Checked = false;
                            InsertradioButton.Checked = false;
                            AmounttextBox2.Clear();
                            

                        }

                        finally
                        {
                            con.Close();

                        }
                    }
            }

            if (AprilcheckBox.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE Months 
                        SET April= '" + ActivitytextBox.Text + "' WHERE (Name = '" + NamecomboBox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Month of April!");

                    try
                    {
                        con.Close();
                        ActivitytextBox.Clear();
                        AprilcheckBox.Checked = false;
                        InsertradioButton.Checked = false;
                        AmounttextBox2.Clear();

                    }

                    finally
                    {
                        con.Close();

                    }
                }
            }

            if(maycheckBox.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE Months 
                        SET May= '" + ActivitytextBox.Text + "' WHERE (Name = '" + NamecomboBox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Month of May!");

                    try
                    {
                        con.Close();
                        ActivitytextBox.Clear();
                        maycheckBox.Checked = false;
                        InsertradioButton.Checked = false;
                        AmounttextBox2.Clear();
                    }

                    finally
                    {
                        con.Close();

                    }
                }
            }

            if(JunecheckBox.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE Months 
                        SET June= '" + ActivitytextBox.Text + "' WHERE (Name = '" + NamecomboBox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Month of June!");

                    try
                    {
                        con.Close();
                        ActivitytextBox.Clear();
                        JunecheckBox.Checked = false;
                        InsertradioButton.Checked = false;
                        AmounttextBox2.Clear();
                    }

                    finally
                    {
                        con.Close();

                    }
                }
            }

            if(JulycheckBox.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE Months 
                        SET July= '" + ActivitytextBox.Text + "' WHERE (Name = '" + NamecomboBox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Month of July!");

                    try
                    {
                        con.Close();
                        ActivitytextBox.Clear();
                        JulycheckBox.Checked = false;
                        InsertradioButton.Checked = false;
                        AmounttextBox2.Clear();
                    }

                    finally
                    {
                        con.Close();

                    }
                }
            }
                


            if (Augustcheckbox.Checked)
            {


                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE Months 
                    SET August= '" + ActivitytextBox.Text + "' WHERE (Name = '" + NamecomboBox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Month of August!");

                    try
                    {
                        con.Close();
                        ActivitytextBox.Clear();
                        Augustcheckbox.Checked = false;
                        InsertradioButton.Checked = false;
                        AmounttextBox2.Clear();

                    }

                    finally
                    {
                        con.Close();
                        

                    }
                }
            }

            if (SeptcheckBox.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE Months 
                        SET September= '" + ActivitytextBox.Text + "' WHERE (Name = '" + NamecomboBox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Month of September!");

                    try
                    {
                        con.Close();
                       

                    }

                    finally
                    {
                        con.Close();

                    }


                }

                //Updated the price fields in sql 
                
                      SqlConnection conn = new SqlConnection();
                      conn.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                      conn.Open();
                      SqlCommand cmdd = new SqlCommand(@"UPDATE Months 
                        SET PriceSeptember= '" + AmounttextBox2.Text + "' WHERE (Name = '" + NamecomboBox.Text + "')", conn);
                      cmdd.ExecuteNonQuery();
                      MessageBox.Show("Updated The Price of September!");

                      try
                      {
                          conn.Close();
                          ActivitytextBox.Clear();
                          OctobercheckBox.Checked = false;
                          InsertradioButton.Checked = false;
                          AmounttextBox2.Text = "";

                      }

                      finally
                      {
                          conn.Close();

                      }
                  
            
//                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "Confirm", MessageBoxButtons.YesNo);
//                if (dialogResult == DialogResult.Yes)
//                {
//                    SqlConnection con = new SqlConnection();
//                    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
//                    con.Open();
//                    SqlCommand cmd = new SqlCommand(@"UPDATE Months 
//                    SET September= '" + ActivitytextBox.Text + "' WHERE (Name = '" + NamecomboBox.Text + "')", con);
//                    cmd.ExecuteNonQuery();
//                    MessageBox.Show("Updated The Month of September!");

//                    try
//                    {
//                        con.Close();
//                        ActivitytextBox.Clear();
//                        SeptcheckBox.Checked = true;
//                        InsertradioButton.Checked = false;
//                        AmounttextBox2.Clear();
//                    }

//                    finally
//                    {
//                        con.Close();

//                    }
//                    SqlConnection conn = new SqlConnection();
//                    conn.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
//                    conn.Open();
//                    SqlCommand cmdd = new SqlCommand(@"UPDATE Months 
//                        SET PriceSeptember= '" + AmounttextBox2.Text + "' WHERE (Name = '" + NamecomboBox.Text + "')", conn);
//                    cmdd.ExecuteNonQuery();
//                    MessageBox.Show("Updated The price of September!");

//                    try
//                    {
//                        conn.Close();
//                        ActivitytextBox.Clear();
//                        SeptcheckBox.Checked = false;
//                        InsertradioButton.Checked = false;

//                    }

//                    finally
//                    {
//                        conn.Close();

//                    }
//                }
            }
            if (OctobercheckBox.Checked)
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE Months 
                        SET October= '" + ActivitytextBox.Text + "' WHERE (Name = '" + NamecomboBox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Month of October!");

                    try
                    {
                        con.Close();
                       
                    }

                    finally
                    {
                        con.Close();

                    }


                }

                //Updated the price fields in sql 
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                    conn.Open();
                    SqlCommand cmdd = new SqlCommand(@"UPDATE Months 
                        SET PriceOctober= '" + AmounttextBox2.Text + "' WHERE (Name = '" + NamecomboBox.Text + "')", conn);
                    cmdd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Price of October!");

                    try
                    {
                        conn.Close();
                        ActivitytextBox.Clear();
                        OctobercheckBox.Checked = false;
                        InsertradioButton.Checked = false;
                        AmounttextBox2.Text = "";

                    }

                    finally
                    {
                        conn.Close();

                    }
            }
           
        }

        private void SeptcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SeptcheckBox.Checked)
            {
                MonthsdataGridView.Visible = true;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT September, PriceSeptember FROM Months WHERE (Name = '" + NamecomboBox.Text + "')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MonthsdataGridView.DataSource = dt;
                con.Close();

            }
            try
            {
                //Augustcheckbox.Checked = false;

            }
            catch
            {

            }
        }

        private void MarchcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(MarchcheckBox.Checked)
            {
                MonthsdataGridView.Visible = true;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT March FROM Months WHERE (Name = '" + NamecomboBox.Text + "')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MonthsdataGridView.DataSource = dt;
                con.Close();

            }
            
            try
            {
                //MarchcheckBox.Checked = false;

            }
            catch
            {

            }
        }

        private void AprilcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(AprilcheckBox.Checked)
            {
                MonthsdataGridView.Visible = true;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT April FROM Months WHERE (Name = '" + NamecomboBox.Text + "')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MonthsdataGridView.DataSource = dt;
                con.Close();

            }

            try
            {
                //MarchcheckBox.Checked = false;

            }
            catch
            {

            }
        }

        private void maycheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(maycheckBox.Checked)
            {
                MonthsdataGridView.Visible = true;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT May FROM Months WHERE (Name = '" + NamecomboBox.Text + "')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MonthsdataGridView.DataSource = dt;
                con.Close();

            }

            try
            {
                //MarchcheckBox.Checked = false;

            }
            catch
            {

            }
        }

        private void JunecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(JunecheckBox.Checked)
            {
                MonthsdataGridView.Visible = true;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT July FROM Months WHERE (Name = '" + NamecomboBox.Text + "')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MonthsdataGridView.DataSource = dt;
                con.Close();

            }

            try
            {
                //MarchcheckBox.Checked = false;

            }
            catch
            {

            }
        }

        private void JulycheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(JulycheckBox.Checked)
            {
                MonthsdataGridView.Visible = true;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT July FROM Months WHERE (Name = '" + NamecomboBox.Text + "')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MonthsdataGridView.DataSource = dt;
                con.Close();

            }

            try
            {
                //MarchcheckBox.Checked = false;

            }
            catch
            {

            }
        }

        private void OctobercheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(OctobercheckBox.Checked)
            {
                MonthsdataGridView.Visible = true;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT October, PriceOctober FROM Months WHERE (Name = '" + NamecomboBox.Text + "')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MonthsdataGridView.DataSource = dt;
                con.Close();

            }

            try
            {
                //MarchcheckBox.Checked = false;

            }
            catch
            {

            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            BillTotbx.Clear();
            ActivitytextBox.Clear();
            AmounttextBox2.Clear();
           
        }

        private void InvoiceNumtextBox_TextChanged(object sender, EventArgs e)
        {
                   

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
            SqlCommand cmd = new SqlCommand("SELECT TOP 5 * FROM Invoice ORDER BY InvoiceNumber DESC", con);
            SqlDataReader dr;


            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {


                    comboBox1.Items.Add(dr["InvoiceNumber"]);

                    //comboBoxemailtst.Items.Add(dr["Email"]);



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

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int num1, num2, res;
            num1 = Convert.ToInt32(comboBox1.Text);
            num2 = Convert.ToInt32(AddtextBox.Text);
            res = num1 + num2;
            InvoiceNumtextBox.Text = Convert.ToString(res);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invoice IN = new invoice();
            //this.Dispose();
            //IN.Show();

            
        }

        private void DatetextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InvoiceNumberLoad();
            invoiceIdLoad();
            comboBox1.Text = InvoiceNumtextBox.Text;
            invoiceIDcomboBox.Text = InvoiceIdTextbox.Text;

            comboBox1.Visible = false;
            invoiceIDcomboBox.Visible = false;
            

            AmounttextBox.Text = @"$0.00
$0.00
$0.00
$0.00";
            ActivitytextBox.Text = "";
            AmounttextBox2.Text = "";
            TotaltextBox.Text = @"$0.00
$0.00

";
            BillTotbx.Text = "";
            PreviousBaltextBox.Text = "";
            TotalAmountDuetextBox.Text = "";

            //InvoiceNumtextBox.Text = comboBox1.Text;
            LastInviocenumberlable.Text = InvoiceNumtextBox.Text;
         
            

            
        }

        private void invoice_Load(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                           
        }

        private void switchUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

       
        private void emailInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Login log = new Login();
            //log.ApplicationcomboBox.Text = "Lawn";
            //EmailLawn email = new EmailLawn();
            //email.Show();

            //if (log.ApplicationcomboBox.Text == "Lawn")
            //{

            //    SqlConnection con = new SqlConnection();
            //    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
            //    SqlCommand cmd = new SqlCommand("SELECT * FROM DropDown", con);
            //    SqlDataReader dr;
            //    email.togglelbl.Text = "Lawn Email";

            //    try
            //    {
            //        con.Open();
            //        dr = cmd.ExecuteReader();
            //        while (dr.Read())
            //        {


            //            email.comboBoxemailtst.Items.Add(dr["FullName"]);
            //            email.comboBoxemailtst.Items.Add(dr["Email"]);



            //        }

            //    }
            //    catch
            //    {

            //    }

            //    finally
            //    {
            //        con.Close();
            //    }
            //}
        }

        private void MonthsdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MarchcheckBox.Checked == true)
            {
                DataGridViewRow row = this.MonthsdataGridView.Rows[e.RowIndex];
                ActivitytextBox.Text = row.Cells["March"].Value.ToString();
        

            }

            if (AprilcheckBox.Checked == true)
            {           
                    DataGridViewRow row = this.MonthsdataGridView.Rows[e.RowIndex];
                    ActivitytextBox.Text = row.Cells["April"].Value.ToString();         
            }

            if(maycheckBox.Checked ==true)
            {
                DataGridViewRow row = this.MonthsdataGridView.Rows[e.RowIndex];
                ActivitytextBox.Text = row.Cells["May"].Value.ToString(); 
            }

            if(JunecheckBox.Checked ==true)
            {
                DataGridViewRow row = this.MonthsdataGridView.Rows[e.RowIndex];
                ActivitytextBox.Text = row.Cells["June"].Value.ToString(); 
            }
            if(JulycheckBox.Checked == true)
            {
                DataGridViewRow row = this.MonthsdataGridView.Rows[e.RowIndex];
                ActivitytextBox.Text = row.Cells["July"].Value.ToString(); 
            }
            if(Augustcheckbox.Checked == true)
            {
                DataGridViewRow row = this.MonthsdataGridView.Rows[e.RowIndex];
                ActivitytextBox.Text = row.Cells["August"].Value.ToString(); 
            }
            if(SeptcheckBox.Checked == true)
            {
                DataGridViewRow row = this.MonthsdataGridView.Rows[e.RowIndex];
                ActivitytextBox.Text = row.Cells["September"].Value.ToString();
                AmounttextBox2.Text = row.Cells["PriceSeptember"].Value.ToString(); 
            }

            if(OctobercheckBox.Checked == true)
            {
                DataGridViewRow row = this.MonthsdataGridView.Rows[e.RowIndex];
                ActivitytextBox.Text = row.Cells["October"].Value.ToString();
                AmounttextBox2.Text = row.Cells["PriceOctober"].Value.ToString(); 
            }
            

            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.MonthsdataGridView.Rows[e.RowIndex];
            //    ActivitytextBox.Text = row.Cells["April"].Value.ToString();
            //    ActivitytextBox.Text = row.Cells["September"].Value.ToString();
            //}

            //int row = MonthsdataGridView.CurrentCell.RowIndex;
            //int col = MonthsdataGridView.CurrentCell.ColumnIndex;
            //ActivitytextBox.Text = string.Format("{0})", MonthsdataGridView[row,col]);
        }

        private void Generatebutton_Click(object sender, EventArgs e)
        {
            int num1, num2, res;
            num1 = Convert.ToInt32(comboBox1.Text);
            num2 = Convert.ToInt32(AddtextBox.Text);
            res = num1 + num2;
            InvoiceNumtextBox.Text = Convert.ToString(res);
        }

        private void MonthsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MarchcheckBox.Checked = false;
            AprilcheckBox.Checked = false;
            maycheckBox.Checked = false;
            JunecheckBox.Checked = false;
            JulycheckBox.Checked = false;
            Augustcheckbox.Checked = false;
            SeptcheckBox.Checked = false;
            OctobercheckBox.Checked = false;
            NovembercheckBox.Checked = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            

          
           
           
        }

        private void BillTotbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerlawn_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerlawn.Format = DateTimePickerFormat.Custom;
            dateTimePickerlawn.CustomFormat = "MM-dd-yyyy";
        }

        private void SummarydateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SummarydateTimePicker.Format = DateTimePickerFormat.Custom;
            SummarydateTimePicker.CustomFormat = "MM-dd-yyyy";
        }

        private void invoiceIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num1, num2, res;
            num1 = Convert.ToInt32(invoiceIDcomboBox.Text);
            num2 = Convert.ToInt32(AddidTextbox.Text);
            res = num1 + num2;
            InvoiceIdTextbox.Text = Convert.ToString(res);
        }

        private void AddidTextbox_TextChanged(object sender, EventArgs e)
        {

        }

   

        

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //textBox18.Text = row.Cells["TotalPaid"].Value.ToString();
            //textBox17.Text = row.Cells["NewTotalBal"].Value.ToString();

         

            if(paymentstextbox.Text != null && balanceforwardtextBox.Text != null)
            {
                paymentstextbox.Text = row.Cells["TotalPaid"].Value.ToString();
                balanceforwardtextBox.Text = "$0.00";
            }
            if(balanceforwardtextBox.Text !=null && paymentstextbox.Text == null)
            {
                balanceforwardtextBox.Text = row.Cells["NewTotalBal"].Value.ToString();
                paymentstextbox.Text = "$0.00";
            }



            //if(!string.IsNullOrWhiteSpace(textBox18.Text) && (!string.IsNullOrWhiteSpace(textBox17.Text)))
            //{
            //    textBox18.Text = row.Cells["TotalPaid"].Value.ToString();
            //}
            
        }

        private void NewChargestextbox_TextChanged(object sender, EventArgs e)
        {
            //textBox15.Text = NewChargestextbox.Text;
           
           
            
            
        }

        private void TotalDuetextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void contractToolStripMenuItem_Click(object sender, EventArgs e)
        {
                          
                
                Contract contract = new Contract();
                contract.Show();
                contract.LawncontractpictureBox.Visible = true;
                
            

            
        }

        private void ScreenShotbutton_Click(object sender, EventArgs e)
        {
            //SaveAsBitmap(richTextBox1, "C:\\Users\\stevens\\Downloads\\Mystuff\\Invoices");
        }

        private void NovembercheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void SaveAsBitmap(Control control, string Inv)
        //{
        //    Graphics g = control.CreateGraphics();

        //    Bitmap bmp = new Bitmap(control.Width, control.Height);

        //    control.DrawToBitmap(bmp, new System.Drawing.Rectangle(863, 996, control.Width, control.Height));

        //    bmp.Save(@"C:\\Users\\stevens\\Downloads\\Mystuff\\Invoices",Inv);
        //    bmp.Dispose();
        //}

         
    }
}
                   
            
            
        

    

