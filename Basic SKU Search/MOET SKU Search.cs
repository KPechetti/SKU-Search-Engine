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
    public partial class MOET_Sku_Search : Form
    {

        string OrderType = "";
        string CountryName = "";
        string CustomerID = "";
        string CustomerType = "";
        string CurrencyCode = "";
        string CountryCode = "";
        string StatusCode = "";
        string ConnectionString ;
       
        DataTable dt = new DataTable();

        public MOET_Sku_Search()
        {
            InitializeComponent();
            SetConnectionString();
            MoetWait.Hide();
            MoetResult.Hide();
            LoadCountryDropdown();
        }

        private void SetConnectionString()
        {
            ConnectionString = "Data Source=" + ServerDetails.GetServerURL() + ";Initial Catalog=" + ServerDetails.GetServerName() + "; Integrated Security=SSPI";
        }




        private void MOET_Sku_Search_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Country_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OrderType = MoetOrder.Text;
            CountryName = Country.Text;
            CustomerType = MoetCusType.Text;
            CustomerID = CustomerNumber.Text;
            CurrencyCode = Currency.Text;


            if (OrderType == "")
            {

                MessageBox.Show("Please select orderType");

            }


            else if (CountryName == "")
            {


                MessageBox.Show("Please select CountryName");


            }


            else if (CustomerType == "")
            {


                MessageBox.Show("Please select Customer Type");
            }


            else if (CustomerID == "")
            {


                MessageBox.Show("Please Enter Customer Number");
            }

            else if (CurrencyCode == "")
            {


                MessageBox.Show("Please select Currency");
            }



            else if (OrderType == "FPP Order")
            {
                MoetWait.Show();
                MoetSearch.Enabled = false;
              
                SqlConnection Conn = new SqlConnection(ConnectionString);
                CountryCode = GetCountryCode(CountryName);

                SqlCommand cmd = new SqlCommand("select top 10 * from Customer", Conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                Conn.Open();

                adapter.Fill(dt);
                MoetWait.Hide();
                Conn.Close();
                MoetResult.Show();
                MoetResult.DataSource = dt;
                MoetSearch.Enabled = true;

            }


            else if (OrderType == "Open Business Order")
            {
                string Status = GetStatus(StatusCode);

                if (Status == "ACT")
                {

                    MoetWait.Show();
                    MoetSearch.Enabled = false;                    
                    CountryCode = GetCountryCode(CountryName);
                    SqlConnection Conn = new SqlConnection(ConnectionString);

                    SqlCommand cmd = new SqlCommand(String.Format(@"select C.CustomerNumber,OP.Partnumber,C.CurrencyCode,SL.SalesLocationName,OP.PriceLocal, * from OpenVItemPriceList OP
                                                join customer C on C.CustomerID = OP.CustomerID
                                                join saleslocation SL on SL.SalesLocationCode = C.SalesLocationCode
                                                where CustomerStatusCode = 'ACT' 
                                                and SL.SalesLocationCode = '{0}' 
                                                and C.CurrencyCode = '{1}' 
                                                and CustomerNumber = '{2}'
                                                and CustomerTypeCode = '{3}'", CountryCode, CurrencyCode, CustomerID, CustomerType), Conn);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    Conn.Open();

                    adapter.Fill(dt);
                    MoetWait.Hide();
                    Conn.Close();
                    MoetResult.Show();
                    MoetResult.DataSource = dt;
                    MoetSearch.Enabled = true;
                }

                else
                {
                    MessageBox.Show("Customer Number is Invalid or not active");

                }


            }


            else if (OrderType == "Open Business +500 Order")
            {
                MoetWait.Show();
                MoetSearch.Enabled = false; 
                SqlConnection Conn = new SqlConnection(ConnectionString);
                CountryCode = GetCountryCode(CountryName);
                SqlCommand cmd = new SqlCommand(String.Format(@"select C.CustomerNumber,P.Partnumber,C.CurrencyCode,SL.SalesLocationName,P.PriceLocal, * from MOLPItemPriceList P
                                                    join customer C on C.CustomerID = P.CustomerID
                                                    join saleslocation SL on SL.SalesLocationCode = C.SalesLocationCode
                                                    where CustomerStatusCode = 'ACT'
                                                    and SL.SalesLocationCode = '{0}' 
                                                    and C.CurrencyCode = '{1}' 
                                                    and CustomerNumber = '{2}'
                                                    and CustomerTypeCode = '{3}'", CountryCode, CurrencyCode, CustomerID, CustomerType), Conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                Conn.Open();

                adapter.Fill(dt);
                MoetWait.Hide();
                Conn.Close();
                MoetResult.Show();
                MoetResult.DataSource = dt;
                MoetSearch.Enabled = true;

            }


        }

        private string GetStatus(string StatusCode)
        {
            SqlConnection Conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(String.Format(@"select CustomerStatusCode  from customer where CustomerNumber ='" + CustomerID + "'"), Conn);



            Conn.Open();



            object cusstate = cmd.ExecuteScalar(); ;


            Conn.Close();

            if(cusstate !=null)
            {
                return cusstate.ToString();
            }

            else
            {
                return null;
            }
        }

        private string GetCountryCode(string CountryName)
        {
            SqlConnection Conn = new SqlConnection(ConnectionString);

            SqlCommand cmd = new SqlCommand("select SalesLocationCode from saleslocation where Saleslocationname ='" + CountryName + "'", Conn);



            Conn.Open();



            String saleslocation = cmd.ExecuteScalar().ToString();

            Conn.Close();

            return saleslocation;

        }

        private void LoadCountryDropdown()
        {
            using(SqlConnection Conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT CountryName From Country", Conn);
                
                Conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Country.Items.Add(reader[0]);
                }

                Conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home MO = new Home();
            MO.Show();
        }
    }
}
