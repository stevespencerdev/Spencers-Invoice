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
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
           
                customerIDLoad();           
              
        }

        void customerIDLoad()
    {
        if (hiddenpaymentdateTimePicker.Value < hiddenpaymentSnowdateTimePicker.Value)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Customer ORDER BY idCustomer DESC", con);
            SqlDataReader dr;



            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {



                    CustomerIDcomboBox.Items.Add(dr["idCustomer"]);
                }
            }
            catch
            {

            }
        }
        else if(hiddenpaymentdateTimePicker.Value > hiddenpaymentSnowdateTimePicker.Value)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Customer ORDER BY idCustomer DESC", con);
            SqlDataReader dr;
           
           // CustomerIDcomboBox.Visible = false;



            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CustomerIDcomboBox.Items.Add(dr["idCustomer"]);


                }
            }
            catch
            {

            }
        
        }
               
    }
       
        
  

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            if (hiddenpaymentdateTimePicker.Value < hiddenpaymentSnowdateTimePicker.Value)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Customer (idCustomer, FirstName, LastName, Business, Address1, City, Phone, Email) VALUES ('" + this.CustomerIDcomboBox.Text + "','" + this.FirstNametextBox.Text + "','" + this.LastNametextBox.Text + "','" + this.BusinessNametextBox.Text + "','" + this.AddresstextBox.Text + "','" + this.CitycomboBox.Text + "','" + this.PhonetextBox.Text + "','" + this.EmailtextBox.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added New Lawn Customer");

                try
                {
                    BusinessNametextBox.Clear();
                    CustomerIDcomboBox.Text = "";
                    EmailtextBox.Clear();
                    FirstNametextBox.Clear();
                    LastNametextBox.Clear();
                    AddresstextBox.Clear();
                    CitycomboBox.Text = "";
                    PhonetextBox.Clear();
                    con.Close();
                }

                catch
                {

                }
            }
            else if (hiddenpaymentdateTimePicker.Value > hiddenpaymentSnowdateTimePicker.Value)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersSnow;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Customer (idCustomer, FirstName, LastName, BusinessName, Address1, City, Phone, Email) VALUES ('" + this.CustomerIDcomboBox.Text + "','" + this.FirstNametextBox.Text + "','" + this.LastNametextBox.Text + "','" + this.BusinessNametextBox.Text + "','" + this.AddresstextBox.Text + "','" + this.CitycomboBox.Text + "','" + this.PhonetextBox.Text + "','" + this.EmailtextBox.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added New Snow Customer");

                try
                {
                    BusinessNametextBox.Clear();
                   
                    EmailtextBox.Clear();
                    FirstNametextBox.Clear();
                    LastNametextBox.Clear();
                    AddresstextBox.Clear();
                    CitycomboBox.Text = "";
                    PhonetextBox.Clear();
                    con.Close();
                }

                catch
                {

                }
            }
                      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=ha7y9i5dmo.database.windows.net;Initial Catalog=SpencersLawn;User ID=spencers;Password=Specialized8955";
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO DropDown  (FullName, idDropDown, Email) VALUES ('" + this.BusinessNametextBox.Text + "','" + this.CustomerIDcomboBox.Text + "','" + this.EmailtextBox.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Email and Name Added!");

            }
            try
            {

                BusinessNametextBox.Clear();
                CustomerIDcomboBox.Text = "";
                EmailtextBox.Clear();

            }
            catch
            {

            }
        }

        private void NewcusSubmitbtn_Click(object sender, EventArgs e)
        {

        }

      

       
    }
}
