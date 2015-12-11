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
    public partial class Contract : Form
    {
        public Contract()
        {
            InitializeComponent();
        }

        private void Contract_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //InvoiceSnow invsnow = new InvoiceSnow();


            //if (invsnow.LawnLogopictureBox.Visible == true)
            //    //(LawncontractpictureBox.Visible == true && SnowContractpictureBox.Visible == false)
            //{
            //    LawncontractpictureBox.Visible = true;

            //    SqlConnection con = new SqlConnection();
            //    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("INSERT INTO Contracts (idContract, ContractNum, Date, NameAddress, Activity, Amount, Total ) VALUES ('" + this.idContracttextBox.Text + "','" + this.InvoiceNumtextBoxForm.Text + "','" + this.DatetextBoxInvoice.Text + "','" + this.NameAddressTxbox.Text + "','" + this.ActivityFormtextBox.Text + "','" + this.AmountformtextBox2.Text + "','" + this.TotaltextBox.Text + "')", con);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show(" Lawn Contract Added!");

            //    try
            //    {
            //        con.Close();
                    

            //    }
            //    catch
            //    {

            //    }

            //    finally
            //    {
            //        con.Close();
                   
            //    }
            //}

            //else if (invsnow.LawnLogopictureBox.Visible == false)
            //    //(SnowContractpictureBox.Visible == true && LawncontractpictureBox.Visible == false)
            //{
            //SnowContractpictureBox.Visible = false;
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
            //conn.Open();
            //SqlDataAdapter sdaa = new SqlDataAdapter("SELECT * FROM Contracts )", conn);
            //DataTable dtt = new DataTable();
            //sdaa.Fill(dtt);
            //contractdataGridView.DataSource = dtt;
            //conn.Close();



            //try
            //{
            //    //MarchcheckBox.Checked = false;

            //}
            //catch
            //{

            //}



                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Contracts (idContract, ContractNum, Date, NameAddress, Activity, Amount, Total ) VALUES ('" + this.idContracttextBox.Text + "','" + this.InvoiceNumtextBoxForm.Text + "','" + this.DatetextBoxInvoice.Text + "','" + this.NameAddressTxbox.Text + "','" + this.ActivityFormtextBox.Text + "','" + this.AmountformtextBox2.Text + "','" + this.TotaltextBox.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Snow Contract Added!");


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

        private void LoadGridbutton_Click(object sender, EventArgs e)
        {
           
                //SqlConnection conn = new SqlConnection();
                //conn.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                //conn.Open();
                //SqlDataAdapter sdaa = new SqlDataAdapter("SELECT * FROM Contracts", conn);
                //DataTable dtt = new DataTable();
                //sdaa.Fill(dtt);
                //contractdataGridView.DataSource = dtt;
                //conn.Close();



                //try
                //{
                //   conn.Close();

                //}
                //catch
                //{

                //}
                //finally
                //{
                //    conn.Close();
                //}
            

            if (todaysBiddateTimePicker.Value > SnowBiddateTimePicker.Value)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                conn.Open();
                SqlDataAdapter sdaa = new SqlDataAdapter("SELECT * FROM Contracts", conn);
                DataTable dtt = new DataTable();
                sdaa.Fill(dtt);
                contractdataGridView.DataSource = dtt;
                conn.Close();



                try
                {
                    conn.Close();

                }
                catch
                {

                }

                finally
                {
                    conn.Close();
                }
            }
        }

        private void contractdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.contractdataGridView.Rows[e.RowIndex];
            idContracttextBox.Text = row.Cells["idContract"].Value.ToString();

           // DataGridViewRow row = this.contractdataGridView.Rows[e.RowIndex];
            InvoiceNumtextBoxForm.Text = row.Cells["ContractNum"].Value.ToString();

           // DataGridViewRow row = this.contractdataGridView.Rows[e.RowIndex];
            DatetextBoxInvoice.Text = row.Cells["Date"].Value.ToString();

          //  DataGridViewRow row = this.contractdataGridView.Rows[e.RowIndex];
            NameAddressTxbox.Text = row.Cells["NameAddress"].Value.ToString();

           // DataGridViewRow row = this.contractdataGridView.Rows[e.RowIndex];
            ActivityFormtextBox.Text = row.Cells["Activity"].Value.ToString();

          //  DataGridViewRow row = this.contractdataGridView.Rows[e.RowIndex];
            AmountformtextBox2.Text = row.Cells["Amount"].Value.ToString();

           // DataGridViewRow row = this.contractdataGridView.Rows[e.RowIndex];
            TotaltextBox.Text = row.Cells["Total"].Value.ToString();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ContractPage2 cp2 = new ContractPage2();
            cp2.Show();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void HideTotalcheckBox_CheckedChanged(object sender, EventArgs e)
        {

            TotaltextBox.Visible = false;
            textBoxpage.Visible = false;
            

            if(HideTotalcheckBox.Checked == false)
            {
                TotaltextBox.Visible = true;
                textBoxpage.Visible = true;
            }
        }
    }
}
