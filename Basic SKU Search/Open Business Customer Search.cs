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


namespace Basic_SKU_Search
{
    public partial class Open_Business_Customer_Search : Form
    {

        string CountryName;
        string CurrencyCode;
        private string ConnectionString;
        public Open_Business_Customer_Search()
        {
            InitializeComponent();
            OpenWait.Hide();
            OpenResult.Hide();
            SetConnectionString();
        }

        private void SetConnectionString()
        {
            ConnectionString = "Data Source=" + ServerDetails.GetServerURL() + ";Initial Catalog=" + ServerDetails.GetServerName() + "; Integrated Security=SSPI";
        }

        private void Search_Click(object sender, EventArgs e)
        {
            
        }
        private string GetCunCode(string CountryName)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                SqlCommand cmd = new SqlCommand(String.Format(@"select saleslocationcode from saleslocation where saleslocationname = '" + CountryName + "'"), conn);

                conn.Open();

                string CunCode = cmd.ExecuteScalar().ToString();

                return CunCode;

            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click_1(object sender, EventArgs e)
        {
            SetConnectionString();

            CountryName = Country.Text;
            CurrencyCode = Currency.Text;


            if (CountryName == "")
            {
                MessageBox.Show("Please Select Country");

            }


            else if (CurrencyCode == "")
            {
                MessageBox.Show("Please Select Currency");

            }


            else
            {
                OpenWait.Show();
                OpenSearch.Enabled = false;

                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {

                    string CunCode = GetCunCode(CountryName);

                    SqlCommand cmd = new SqlCommand(String.Format(@"select CustomerNumber,S.SalesLocationName,CustomerTypeCode,C.CurrencyCode, CustomerStatusCode,CustomerName, * from customer C
                                                                join Saleslocation S on C.Saleslocationcode = S.saleslocationcode
                                                                where C.CustomerStatusCode = 'ACT'
                                                                and S.SalesLocationCode = '{0}'
                                                                and C.CustomerNumber like '0005%'", CunCode), conn);

                    conn.Open();

                    DataTable dt = new DataTable();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    OpenWait.Hide();
                    conn.Close();
                    OpenResult.Show();
                    OpenSearch.Enabled = true;
                    OpenResult.DataSource = dt;

                }



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home Open = new Home();
            Open.Show();
        }


    }
}
