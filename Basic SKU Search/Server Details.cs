using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_SKU_Search
{
    public partial class MSL_Server_Details : Form
    {
        public MSL_Server_Details()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            
            string MSLServ = MSLServer.Text;
            string ServName = MSLName.Text;

            if (MSLServ == "")
            {

                MessageBox.Show("Please Enter Server URL");

            }

            else if (ServName == "")

                MessageBox.Show("Please Enter Server Name");

            else {

                this.Close();
                ServerDetails.SetServerURL(MSLServ);
                ServerDetails.SetServerName(ServName);
                if (Track.GetFormName() == "eMSL")
                {
                    
                    eMSL Or1 = new eMSL();
                    
                    Or1.Show();
                }
                else if (Track.GetFormName() == "Form2")
                {
                    Form2 f2 = new Form2();
                   
                    f2.Show();
                }

                else if (Track.GetFormName() == "MOET_Sku_Search")
                {
                    MOET_Sku_Search f2 = new MOET_Sku_Search();
                   
                    f2.Show();
                }

                else if (Track.GetFormName() == "Open_Business_Customer_Search")
                {
                    Open_Business_Customer_Search f2 = new Open_Business_Customer_Search();
                    
                    f2.Show();
                }

                else if (Track.GetFormName() == "MSL_Agreement_Search")
                {
                    MSL_Agreement_Search f2 = new MSL_Agreement_Search();
                   
                    f2.Show();
                }

               

               
                       


            
            }
        }
    }
}
