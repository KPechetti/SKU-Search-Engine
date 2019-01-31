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
    public partial class Form2 : Form
    {
        string orderType = "";
        string CountryName = "";
        string ProgramName = "";
        string CustomerTypeCode = "";
        string LicenseAgreementType = "";

        string ConnectionString;

        DataTable dt = new DataTable();
        public Form2()
        {
            InitializeComponent();
            SetConnectionString();
            PoetResult.Hide();
            PoetWait.Hide();

        }


        private void SetConnectionString()
        {
            ConnectionString = "Data Source=" + ServerDetails.GetServerURL() + ";Initial Catalog=" + ServerDetails.GetServerName() + "; Integrated Security=SSPI";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            orderType = PoetOrder.Text;
            CountryName = PoetCountry.Text;
            ProgramName = PoetProgram.Text;
            CustomerTypeCode = PoetCustomerType.Text;
            LicenseAgreementType = PoetLicAgreementType.Text;
            string ProgramOfferings = PoetProgramOfferings.Text;
            string OfferingLevels = PoetOfferingLevel.Text;


            if (orderType == "")
            {
                MessageBox.Show("Please Select Order Type");

            }

            else if (CountryName == "")
            {

                MessageBox.Show("Please Select Country Name");
            }

            else if (ProgramName == "")
            {

                MessageBox.Show("Please Select Program Name");
            }

            else if (CustomerTypeCode == "")
            {

                MessageBox.Show("Please Select Customer Type");
            }

            else if (LicenseAgreementType == "")
            {

                MessageBox.Show("Please Select License Agreement Type");
            }

            else if (ProgramOfferings == "")
            {

                MessageBox.Show("Please Select Program Offerings");
            }

            else if (OfferingLevels == "")
            {

                MessageBox.Show("Please Select Offering Levels");
            }



            else if (orderType == "StepUp Order")
            {
                PoetWait.Show();
                PoetSearch.Enabled = false;
                SqlConnection conn = new SqlConnection(ConnectionString);
                string countryCode = GetCountryCode(CountryName);
                string programCode = GetProgramCode(ProgramName);
                string customerType = GetCustomerType(CustomerTypeCode);
                string LicAgreementType = GetLicenseAgreementType(LicenseAgreementType);

                SqlCommand cmd = new SqlCommand(string.Format(@"Select DISTINCT Top 1500  i.partnumber,* From ChannelNetprice CNP with (nolock)
                                                                INNER JOIN Item I with (Nolock)
                                                                on CNP.itemid=I.itemid
                                                                JOIN vStepUpSKU stp (NOLOCK) ON STP.ItemID=I.ItemID
                                                                Where  CNP.countrycode ='{0}'
												                and CNP.programcode = '{1}'
                                                                and CNP.customerTypecode = '{2}'
                                                                and CNP.LicenseAgreementTypeCode = '{3}'
                                                                and CNP.programofferingcode ='{4}'
                                                                and CNP.OfferingLevelcode ='{5}'
                                                                and CNP.EndEffectiveDate is NULL
												                and (i.ReplacedByPartNumber is null  or i.ReplacedByPartNumber='')", countryCode, programCode, customerType, LicAgreementType, ProgramOfferings, OfferingLevels), conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                conn.Close();
                PoetWait.Hide();
                PoetResult.Show();
                PoetSearch.Enabled = true;
                PoetResult.DataSource = dt;


            }
            else if (orderType == "TrueUp Order")
            {
                PoetWait.Show();
                PoetSearch.Enabled = false;
                SqlConnection conn = new SqlConnection(ConnectionString);
                string countryCode = GetCountryCode(CountryName);
                string programCode = GetProgramCode(ProgramName);
                string customerType = GetCustomerType(CustomerTypeCode);
                string LicAgreementType = GetLicenseAgreementType(LicenseAgreementType);

                SqlCommand cmd = new SqlCommand(string.Format(@"Select DISTINCT Top 1500 partnumber,ApprovedPriceBeforeTax,ProductFamilyNAme, * From ChannelNetprice CNP with (nolock)
                                                INNER JOIN Item I with (Nolock)
                                                on CNP.itemid=I.itemid
                                                Where  CNP.countrycode ='{0}'
												and CNP.programcode = '{1}'
                                                and CNP.customerTypecode = '{2}'
                                                and CNP.LicenseAgreementTypeCode = '{3}'
                                                and CNP.programofferingcode ='{4}'
                                                and CNP.OfferingLevelcode ='{5}'
                                                and CNP.EndEffectiveDate is NULL
												and (i.ReplacedByPartNumber is null  or i.ReplacedByPartNumber='')", countryCode, programCode, customerType, LicAgreementType, ProgramOfferings, OfferingLevels), conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                conn.Close();
                PoetWait.Hide();
                PoetResult.Show();
                PoetResult.DataSource = dt;
                PoetSearch.Enabled = true;
            }

            else if (orderType == "Additional Products")
            {
                PoetWait.Show();
                PoetSearch.Enabled = false;
                SqlConnection conn = new SqlConnection(ConnectionString);
                string countryCode = GetCountryCode(CountryName);
                string programCode = GetProgramCode(ProgramName);
                string customerType = GetCustomerType(CustomerTypeCode);
                string LicAgreementType = GetLicenseAgreementType(LicenseAgreementType);

                string offerings = "ACP";

                SqlCommand cmd = new SqlCommand(String.Format(@"Select DISTINCT Top 1500  partnumber,ApprovedPriceBeforeTax,ProductFamilyNAme, * From ChannelNetprice CNP with (nolock)
                                                INNER JOIN Item I with (Nolock)
                                                on CNP.itemid=I.itemid
                                                Where  CNP.countrycode ='{0}'
												and CNP.programcode = '{1}'
                                                and CNP.customerTypecode = '{2}'
                                                and CNP.LicenseAgreementTypeCode = '{3}'
                                                and CNP.programofferingcode ='{4}'
                                                and CNP.OfferingLevelcode ='{5}'
                                                and CNP.EndEffectiveDate is NULL
												and (i.ReplacedByPartNumber is null  or i.ReplacedByPartNumber='')", countryCode, programCode, customerType, LicAgreementType, offerings, OfferingLevels), conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                conn.Close();
                PoetWait.Hide();
                PoetResult.Show();
                PoetResult.DataSource = dt;
                PoetSearch.Enabled = true;
            }

            else if (orderType == "Reservation Order")
            {
                PoetWait.Show();
                PoetSearch.Enabled = false;
                SqlConnection conn = new SqlConnection(ConnectionString);
                string countryCode = GetCountryCode(CountryName);
                string programCode = GetProgramCode(ProgramName);
                string customerType = GetCustomerType(CustomerTypeCode);
                string LicAgreementType = GetLicenseAgreementType(LicenseAgreementType);

                SqlCommand cmd = new SqlCommand(string.Format(@"Select DISTINCT Top 1500 OLS.partnumber,CNP.ApprovedPriceBeforeTax, *  from  ChannelNetprice CNP 
	                                                            JOIN Item I  on CNP.itemid=I.itemid join OLSItem OLS on OLS.ItemID = CNP.itemid 
                                                                Where  CNP.countrycode ='{0}'
												                and CNP.programcode = '{1}'
                                                                and CNP.customerTypecode = '{2}'
                                                                and CNP.LicenseAgreementTypeCode = '{3}'
                                                                and CNP.programofferingcode ='{4}'
                                                                and CNP.OfferingLevelcode ='{5}'
                                                                and CNP.EndEffectiveDate is NULL
												                and (i.ReplacedByPartNumber is null  or i.ReplacedByPartNumber='')", countryCode, programCode, customerType, LicAgreementType, ProgramOfferings, OfferingLevels), conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                conn.Close();
                PoetWait.Hide();
                PoetResult.Show();
                PoetResult.DataSource = dt;
                PoetSearch.Enabled = true;
            }

            else if (orderType == "Transition Order")
            {
                PoetWait.Show();
                PoetSearch.Enabled = false;
                SqlConnection conn = new SqlConnection(ConnectionString);
                string countryCode = GetCountryCode(CountryName);
                string programCode = GetProgramCode(ProgramName);
                string customerType = GetCustomerType(CustomerTypeCode);
                string LicAgreementType = GetLicenseAgreementType(LicenseAgreementType);

                SqlCommand cmd = new SqlCommand(string.Format(@"select top 5 * from country"), conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                conn.Close();
                PoetWait.Hide();
                PoetResult.Show();
                PoetResult.DataSource = dt;
                PoetSearch.Enabled = true;
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


        private string GetCustomerType(string CustomerTypeCode)
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
        private string GetProgramCode(string ProgramName)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(@"Select Programcode from Program where Programname ='" + ProgramName + "'", conn);
                conn.Open();
                string programCode = cmd.ExecuteScalar().ToString();
                conn.Close();
                return programCode;
            }
        }

        private string GetCountryCode(string CountryName)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(@"select PriceListCountryCode from country WHERE CountryName= '" + CountryName + "'", conn);
                conn.Open();

                string countryCode = cmd.ExecuteScalar().ToString();
                conn.Close();
                return countryCode;
            }
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home PO = new Home();

            PO.Show();
        }

        private void PoetWait_Click(object sender, EventArgs e)
        {

        }
    }
}
