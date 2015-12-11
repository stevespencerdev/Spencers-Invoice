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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            SearchFill();
            idPaymentLoad();

        }


        void SearchFill() // filling email address drop down with what's in sql 
        {
            {

                if (hiddenpaymentdateTimePicker.Value < hiddenpayment2dateTimePicker.Value)
                
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

                            NamePaymentcomboBox.Items.Add(dr["FullName"]);
                            NameCombobox.Items.Add(dr["FullName"]);



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
                      
           
                else
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

                            NamePaymentcomboBox.Items.Add(dr["BusinessName"]);
                            NameCombobox.Items.Add(dr["BusinessName"]);



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

        }








        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (hiddenpaymentdateTimePicker.Value < hiddenpayment2dateTimePicker.Value)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT *  FROM Invoice WHERE (InvoiceNumber = '" + InvoiceNumbercomboBox.Text + "')", con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                PaymentdataGridView.DataSource = dt;
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
            else if (hiddenpaymentdateTimePicker.Value > hiddenpayment2dateTimePicker.Value)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT *  FROM Invoice WHERE (InvoiceNumber = '" + InvoiceNumbercomboBox.Text + "')", con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                PaymentdataGridView.DataSource = dt;
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

        }


        private void InvoiceNumbercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NamePaymentcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (hiddenpaymentdateTimePicker.Value < hiddenpayment2dateTimePicker.Value)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT InvoiceNumber, Discription, PreviousBal, NewTotalBal, InvoiceDate, TotalPaid FROM Invoice WHERE (Name = '" + NamePaymentcomboBox.Text + "')", con);
                //SqlDataAdapter sda = new SqlDataAdapter("SELECT *  FROM Invoice WHERE (InvoiceNumber = '" + InvoiceNumbercomboBox.Text + "')", con);
                //SqlDataAdapter sda = new SqlDataAdapter("SELECT InvoiceNumber FROM Invoice WHERE (InvoiceNumber = '" + NamePaymentcomboBox.Text + "')", con);
                // ("select * from Invoice", con searchtbx);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                PaymentdataGridView.DataSource = dt;
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
            if (NamePaymentcomboBox.SelectedItem != null && hiddenpaymentdateTimePicker.Value < hiddenpayment2dateTimePicker.Value) 
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                SqlCommand cmd = new SqlCommand("SELECT * FROM Invoice WHERE (Name = '" + NamePaymentcomboBox.Text + "')", con);
                SqlDataReader dr;


                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {


                        InvoiceNumbercomboBox.Items.Add(dr["InvoiceNumber"]);
                        //comboBoxemailtst.Items.Add(dr["Email"]);



                    }
                }
                catch
                {

                }
                finally
                {
                    con.Close();
                    InvoiceNumbercomboBox.Text = string.Empty;
                }
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT InvoiceNumber, Discription, PreviousBalance, NewTotalBalance, InvoiceDate, TotalPaid FROM Invoice WHERE (BusinessName = '" + NamePaymentcomboBox.Text + "')", con);
               
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                PaymentdataGridView.DataSource = dt;
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

                //SqlConnection conn = new SqlConnection();
                //conn.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                //conn.Open();
                //SqlDataAdapter sdaa = new SqlDataAdapter("SELECT InvoiceNumber, Discription, PreviousBal, NewTotalBal, InvoiceDate, TotalPaid FROM Invoice WHERE (Name = '" + NamePaymentcomboBox.Text + "')", conn);
                ////SqlDataAdapter sda = new SqlDataAdapter("SELECT *  FROM Invoice WHERE (InvoiceNumber = '" + InvoiceNumbercomboBox.Text + "')", con);
                ////SqlDataAdapter sda = new SqlDataAdapter("SELECT InvoiceNumber FROM Invoice WHERE (InvoiceNumber = '" + NamePaymentcomboBox.Text + "')", con);
                //// ("select * from Invoice", con searchtbx);
                //System.Data.DataTable dtt = new System.Data.DataTable();
                //sdaa.Fill(dtt);
                //PaymentdataGridView.DataSource = dtt;
                //con.Close();

                //try
                //{
                //    con.Close();
                //}
                //catch
                //{ }

                //finally
                //{
                //    con.Close();
                //}
            }
          

        }

        private void newSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value < dateTimePickerSnow.Value)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP 25 * FROM Invoice ORDER BY InvoiceNumber DESC", con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                NewPaymentdataGridView.DataSource = dt;
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


            else if (dateTimePicker2.Value > dateTimePickerSnow.Value)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP 25 * FROM Invoice ORDER BY InvoiceNumber DESC", con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                NewPaymentdataGridView.DataSource = dt;
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
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value < dateTimePickerSnow.Value)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT InvoiceNumber, Name, NewTotalBal, InvoiceDate, TotalPaid FROM Invoice WHERE TotalPaid IS NULL", con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                NewPaymentdataGridView.DataSource = dt;
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


            else if (dateTimePicker2.Value > dateTimePickerSnow.Value)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT InvoiceNumber, BusinessName, NewTotalBalance, InvoiceDate, TotalPaid FROM Invoice WHERE TotalPaid IS NULL", con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                NewPaymentdataGridView.DataSource = dt;
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
          
           
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
           
            


            if (dateTimePicker2.Value < dateTimePickerSnow.Value)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Payments (idPayments, InvoiceNumber, TotalPaid, PaymentDate, Name ) VALUES ('" + this.PaymentidTextbox.Text + "','" + this.InvoiceNumbertextbox.Text + "','" + this.TotalPaidtextbox.Text + "','" + this.PaymentdateTimePicker.Text + "', '" + this.NameCombobox.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Invoice Added!");

                try
                {

                    con.Close();
                    PaymentdateTimePicker.Text = "";


                }

                catch
                {

                }
                finally
                {
                    con.Close();

                }
            }

            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Payments2015 (idPayments, InvoiceNumber, TotalPaid, PaymentDate, BusinessName ) VALUES ('" + this.PaymentidTextbox.Text + "','" + this.InvoiceNumbertextbox.Text + "','" + this.TotalPaidtextbox.Text + "','" + this.PaymentdateTimePicker.Text + "', '" + this.NameCombobox.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Invoice Added!");

                try
                {

                    con.Close();
                    PaymentdateTimePicker.Text = "";


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

        private void PaymentInvoicebutton_Click(object sender, EventArgs e)
        {
           

            if (dateTimePicker2.Value < dateTimePickerSnow.Value)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Invoice SET TotalPaid = '" + TotalPaidtextbox.Text + "' WHERE (InvoiceNumber= '" + InvoiceNumbertextbox.Text + "')", con);
                //"UPDATE Invoice SET TotalPaid = '" + this.paidtbx.Text + "' WHERE TotalPaid ='"this.invoicenumuptbx.Text"';";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Invoice Payment Updated");
                try
                {

                    con.Close();

                    InvoiceNumbertextbox.Clear();
                    PaymentdateTimePicker.Text = "";
                    this.Hide();
                    Payment pay = new Payment();
                    pay.Show();






                }

                catch
                {

                }
                finally
                {
                    con.Close();


                }
            }
           

            else if (dateTimePicker2.Value > dateTimePickerSnow.Value)
            {
              
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Invoice SET TotalPaid = '" + TotalPaidtextbox.Text + "' WHERE (InvoiceNumber= '" + InvoiceNumbertextbox.Text + "')", con);
                //"UPDATE Invoice SET TotalPaid = '" + this.paidtbx.Text + "' WHERE TotalPaid ='"this.invoicenumuptbx.Text"';";
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Snow Invoice Payment Updated");
                try
                {

                    con.Close();

                    InvoiceNumbertextbox.Clear();
                    PaymentdateTimePicker.Text = "";
                    this.Hide();
                    Payment pay = new Payment();
                    pay.Show();

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

        private void PaymentidLBL_Click(object sender, EventArgs e)
        {
         
        }
        void idPaymentLoad()
        {
            if (dateTimePicker2.Value < dateTimePickerSnow.Value)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM payments ORDER BY idPayments  DESC", con);
                SqlDataReader dr;

                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {


                        IdPaymentcombobox.Items.Add(dr["IdPayments"]);

                    }
                }
                catch
                {

                }
            }
            else if (dateTimePicker2.Value > dateTimePickerSnow.Value)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Payments2015 ORDER BY idPayments  DESC", con);
                SqlDataReader dr;

                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {


                        IdPaymentcombobox.Items.Add(dr["IdPayments"]);

                    }
                }
                catch
                {

                }
            }
        }

        private void IdPaymentcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            invoice inv = new invoice();
            

            int num1, num2, res;
            num1 = Convert.ToInt32(inv.AddidTextbox.Text);
            num2 = Convert.ToInt32(IdPaymentcombobox.Text);
            res = num1 + num2;
            PaymentidTextbox.Text = Convert.ToString(res);
        }

        private void NewPaymentdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if  (dateTimePicker2.Value < dateTimePickerSnow.Value)
            {
                DataGridViewRow row = this.NewPaymentdataGridView.Rows[e.RowIndex];
                InvoiceNumbertextbox.Text = row.Cells["InvoiceNumber"].Value.ToString();
                TotalPaidtextbox.Text = row.Cells["NewTotalBal"].Value.ToString();
                NameCombobox.Text = row.Cells["Name"].Value.ToString(); 
            }
            else if (dateTimePicker2.Value > dateTimePickerSnow.Value)
            {
                DataGridViewRow row = this.NewPaymentdataGridView.Rows[e.RowIndex];
                InvoiceNumbertextbox.Text = row.Cells["InvoiceNumber"].Value.ToString();
                TotalPaidtextbox.Text = row.Cells["NewTotalBalance"].Value.ToString();
                NameCombobox.Text = row.Cells["BusinessName"].Value.ToString();

                
            }




           

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            PaymentdateTimePicker.Format = DateTimePickerFormat.Custom;
            PaymentdateTimePicker.CustomFormat = "MM-dd-yyyy";
        }

       

        private void hiddenpaymentdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            hiddenpaymentdateTimePicker.Format = DateTimePickerFormat.Custom;
            hiddenpaymentdateTimePicker.CustomFormat = "MM-dd-yyyy";
        }

        private void hiddenpayment2dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            hiddenpayment2dateTimePicker.Format = DateTimePickerFormat.Custom;
            hiddenpayment2dateTimePicker.CustomFormat = "MM-dd-yyyy";
        }

        private void PaymentdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.PaymentdataGridView.Rows[e.RowIndex];
            InvoiceNumbercomboBox.Text = row.Cells["InvoiceNumber"].Value.ToString();
           
        }

        private void LoadLawnDatacheckBox_CheckedChanged(object sender, EventArgs e)
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

                            NamePaymentcomboBox.Items.Add(dr["FullName"]);
                            NameCombobox.Items.Add(dr["FullName"]);



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

        private void LoadSnowDataCheckbox_CheckedChanged(object sender, EventArgs e)
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

                        NamePaymentcomboBox.Items.Add(dr["BusinessName"]);
                        NameCombobox.Items.Add(dr["BusinessName"]);



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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT InvoiceNumber, Name, NewTotalBal, InvoiceDate, TotalPaid FROM Invoice WHERE TotalPaid IS NULL", con);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            NewPaymentdataGridView.DataSource = dt;
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT InvoiceNumber, BusinessName, NewTotalBalance, InvoiceDate, TotalPaid FROM Invoice WHERE TotalPaid IS NULL", con);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            NewPaymentdataGridView.DataSource = dt;
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
                     
    }
}
            

                
        
            
        
    

        
        

       
    
 

    



          
    

            
       
    
            
    

