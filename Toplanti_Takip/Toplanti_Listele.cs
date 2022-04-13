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

namespace Toplanti_Takip
{
    public partial class Toplanti_Listele : Form
    {
        
        public Toplanti_Listele()
        {
            InitializeComponent();
        }

        private void Toplanti_Listele_Load(object sender, EventArgs e)
        {
      
        }      
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Veritabani.getConn();
            SqlCommand command = null;
            string sql = "SELECT *  FROM Newstaff WHERE SID = " + txtAra.Text;
            SqlDataReader dataReader = null;
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    textBoxSearch.Text = dataReader.GetInt32(0).ToString();
                    textBoxFname.Text = (string)dataReader["Fname"];
                    textBoxLName.Text = (string)dataReader["lname"];
                    textBoxMobile.Text = dataReader.GetInt64(5).ToString();
                    if ((string)dataReader["gender"] == "Male")
                    {
                        radioButtonMale.Checked = true;
                    }
                    else if ((string)dataReader["gender"] == "Female")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    dateTimePickerDateOfBirth.Text = (string)dataReader["dob"];
                    dateTimePickerDateJoined.Text = (string)dataReader["joindate"];
                    textBoxMail.Text = (string)dataReader["email"];
                    textBoxCity.Text = (string)dataReader["city"];
                    textBoxSalary.Text = dataReader.GetDecimal(9).ToString();
                    textBoxPost.Text = (string)dataReader["post"];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
            finally
            {
                dataReader.Close();
                command.Dispose();

                if (connection.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Closing Connection = After Select ");
                    connection.Close();
                }
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
