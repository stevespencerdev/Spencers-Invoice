using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;


namespace Invoice
{
    //public class login: Form
    //{

    //    private void InitializeComponent()
    //    {
    //        this.SuspendLayout();
    //        // 
    //        // login
    //        // 
    //        this.ClientSize = new System.Drawing.Size(809, 429);
    //        this.Name = "login";
    //        this.ResumeLayout(false);

    //    }
    //}
    public partial class EmailLawn : Form
    {
        public EmailLawn()
        {
            InitializeComponent();
            //SnowcomboBoxemaillist.Visible = false;
            FillCombo();
          

            
         
        }

  
            void FillCombo() // filling email address drop down with what's in sql 
        {

            if (todaysdateTimePicker.Value < SnowdateTimePicker.Value )
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


                            comboBoxemailtst.Items.Add(dr["Business"]);
                            comboBoxemailtst.Items.Add(dr["Email"]);



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


                        comboBoxemailtst.Items.Add(dr["BusinessName"]);
                        comboBoxemailtst.Items.Add(dr["Email"]);



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
       
        private void Sendbtn_Click(object sender, EventArgs e)
        {
           // MailMessage mail = new MailMessage(emailaddtbx.Text, Rectbx.Text, subtbx.Text, bodytbx.Text);
            MailMessage mail = new MailMessage(emailaddtbx.Text, comboBoxemailtst.Text, subtbx.Text, bodytbx.Text);
            if (!string.IsNullOrEmpty(attachbtx.Text))
            {
                mail.Attachments.Add(new Attachment(attachbtx.Text));
              
            }
            if (!string.IsNullOrEmpty(attachmentbx2.Text))
            {
                mail.Attachments.Add(new Attachment(attachmentbx2.Text));
            }
               
            SmtpClient client = new SmtpClient(smpttbx.Text);
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(usernmtexbx.Text, pwtbx.Text);
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Mail Sent " + comboBoxemailtst.Text, "Success", MessageBoxButtons.OK);

            try
            {
                attachbtx.Clear();
                attachmentbx2.Clear();
                comboBoxemailtst.SelectedIndex = -1;
                comboBoxemailtst.Text = "";
               
            }
            catch
            {

            }

            bodytbx.Text = @"Dear,

Here's your invoice! We appreciate your prompt payment.

Thanks for your business!
Spencers Lawn Maintenance";
        }

        private void browsehbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string pdfPath = dlg.FileName.ToString();
                attachbtx.Text = pdfPath;
            }
           
        }

        private void browsebtn2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string pdfPath = dlg.FileName.ToString();
                attachmentbx2.Text = pdfPath;
            }
        }

        private void bodytbx_TextChanged(object sender, EventArgs e)
        {
            bodytbx.ScrollBars = ScrollBars.Both;
            bodytbx.WordWrap = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
              
        
        

        private void Rectbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxemailtst_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void IDtbx_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SnowcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void copytextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void SnowDatabasecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Snowbutton_Click(object sender, EventArgs e)
        {

            //SnowcomboBoxemaillist.Visible = true;
            //comboBoxemailtst.Visible = false;
            //togglelbl.Text = "Snow Removal Email";
            
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


                    comboBoxemailtst.Items.Add(dr["BusinessName"]);
                    comboBoxemailtst.Items.Add(dr["Email"]);



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

        private void LoadLawnDatacheckBox_CheckedChanged(object sender, EventArgs e)
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


                    comboBoxemailtst.Items.Add(dr["Business"]);
                    comboBoxemailtst.Items.Add(dr["Email"]);



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
