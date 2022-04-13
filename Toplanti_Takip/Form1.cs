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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool isValid()
        {
            if (txtKullanici_Adi.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Lütfen Kullanıcı Adınızı Giriniz!", "Hata!");
                return false;

            }
            else if (txtSifre.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Lütfen Şirenizi Giriniz!", "Hata!");
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullanici_Adi.Text == "")
            {
                MessageBox.Show("Kullanıcı Adını Giriniz");
            }
            else if (txtSifre.Text == "")
            {
                MessageBox.Show("Şifrenizi Giriniz");

            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=CRUD_SP_DB;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Select * from Login_Tab Where Kullanici_Adi = @Kullanici_Adi and Sifre = @Sifre", con);
                    cmd.Parameters.AddWithValue("@Kullanici_Adi", txtKullanici_Adi.Text);
                    cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adınız Veya Şifreniz Yanlış!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
        }

        private void btnUygulamayiKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
