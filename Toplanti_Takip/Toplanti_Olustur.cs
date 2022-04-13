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
using System.Configuration;

namespace Toplanti_Takip
{
    public partial class Toplanti_Olustur : Form
    {
        SqlConnection connection = new SqlConnection();
        public Toplanti_Olustur()
        {
            InitializeComponent();
        }

        public void Toplanti_Olustur_Load(object sender, EventArgs e)
        {


        }

        private void btn_Toplantiyi_Olustur_Click(object sender, EventArgs e)
        {

        }

        private void btnreload_Click(object sender, EventArgs e)
        {

        }

        private void dgw_Toplantiyi_Olustur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    }  
}

