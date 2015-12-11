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
    public partial class Bid : Form
    {
        public Bid()
        {
            InitializeComponent();
            
           // BidLawnLoad();
          //  BididSnow();
           EstimateNumberLoad();
           NameLoad();
                
        }

        void NameLoad()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
            SqlCommand cmd = new SqlCommand("SELECT * FROM Bids2015", con);
            SqlDataReader dr;


            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {


                    NameBidcomboBox.Items.Add(dr["BusinessName"]);

                }
            }
            catch
            {

            }

        }

        void EstimateNumberLoad()
        {
           
            if (todaysBiddateTimePicker.Value > SnowBiddateTimePicker.Value)
                //(invsnow.pictureBox1.Visible == true)
            {
                BidLawnpictureBox1.Visible = false;
                SnowBidpictureBox.Visible = true;

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                SqlCommand cmdd = new SqlCommand("SELECT TOP 1 * FROM Bids2015 ORDER BY EstimateNumber DESC", conn);
                SqlDataReader drr;


                try
                {
                    conn.Open();
                    drr = cmdd.ExecuteReader();
                    while (drr.Read())
                    {


//                        EstimateNumberSnowcomboBox.Items.Add(drr["EstimateNumber"]);


                    }
                }
                catch
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            else if (todaysBiddateTimePicker.Value < SnowBiddateTimePicker.Value)
            {
                BidLawnpictureBox1.Visible = true;
                SnowBidpictureBox.Visible = false;

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


                        EstimateLawnNumcomboBox.Items.Add(dr["EstimateNum"]);

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
        void BididSnow()
        {
            //InvoiceSnow invsnow = new InvoiceSnow();
            //if (invsnow.pictureBox1.Visible == false)
            //{
            //    SqlConnection conn = new SqlConnection();
            //    conn.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
            //    SqlCommand cmdd = new SqlCommand("SELECT TOP 1 * FROM Bids2015 ORDER BY idBids DESC", conn);
            //    SqlDataReader drr;


            //    try
            //    {
            //        conn.Open();
            //        drr = cmdd.ExecuteReader();
            //        while (drr.Read())
            //        {


            //            BidSnowidcomboBox.Items.Add(drr["idBids"]);


            //        }
            //    }
            //    catch
            //    {

            //    }
            //    finally
            //    {
            //        conn.Close();
            //    }
            //}
        }
      
      
        void BidLawnLoad()
        {
            InvoiceSnow invsnow = new InvoiceSnow();
            if (invsnow.pictureBox1.Visible == true)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Bids ORDER BY idBids DESC", con);
                SqlDataReader dr;


                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {


                        BidLawnidcomboBox.Items.Add(dr["idBids"]);

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

        private void CreateBidButton_Click(object sender, EventArgs e)
        {

           

                // THIS IS FOR THE BID SHEET

                //Date
            DatetextBoxBid.Text = BiddateTimePicker.Text;


               



                //Estimate Number
                EstimateNumtextBoxForm.Text = EstimateNumtextBox.Text;
                EstimateNumtextBox.Text = "";

                //Name 
                
                NametexboxForm.Text = NameBidcomboBox.Text;
                NameBidcomboBox.Text = "";

               //Address

                AddresstextBoxform.Text = addressbidtextBox.Text;
                addressbidtextBox.Text = "";

              




               
            

           
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
           

                //Date
                //DateBidtextBox.Text = DatetextBoxBid.Text;
                //DatetextBoxBid.Text = "";

                //Estimate Number

                EstimateNumtextBox.Text = EstimateNumtextBoxForm.Text;
                EstimateNumtextBoxForm.Text = "";

                //Name and Address 

             

               
            
        }

       

        private void ActivityBidtextBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Validatebutton_Click(object sender, EventArgs e)
        {
            //  Login log = new Login();
            //log.ApplicationcomboBox.Text = "Lawn";
            //if (log.ApplicationcomboBox.Text == "Lawn")
            //{

            //    SqlDataReader reader = null;
            //    SqlConnection con = new SqlConnection();
            //    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("SELECT idBids FROM Bids where idBids = '" + IdBidTextbox.Text + "' ", con);
            //    cmd.Parameters.AddWithValue("idBids", IdBidTextbox.Text);
            //    reader = cmd.ExecuteReader();

            //    if (reader.HasRows)
            //    {
            //        Checkbutton.Visible = false;
            //        Redbutton.Visible = true;


            //    }
            //    else
            //    {
            //        Checkbutton.Visible = true;
            //        Redbutton.Visible = false;

            //    }
            //}
        }

        private void EstimateNumberSnowcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   int num1, num2, res;
         //  // num1 = Convert.ToInt32(EstimateNumberSnowcomboBox.Text);
         //   num2 = Convert.ToInt32(AddBidtextBox.Text);
         ////   res = num1 + num2;
         //   EstimateNumtextBox.Text = Convert.ToString(res);
        }

        private void EstimateNumtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            NameBidcomboBox.Text = "";
          
           
        }

        private void EstimateLawnNumcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int num1, num2, res;
            //num1 = Convert.ToInt32(EstimateLawnNumcomboBox.Text);
            //num2 = Convert.ToInt32(AddBidtextBox.Text);
            //res = num1 + num2;
            //EstimateNumtextBox.Text = Convert.ToString(res);
        }

        private void SaveSnowInvoicebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Bids2015 (idBids, BusinessName, EstimateDate, EstimateNumber, Email, Address, Details, Total ) VALUES ('" + this.IdBidTextbox.Text + "','" + this.NametexboxForm.Text + "','" + this.DatetextBoxBid.Text + "','" + this.EstimateNumtextBoxForm.Text + "','" + this.EmailBidtextBox.Text + "','" + this.AddresstextBoxform.Text + "','" + this.ActivityBidFormtextBox.Text + "','" + this.TotalBidFormtextBox.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Snow Bid Added!");
            try
            {

                NameBidcomboBox.Text = "";
               
               
                EmailBidtextBox.Clear();

            }
            catch
            {

            }
            finally
            {
                con.Close();
                this.Close();
            }
                    
        }

        private void ValidateSnowbutton_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT idBids FROM Bids2015 where idBids = '" + IdBidTextbox.Text + "' ", con);
            cmd.Parameters.AddWithValue("idBids", IdBidTextbox.Text);
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

            }
        }

        private void CreateSnowButton_Click(object sender, EventArgs e)
        {

        }

        private void BidLawnidcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int num1, num2, res;
            //num1 = Convert.ToInt32(BidLawnidcomboBox.Text);
            //num2 = Convert.ToInt32(Addlabel.Text);
            //res = num1 + num2;
            //IdBidTextbox.Text = Convert.ToString(res);
        }

        private void BidSnowidcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int num1, num2, res;
            //num1 = Convert.ToInt32(BidSnowidcomboBox.Text);
            //num2 = Convert.ToInt32(Addlabel.Text);
            //res = num1 + num2;
            //IdBidTextbox.Text = Convert.ToString(res);
        }

        private void TotalBidtextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DatetextBoxBid_TextChanged(object sender, EventArgs e)
        {

        }

        private void BiddateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            BiddateTimePicker.Format = DateTimePickerFormat.Custom;
            BiddateTimePicker.CustomFormat = "MM-dd-yyyy";
        }
    }
}
