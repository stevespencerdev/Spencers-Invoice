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
    public partial class InvoiceSnow : Form
    {
        public InvoiceSnow()
        {
            InitializeComponent();
            invoiceIDLoad();
            EstimateSnowBid();
            SnowNameLoad();
            //pictureBox1.Visible = true;
            InvoiceNumberLoad();
            picker();
           
            

        }

        void picker()
        {
            if (todaysdateTimePicker.Value < SnowdateTimePicker.Value)
            {
                LawnLogopictureBox.Visible = true;
                lawnMonthsgroupBox.Visible = true;

                pictureBox1.Visible = false;
                SnowMonthsgroupBox.Visible = false;


            }

            else
            {
                LawnLogopictureBox.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        void DateLoad()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
            SqlCommand cmd = new SqlCommand("SELECT DateSnow * FROM AutoPopulate", con);
            SqlDataReader dr;


            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {


                    invoicenumberloadcomboBox.Items.Add(dr["DatesSnow"]);

                }
            }
            catch
            {

            }
        }
        void InvoiceNumberLoad()
        {
            if (todaysdateTimePicker.Value > SnowdateTimePicker.Value)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                SqlCommand cmd = new SqlCommand("SELECT TOP 5 * FROM Invoice ORDER BY InvoiceNumber DESC", con);
                SqlDataReader dr;


                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {


                        invoicenumberloadcomboBox.Items.Add(dr["InvoiceNumber"]);

                    }
                }
                catch
                {

                }
            }

            else
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


                        invoicenumberloadcomboBox.Items.Add(dr["InvoiceNumber"]);

                    }
                }
                catch
                {

                }
            }
        }


        void SnowNameLoad()
        {
            if (todaysdateTimePicker.Value > SnowdateTimePicker.Value)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", con);
                SqlDataReader dr;


                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {


                        NamecomboBox.Items.Add(dr["BusinessName"]);
                    }
                }
                catch
                {

                }
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", con);
                SqlDataReader dr;


                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {


                        NamecomboBox.Items.Add(dr["Business"]);
                    }
                }
                catch
                {

                }
            }

        }
        void EstimateSnowBid()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Bids2015 ORDER BY EstimateNumber DESC", con);
            SqlDataReader dr;



            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    Bid bid = new Bid();
                    bid.EstimateLawnNumcomboBox.Visible = false;
                  //  bid.EstimateNumberSnowcomboBox.Visible = true;
                   // bid.EstimateNumberSnowcomboBox.Items.Add(dr["EstimateNumber"]);
                }
            }
            catch
            {

            }
        }
        private void InvoiceSnow_Load(object sender, EventArgs e)
        {

        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //base.OnFormClosing(e);
            //if (e.CloseReason == CloseReason.WindowsShutDown) return;

            //switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            //{
            //    case DialogResult.No:
            //        e.Cancel = true;
            //        break;
            //    default:
            //        break;
            //}
        }

        void invoiceIDLoad()
        {
            if (todaysdateTimePicker.Value > SnowdateTimePicker.Value)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
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
            else
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            //Date
            DatetextBoxInvoice.Text = dateTimePickerSnow.Text;
            

            //Invoice Number 
            InvoiceNumtextBoxForm.Text = InvoiceNumtextBox.Text;
            InvoiceNumtextBox.Text = " ";

            if (InvoiceNumtextBoxForm.Text == "")
            {
                MessageBox.Show("Please provide Invoice Number");
                InvoiceNumtextBoxForm.Focus();
                InvoiceNumtextBoxForm.BackColor = Color.Yellow;
            }

            else if (InvoiceNumtextBoxForm.Text != null)
            {
                InvoiceNumtextBoxForm.BackColor = Color.White;
            }

            // total amount due on the actual invoice  //TotalFormtextBox

            if (TotalFormtextBox.Text == "")
            {
                MessageBox.Show("Please provide total amount");
                TotalFormtextBox.Focus();
                TotalFormtextBox.BackColor = Color.Yellow;
            }

            else if (InvoiceNumtextBoxForm.Text != null)
            {
                TotalFormtextBox.BackColor = Color.White;
            }

            //first amount textbox  AmountFormtextBox

            if (AmountFormtextBox.Text == "")
            {
                MessageBox.Show("Please provide amount");
                AmountFormtextBox.Focus();
                AmountFormtextBox.BackColor = Color.Yellow;
            }

            else if (InvoiceNumtextBoxForm.Text != null)
            {
                AmountFormtextBox.BackColor = Color.White;
            }
         
            //Date for Account Summary

            DateTextBox2Form.Text = dateTimePicker2Snow.Text;
           

          


        

            MessageBox.Show("Make sure you take a screen shot of invoice before saving");
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            //Billing Name and address
            BillTotbx.Text = BillToFormtbx.Text;
            BillToFormtbx.Text = " ";

            //Date
            dateTimePickerSnow.Text = DatetextBoxInvoice.Text;
            DatetextBoxInvoice.Text = " ";

            //Invoice Number 
            InvoiceNumtextBox.Text = InvoiceNumtextBoxForm.Text;
            InvoiceNumtextBoxForm.Text = " ";



            //Date for Account Summary
            dateTimePicker2Snow.Text = DateTextBox2Form.Text;
            DateTextBox2Form.Text = " ";


           


        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            BillTotbx.Clear();
           
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Login log = new Login();
            //log.ApplicationcomboBox.Text = "Snow";

            //EmailLawn email = new EmailLawn();
            //email.Show();

            //if (log.ApplicationcomboBox.Text == "Snow")
            //{



            //    SqlConnection con = new SqlConnection();
            //    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
            //    SqlCommand cmd = new SqlCommand("SELECT * FROM customer", con);
            //    SqlDataReader dr;

            //    email.togglelbl.Text = "Snow Removal Email";

            //    try
            //    {
            //        con.Open();
            //        dr = cmd.ExecuteReader();
            //        while (dr.Read())
            //        {


            //            email.comboBoxemailtst.Items.Add(dr["BusinessName"]);
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

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NewCustomer newcus = new NewCustomer();
            newcus.Show();

        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void bidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            Bid Bid = new Bid();
            Bid.Show();


            //InvoiceSnow invsnow = new InvoiceSnow();
            //if (invsnow.todaysdateTimePicker.Value > invsnow.SnowdateTimePicker.Value)
            //{
                
            //    Bid.BidLawnpictureBox1.Visible = false;
            //    Bid.SnowBidpictureBox.Visible = true;
            //    Bid.EstimateNumberSnowcomboBox.Visible = true;
            //    Bid.EstimateLawnNumcomboBox.Visible = false;
            //    Bid.BidLawnidcomboBox.Visible = false;
            //    Bid.BidSnowidcomboBox.Visible = true;
            //    Bid.SaveButton.Visible = false;
            //    Bid.SaveSnowInvoicebutton.Visible = true;
            //    Bid.Validatebutton.Visible = false;
            //    Bid.ValidateSnowbutton.Visible = true;
              

            //}

           
        }

        private void SnowInvoiceSavebutton_Click(object sender, EventArgs e)
        {
            if (InvoiceNumtextBoxForm.Text == "")
            {
                MessageBox.Show("Please provide Invoice Number");
                InvoiceNumtextBoxForm.Focus();
                InvoiceNumtextBoxForm.BackColor = Color.Yellow;
            }

            if (InvoiceNumtextBoxForm.Text != null)
            {
                InvoiceNumtextBoxForm.BackColor = Color.White;
            }
            if (InvoiceIdTextbox.Text == "")
            {
                MessageBox.Show("Please provide id Number");
                InvoiceIdTextbox.Focus();
                InvoiceIdTextbox.BackColor = Color.Yellow;
            }    
          
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


            if (LawnLogopictureBox.Visible == true)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Invoice (idInvoice, InvoiceNumber, Discription, NewAmount, PreviousBal, InvoiceDate, Name, NewTotalBal) VALUES ('" + this.InvoiceIdTextbox.Text + "','" + this.InvoiceNumtextBoxForm.Text + "','" + this.ActivityFormtextBox.Text + "','" + this.TotalAmountDuetextBox.Text + "','" + this.PreviousBaltextBox.Text + "','" + this.dateTimePickerSnow.Text + "','" + this.NamecomboBox.Text + "','" + this.TotalAmountDuetextBox.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lawn Invoice Added!");

                InvoiceSnow invsnow = new InvoiceSnow();
                this.Hide();
                invsnow.Show();
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Invoice (idInvoice, InvoiceNumber, Discription, NewAmount, PreviousBalance, InvoiceDate, BusinessName, NewTotalBalance) VALUES ('" + this.InvoiceIdTextbox.Text + "','" + this.InvoiceNumtextBoxForm.Text + "','" + this.ActivityFormtextBox.Text + "','" + this.TotalAmountDuetextBox.Text + "','" + this.PreviousBaltextBox.Text + "','" + this.dateTimePickerSnow.Text + "','" + this.NamecomboBox.Text + "','" + this.TotalAmountDuetextBox.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Snow Invoice Added!");

                InvoiceSnow invsnow = new InvoiceSnow();
                this.Hide();
                invsnow.Show();
            }

           
        }

        private void NamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (todaysdateTimePicker.Value > SnowdateTimePicker.Value)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT BusinessName, Address1, City FROM Customer WHERE (BusinessName = '" + NamecomboBox.Text + "')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                AdressDataGrid.DataSource = dt;
                con.Close();
            }

            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Business, Address1, City FROM Customer WHERE (Business = '" + NamecomboBox.Text + "')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                AdressDataGrid.DataSource = dt;
                con.Close();
            }

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num1, num2, res;
            num1 = Convert.ToInt32(invoicenumberloadcomboBox.Text);
            num2 = Convert.ToInt32(AddtextBox.Text);
            res = num1 + num2;
            InvoiceNumtextBox.Text = Convert.ToString(res);
        }

        private void contractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (todaysdateTimePicker.Value < SnowdateTimePicker.Value)

                MessageBox.Show("coming soon");
            else
            {
                Contract contract = new Contract();
                contract.Show();
                contract.SnowContractpictureBox.Visible = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerSnow.Format = DateTimePickerFormat.Custom;
            dateTimePickerSnow.CustomFormat = "MM-dd-yyyy";
        }

        private void dateTimePicker2Snow_ValueChanged(object sender, EventArgs e)
        {
            
            dateTimePicker2Snow.Format = DateTimePickerFormat.Custom;
            dateTimePicker2Snow.CustomFormat = "MM-dd-yyyy";

        }

        private void MonthsSnowdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.MonthsSnowdataGridView.Rows[e.RowIndex];

            if (NovemberSnowcheckBox.Checked)
            {             
                ActivityFormtextBox.Text = row.Cells["November"].Value.ToString();
                AmountformtextBox2.Text = row.Cells["PriceNovember"].Value.ToString();
            }

            if (DecemberSnowcheckBox.Checked)
            {
                ActivityFormtextBox.Text = row.Cells["December"].Value.ToString();
                AmountformtextBox2.Text = row.Cells["PriceDecember"].Value.ToString();
            }

            if (JanuarySnowcheckBox.Checked)
            {
                ActivityFormtextBox.Text = row.Cells["January"].Value.ToString();
                AmountformtextBox2.Text = row.Cells["PriceJanuary"].Value.ToString();
            }

            if (FebruarySnowcheckBox.Checked)
            {
                ActivityFormtextBox.Text = row.Cells["February"].Value.ToString();
                AmountformtextBox2.Text = row.Cells["PriceFebruary"].Value.ToString();
            }

            if (MarchSnowcheckBox.Checked)
            {
                ActivityFormtextBox.Text = row.Cells["March"].Value.ToString();
                AmountformtextBox2.Text = row.Cells["PriceMarch"].Value.ToString();
            }
            if (AprilSnowcheckBox.Checked)
            {
                ActivityFormtextBox.Text = row.Cells["April"].Value.ToString();
                AmountformtextBox2.Text = row.Cells["PriceApril"].Value.ToString();
               
            }
            if (SeptcheckBox.Checked)
            {
                ActivityFormtextBox.Text = row.Cells["September"].Value.ToString();
                AmountformtextBox2.Text = row.Cells["PriceSeptember"].Value.ToString();
            }
            if (NovembercheckBox.Checked && LawnLogopictureBox.Visible == true)
            {
                ActivityFormtextBox.Text = row.Cells["November"].Value.ToString();
                AmountformtextBox2.Text = row.Cells["PriceNovember"].Value.ToString();
            }

            if (OctobercheckBox.Checked)
            {
                ActivityFormtextBox.Text = row.Cells["October"].Value.ToString();
                AmountformtextBox2.Text = row.Cells["PriceOctober"].Value.ToString();
            }
            if (NovembercheckBox.Checked && LawnLogopictureBox.Visible == true)
            {
                ActivityFormtextBox.Text = row.Cells["November"].Value.ToString();
                AmountformtextBox2.Text = row.Cells["PriceNovember"].Value.ToString();
            }
           
          
          
          
           
        }

        private void NovemberSnowcheckBox_CheckedChanged(object sender, EventArgs e)
        {
                              
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT November, PriceNovember FROM Months WHERE (BusinessName = '" + NamecomboBox.Text + "')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MonthsSnowdataGridView.DataSource = dt;
                con.Close();

            

            try
            {
                con.Close();

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void InsertradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OctobercheckBox.Checked && LawnLogopictureBox.Visible == true)
            {
                  DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "Confirm", MessageBoxButtons.YesNo);
                  if (dialogResult == DialogResult.Yes)
                  {
                      SqlConnection con = new SqlConnection();
                      con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                      con.Open();
                      SqlCommand cmd = new SqlCommand(@"UPDATE Months 
                        SET October= '" + ActivityFormtextBox.Text + "' WHERE (Name = '" + NamecomboBox.Text + "')", con);
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
                        SET PriceOctober= '" + AmountformtextBox2.Text + "' WHERE (Name = '" + NamecomboBox.Text + "')", conn);
                  cmdd.ExecuteNonQuery();
                  MessageBox.Show("Updated The Price of October!");

                  try
                  {
                      conn.Close();
                      OctobercheckBox.Checked = false;
                      InsertradioButton.Checked = false;
                      ActivityFormtextBox.Text = "";
                      AmountformtextBox2.Text = "";

                  }

                  finally
                  {
                      conn.Close();

                  }

            }
            if (NovembercheckBox.Checked && LawnLogopictureBox.Visible == true)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE Months 
                        SET November= '" + ActivityFormtextBox.Text + "' WHERE (Name = '" + NamecomboBox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Month of November!");

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
                        SET PriceNovember= '" + AmountformtextBox2.Text + "' WHERE (Name = '" + NamecomboBox.Text + "')", conn);
                cmdd.ExecuteNonQuery();
                MessageBox.Show("Updated The Price of November!");

                try
                {
                    conn.Close();
                    NovembercheckBox.Checked = false;
                    InsertradioButton.Checked = false;
                    ActivityFormtextBox.Text = "";
                    AmountformtextBox2.Text = "";

                }

                finally
                {
                    conn.Close();

                }
            }



            if (NovemberSnowcheckBox.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE Months 
                        SET November= '" + ActivityFormtextBox.Text + "' WHERE (BusinessName = '" + NamecomboBox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Month of November!");

                    try
                    {
                        con.Close();



                    }

                    finally
                    {
                        con.Close();

                    }
                

                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                    conn.Open();
                    SqlCommand cmdd = new SqlCommand(@"UPDATE Months 
                        SET PriceNovember= '" + AmountformtextBox2.Text + "' WHERE (BusinessName = '" + NamecomboBox.Text + "')", conn);
                    cmdd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Price of November!");

                    try
                    {
                        conn.Close();
                        NovemberSnowcheckBox.Checked = false;
                        InsertradioButton.Checked = false;
                        ActivityFormtextBox.Text = "";
                        AmountformtextBox2.Text = "";



                    }

                    finally
                    {
                        conn.Close();

                    }
                   
                }
            }

            else if (DecemberSnowcheckBox.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE Months 
                        SET December= '" + ActivityFormtextBox.Text + "' WHERE (BusinessName = '" + NamecomboBox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Month of December!");

                    try
                    {
                        con.Close();



                    }

                    finally
                    {
                        con.Close();

                    }

                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                    conn.Open();
                    SqlCommand cmdd = new SqlCommand(@"UPDATE Months 
                        SET PriceDecember= '" + AmountformtextBox2.Text + "' WHERE (BusinessName = '" + NamecomboBox.Text + "')", conn);
                    cmdd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Price of December!");

                    try
                    {
                        conn.Close();
                        NovemberSnowcheckBox.Checked = false;
                        InsertradioButton.Checked = false;
                        ActivityFormtextBox.Text = "";
                        AmountformtextBox2.Text = "";



                    }

                    finally
                    {
                        conn.Close();

                    }
                }
            }

            else if (JanuarySnowcheckBox.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE Months 
                        SET January= '" + ActivityFormtextBox.Text + "' WHERE (BusinessName = '" + NamecomboBox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Month of January!");

                    try
                    {
                        con.Close();



                    }

                    finally
                    {
                        con.Close();

                    }

                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                    conn.Open();
                    SqlCommand cmdd = new SqlCommand(@"UPDATE Months 
                        SET PriceJanuary= '" + AmountformtextBox2.Text + "' WHERE (BusinessName = '" + NamecomboBox.Text + "')", conn);
                    cmdd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Price of January!");

                    try
                    {
                        conn.Close();
                        NovemberSnowcheckBox.Checked = false;
                        InsertradioButton.Checked = false;
                        ActivityFormtextBox.Text = "";
                        AmountformtextBox2.Text = "";



                    }

                    finally
                    {
                        conn.Close();

                    }
                }
            }

            else if (FebruarySnowcheckBox.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE Months 
                        SET February= '" + ActivityFormtextBox.Text + "' WHERE (BusinessName = '" + NamecomboBox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Month of February!");

                    try
                    {
                        con.Close();



                    }

                    finally
                    {
                        con.Close();

                    }

                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                    conn.Open();
                    SqlCommand cmdd = new SqlCommand(@"UPDATE Months 
                        SET PriceFebruary= '" + AmountformtextBox2.Text + "' WHERE (BusinessName = '" + NamecomboBox.Text + "')", conn);
                    cmdd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Price of February!");

                    try
                    {
                        conn.Close();
                        NovemberSnowcheckBox.Checked = false;
                        InsertradioButton.Checked = false;
                        ActivityFormtextBox.Text = "";
                        AmountformtextBox2.Text = "";



                    }

                    finally
                    {
                        conn.Close();

                    }
                }
            }

            else if (MarchSnowcheckBox.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE Months 
                        SET March= '" + ActivityFormtextBox.Text + "' WHERE (BusinessName = '" + NamecomboBox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Month of March!");

                    try
                    {
                        con.Close();



                    }

                    finally
                    {
                        con.Close();

                    }

                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                    conn.Open();
                    SqlCommand cmdd = new SqlCommand(@"UPDATE Months 
                        SET PriceMarch= '" + AmountformtextBox2.Text + "' WHERE (BusinessName = '" + NamecomboBox.Text + "')", conn);
                    cmdd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Price of March!");

                    try
                    {
                        conn.Close();
                        NovemberSnowcheckBox.Checked = false;
                        InsertradioButton.Checked = false;
                        ActivityFormtextBox.Text = "";
                        AmountformtextBox2.Text = "";


                        
                    }

                    finally
                    {
                        conn.Close();

                    }
                }
            }

            else if (AprilSnowcheckBox.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE Months 
                        SET April= '" + ActivityFormtextBox.Text + "' WHERE (BusinessName = '" + NamecomboBox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Month of April!");

                    try
                    {
                        con.Close();



                    }

                    finally
                    {
                        con.Close();

                    }

                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                    conn.Open();
                    SqlCommand cmdd = new SqlCommand(@"UPDATE Months 
                        SET PriceApril= '" + AmountformtextBox2.Text + "' WHERE (BusinessName = '" + NamecomboBox.Text + "')", conn);
                    cmdd.ExecuteNonQuery();
                    MessageBox.Show("Updated The Price of April!");

                    try
                    {
                        conn.Close();
                        NovemberSnowcheckBox.Checked = false;
                        InsertradioButton.Checked = false;
                        ActivityFormtextBox.Text = "";
                        AmountformtextBox2.Text = "";


                       
                    }

                    finally
                    {
                        conn.Close();

                    }
                }
            }
        }

        private void AdressDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (todaysdateTimePicker.Value > SnowdateTimePicker.Value)
            {
                DataGridViewRow row = this.AdressDataGrid.Rows[e.RowIndex];
                BusinessNameTextbox.Text = row.Cells["BusinessName"].Value.ToString();
                AddresstextBox.Text = row.Cells["Address1"].Value.ToString();
                CitytextBox.Text = row.Cells["City"].Value.ToString();
            }
            else
            {
                DataGridViewRow row = this.AdressDataGrid.Rows[e.RowIndex];
                BusinessNameTextbox.Text = row.Cells["Business"].Value.ToString();
                AddresstextBox.Text = row.Cells["Address1"].Value.ToString();
                CitytextBox.Text = row.Cells["City"].Value.ToString();
            }
            
        }

        private void DecemberSnowcheckBox_CheckedChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT December, PriceDecember FROM Months WHERE (BusinessName = '" + NamecomboBox.Text + "')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MonthsSnowdataGridView.DataSource = dt;
            con.Close();



            try
            {
                con.Close();

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void JanuarySnowcheckBox_CheckedChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT January, PriceJanuary FROM Months WHERE (BusinessName = '" + NamecomboBox.Text + "')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MonthsSnowdataGridView.DataSource = dt;
            con.Close();



            try
            {
                con.Close();

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void FebruarySnowcheckBox_CheckedChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT February, PriceFebruary FROM Months WHERE (BusinessName = '" + NamecomboBox.Text + "')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MonthsSnowdataGridView.DataSource = dt;
            con.Close();



            try
            {
                con.Close();

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void MarchSnowcheckBox_CheckedChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT March, PriceMarch FROM Months WHERE (BusinessName = '" + NamecomboBox.Text + "')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MonthsSnowdataGridView.DataSource = dt;
            con.Close();



            try
            {
                con.Close();

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void AprilSnowcheckBox_CheckedChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT April, PriceApril FROM Months WHERE (BusinessName = '" + NamecomboBox.Text + "')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MonthsSnowdataGridView.DataSource = dt;
            con.Close();



            try
            {
                con.Close();

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceSnow invsnow = new InvoiceSnow();
            this.Hide();
            invsnow.Show();
        }

        private void invoiceIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num1, num2, res;
            num1 = Convert.ToInt32(invoiceIDcomboBox.Text);
            num2 = Convert.ToInt32(idcounttextBox.Text);
            res = num1 + num2;
            InvoiceIdTextbox.Text = Convert.ToString(res);
        }

        private void todaysdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            todaysdateTimePicker.Format = DateTimePickerFormat.Custom;
            todaysdateTimePicker.CustomFormat = "MM-dd-yyyy";
        }

        private void SnowdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SnowdateTimePicker.Format = DateTimePickerFormat.Custom;
            SnowdateTimePicker.CustomFormat = "MM-dd-yyyy";
        }

        private void OctobercheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OctobercheckBox.Checked)
            {
                MonthsSnowdataGridView.Visible = true;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT October, PriceOctober FROM Months WHERE (Name = '" + NamecomboBox.Text + "')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MonthsSnowdataGridView.DataSource = dt;
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

        private void NovembercheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NovembercheckBox.Checked)
            {
                MonthsSnowdataGridView.Visible = true;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT November, PriceNovember FROM Months WHERE (Name = '" + NamecomboBox.Text + "')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MonthsSnowdataGridView.DataSource = dt;
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

        private void emailInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailLawn emaillawn = new EmailLawn();
            emaillawn.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Noteslabel.Visible = true;
                NotesTexbox.Visible = true;
            }
            else if (checkBox1.Checked == false)
            {
                Noteslabel.Visible = false;
                NotesTexbox.Visible = false;
            }
             
        }

        private void NotesTexbox_TextChanged(object sender, EventArgs e)
        {
            NotesTexbox.ForeColor = Color.Red;
        }

        private void SeptcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SeptcheckBox.Checked)
            {
                MonthsSnowdataGridView.Visible = true;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT September, PriceSeptember FROM Months WHERE (Name = '" + NamecomboBox.Text + "')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MonthsSnowdataGridView.DataSource = dt;
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

      
          
       

    }
}
    


