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


using Microsoft.Office.Interop.Excel;
namespace Basic_SKU_Search
{

    public partial class eMSL : Form
    {


        string CountryName = "";
        string ProgramName = "";
        string CustomerTypeCode = "";
        string LicenseAgreementType = "";

        private string ConnectionString;
        public eMSL()
        {

            InitializeComponent();

            MSLWait.Hide();
            dataGridView1.Hide();
            SetConnectionString();

        }

        private void SetConnectionString()
        {
            ConnectionString = "Data Source=" + ServerDetails.GetServerURL() + ";Initial Catalog=" + ServerDetails.GetServerName() + "; Integrated Security=SSPI";
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            CountryName = Country.Text;
            ProgramName = Program.Text;
            CustomerTypeCode = CustomerType.Text;
            LicenseAgreementType = LicAgreementType.Text;
            string Offerings = ProgramOfferings.Text;
            string OfferingLevels = OfferingLevel.Text;


            if (CountryName == "")
            {

                MessageBox.Show("Please Select Country");
            }

            else if (ProgramName == "")
            {

                MessageBox.Show("Please Select Program");
            }

            else if (CustomerTypeCode == "")
            {

                MessageBox.Show("Please Select Customer Type");
            }

            else if (LicenseAgreementType == "")
            {

                MessageBox.Show("Please Select LicenseAgreementType");
            }

            else if (Offerings == "")
            {

                MessageBox.Show("Please Select Program Offerings");
            }

            else if (OfferingLevels == "")
            {

                MessageBox.Show("Please Select Offering Levels");
            }


            else
            {
                MSLWait.Show();

                button1.Enabled = false;

                string countryCode = GetCountryCode(CountryName);

                string programCode = GetProgramCode(ProgramName);
                string customerType = GetCustomerTypeCode(CustomerTypeCode);
                string Lictype = GetLicenseAgreementType(LicenseAgreementType);

                SqlConnection conn = new SqlConnection(ConnectionString);

                SqlCommand cmd = new SqlCommand(String.Format(@"Select DISTINCT Top 1000 partnumber,ApprovedPriceBeforeTax,ProductFamilyNAme, * From ChannelNetprice CNP with (nolock)
                                                INNER JOIN Item I with (Nolock)
                                                on CNP.itemid=I.itemid
                                                Where  CNP.countrycode ='{0}'
												and CNP.programcode = '{1}'
                                                and CNP.customerTypecode = '{2}'
                                                and CNP.LicenseAgreementTypeCode = '{3}'
                                                and CNP.programofferingcode ='{4}'
                                                and CNP.OfferingLevelcode ='{5}'
                                                and CNP.EndEffectiveDate is NULL
												and (i.ReplacedByPartNumber is null  or i.ReplacedByPartNumber='')", countryCode, programCode, customerType, Lictype, Offerings, OfferingLevels), conn);


                conn.Open();




               System.Data.DataTable dt = new System.Data.DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                MSLWait.Hide();
                dataGridView1.Show();
                conn.Close();
                dataGridView1.DataSource = dt;

                button1.Enabled = true;
            }
        }
        private string GetLicenseAgreementType(string LicenseAgreementType)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                SqlCommand cmd = new SqlCommand("select LicenseAgreementTypeCode from LicenseAgreementType where LicenseAgreementTypeName ='" + LicenseAgreementType + "'", conn);
                conn.Open();

                string LicType = cmd.ExecuteScalar().ToString();

                return LicType;
            }
        }

        private string GetCustomerTypeCode(string CustomerTypeCode)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select CustomerTypeCode from CustomerType where CustomerTypeName ='" + CustomerTypeCode + "'", conn);

                conn.Open();

                string customerType = cmd.ExecuteScalar().ToString();
                customerType = customerType.Trim();

                return customerType;
            }
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private string GetCountryCode(string countryName)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select PriceListCountryCode from country WHERE CountryName= '" + CountryName + "'", conn);

                conn.Open();

                string countryCode = cmd.ExecuteScalar().ToString();

                return countryCode;
            }
        }


        private string GetProgramCode(string Program)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                SqlCommand cmd = new SqlCommand("select ProgramCode from Program WHERE ProgramName= '" + ProgramName + "'", conn);

                conn.Open();

                string ProgramCode = cmd.ExecuteScalar().ToString();

                return ProgramCode;


            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook ww = excel.Workbooks.Add(XlSheetType.xlWorksheet);

            Worksheet ws = (Worksheet)excel.ActiveSheet;

            excel.Visible = true;

            ws.Cells[1, 1] = "Kishore";
            ws.Cells[1, 2] = "Kishore";
            ws.Cells[1, 3] = "Kishore";

            for (int i = 1; i <= dataGridView1.Rows.Count; i++ )
            {
                for (int j = 1; j <= dataGridView1.ColumnCount; j++ )
                {

                    ws.Cells[i,j] = dataGridView1.Rows[i-1].Cells[j-1].Value;



                }

            }

        }


    }


}


