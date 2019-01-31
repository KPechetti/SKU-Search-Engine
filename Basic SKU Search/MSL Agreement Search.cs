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
    public partial class MSL_Agreement_Search : Form
    {

        string CountryName = "";
        string ProgramName = "";
        string CustomerTypeCode = "";
        string AgmType = "";
        string Agmcontract = "";
        string Status = "";

        private string ConnectionString ;
        
        public MSL_Agreement_Search()
        {
            InitializeComponent();
            AgmResult.Hide();
            AgmWait.Hide();
            SetConnectionString();
        }
        private void SetConnectionString()
        {
            ConnectionString = "Data Source=" + ServerDetails.GetServerURL() + ";Initial Catalog=" + ServerDetails.GetServerName() + "; Integrated Security=SSPI";
        }

        private void AgmSearch_Click(object sender, EventArgs e)
        {

            CountryName = Country.Text;
            ProgramName = Program.Text;
            CustomerTypeCode = CustomerType.Text;
            AgmType = AgreementType.Text;
            Agmcontract = ContractType.Text;
            Status = AgmStatus.Text;


            if (CountryName == "")
            {
                MessageBox.Show("Please Select Country");

            }

            else if (ProgramName == "")
            {
                MessageBox.Show("Please Select Program Name");
            }

            else if (CustomerTypeCode == "")
            {
                MessageBox.Show("Please Select Customer Type");
            }

            else if (AgmType == "")
            {
                MessageBox.Show("Please Select Agreement Type");
            }

            else if (Agmcontract == "")
            {
                MessageBox.Show("Please Select Agreement Contract");
            }

            else if (Status == "")
            {
                MessageBox.Show("Please Select Agreement Status");
            }



            else
            {

                AgmWait.Show();
                AgmSearch.Enabled = false;
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {


                    string countryCode = GetCountryCode(CountryName);
                    string programCode = GetProgramCode(ProgramName);
                    string customerType = GetCustomerTypeCode(CustomerTypeCode);
                    string AType = GetAgmType(AgmType);
                    string AContract = GetAgmContract(Agmcontract);
                    string AStatus = GetAgmStatus(Status);

                    AgmResult.Show();

                    SqlCommand cmd = new SqlCommand(String.Format(@"select  A.Agreementnumber,A.Programcode,AP.CustomerTypeCode,A.StartEffectiveDate, A.ContractTypeCode,A.LicenseAgreementTypeCode, * from Agreement A
                                                            join AgreementParticipant AP on A.AgreementID = AP.AgreementID
                                                            where SalesLocationCode = '{0}'
                                                            and  Programcode = '{1}'
                                                            and AgreementTypeCode = '{2}'
                                                            and CustomerTypeCode ='{3}'
                                                            and AgreementStatusCode = '{4}'
                                                            and ContractTypeCode='{5}'
                                                            order by A.StartEffectiveDate desc", countryCode, programCode, AType, customerType, AStatus, AContract), conn);


                    conn.Open();

                    DataTable dt = new DataTable();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    AgmWait.Hide();
                    AgmResult.DataSource = dt;
                    AgmResult.Show();
                    AgmSearch.Enabled = true;

                }


            }
        }

        private string GetCountryCode(string countryName)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select SalesLocationcode from Saleslocation WHERE Saleslocationname = '" + CountryName + "'", conn);

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


        private string GetCustomerTypeCode(string CustomerTypeCode)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select CustomerTypeCode from CustomerType where CustomerTypeName ='" + CustomerTypeCode + "'", conn);

                conn.Open();

                string customerType = cmd.ExecuteScalar().ToString();
                //customerType = customerType.Trim();

                return customerType;
            }
        }


        private string GetAgmType(string AgmType)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select AgreementTypeCode  from AgreementType where AgreementTypeName = '" + AgmType + "'", conn);

                conn.Open();

                string AType = cmd.ExecuteScalar().ToString();
                //customerType = customerType.Trim();

                return AType;
            }
        }


        private string GetAgmContract(string Agmcontract)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select ContractTypeCode  from contracttype where ContractTypeName = '" + Agmcontract + "'", conn);

                conn.Open();

                string AContract = cmd.ExecuteScalar().ToString();
               

                return AContract;
            }
        }


        private string GetAgmStatus(string Status)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select AgreementStatusCode  from AgreementStatus where AgreementStatusName = '" + Status + "'", conn);

                conn.Open();

                string AStatus = cmd.ExecuteScalar().ToString();


                return AStatus;
            }
        }

        private void MSL_Agreement_Search_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home Agm = new Home();

            Agm.Show();
        }


    
    }
}
