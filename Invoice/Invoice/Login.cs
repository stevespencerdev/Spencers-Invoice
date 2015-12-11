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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void Loginbutton_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                con.Open();
                string UserName = usernametextbox.Text;
                string Password1 = PasswordtextBox.Text;
                SqlCommand cmd = new SqlCommand("SELECT UserName, Password1 FROM login where UserName= '" + usernametextbox.Text + "' and Password1 = '" + PasswordtextBox.Text + "' ", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("access granted");
                    this.Hide();
                    InvoiceSnow invs = new InvoiceSnow();
                    invs.ShowDialog();
                    usernametextbox.Clear();
                    PasswordtextBox.Clear();


                }
                else
                {
                    MessageBox.Show("Access Denied");
                    usernametextbox.Clear();
                    PasswordtextBox.Clear();
                }
                con.Close();
            

                   
            //if (ApplicationcomboBox.Text == "Snow")
            //{
                

            //    SqlConnection con = new SqlConnection();
            //    con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
            //    con.Open();
            //    string UserName = usernametextbox.Text;
            //    string Password1 = PasswordtextBox.Text;
            //    SqlCommand cmd = new SqlCommand("SELECT UserName, Password1 FROM login where UserName= '" + usernametextbox.Text + "' and Password1 = '" + PasswordtextBox.Text + "' ", con);
            //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    sda.Fill(dt);
            //    if (dt.Rows.Count > 0)
            //    {
            //        MessageBox.Show("access granted");
            //        this.Hide();
            //        InvoiceSnow invs = new InvoiceSnow();
            //        invs.ShowDialog();
            //        usernametextbox.Clear();
            //        PasswordtextBox.Clear();


            //    }
            //    else
            //    {
            //        MessageBox.Show("Access Denied");
            //        usernametextbox.Clear();
            //        PasswordtextBox.Clear();
            //    }
            //    con.Close();
            //}

            //if(ApplicationcomboBox.Text == "Lawn")
            //{
                
            //    SqlConnection conn = new SqlConnection();
            //    conn.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
            //    conn.Open();
            //    string UserName1 = usernametextbox.Text;
            //    string Password2 = PasswordtextBox.Text;
            //    SqlCommand cmmd = new SqlCommand("SELECT UserName, Password1 FROM login where UserName= '" + usernametextbox.Text + "' and Password1 = '" + PasswordtextBox.Text + "' ", conn);
            //    SqlDataAdapter sdaa = new SqlDataAdapter(cmmd);
            //    DataTable dtt = new DataTable();
            //    sdaa.Fill(dtt);
            //    if (dtt.Rows.Count > 0)
            //    {
            //        MessageBox.Show("access granted");
            //        this.Hide();
            //        invoice inv = new invoice();
            //        inv.Show();
            //        usernametextbox.Clear();
            //        PasswordtextBox.Clear();
                   

            //    ;}
            //    else
            //    {
            //        MessageBox.Show("Access Denied");
            //        usernametextbox.Clear();
            //        PasswordtextBox.Clear();
            //    }
            //    conn.Close();
            //}
            
            
            
           // DataTable dt = new System.Data.DataTable();
            //sda.Fill(dt);
           
          
        }

        public void PasswordtextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordtextBox.PasswordChar = '*';
        }

        private void ApplicationcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
