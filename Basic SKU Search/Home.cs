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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random("eMSL");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random("Form2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random("MOET_Sku_Search");
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random("MSL_Agreement_Search");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random("Open_Business_Customer_Search");
        }

        private void Random(string name)
        {
            Track.SetFormName(name);
            MSL_Server_Details DbMSL = new MSL_Server_Details();
            DbMSL.Show();
        }
    }
}
