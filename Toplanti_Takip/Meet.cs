using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Toplanti_Takip
{
    public class Meet
    {
        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        public string Salon { get; set; }
        public string ToplantiID { get; set; }
        public string Toplanti_Tarihi { get; set; }
        public string Toplanti_Adi { get; set; }
        public string Toplanti_Baslangic_Saati { get; set; }
        public string Toplanti_Bitis_Saati { get; set; }
        public string Konu { get; set; }
        public string Konuklar { get; set; }

        private const string SelectQuery = "Select * from Meeting";
        private const string InsertQuery = "Insert Into Meeting (Salon,ToplantiID,Toplanti_Tarihi,Toplanti_Adi,Toplanti_Baslangic_Saati,Toplanti_Bitis_Saati,Konu,Konuklar)VALUES)";
        private const string UpdateQuery = "Update Meeting set Salon=@Salon, ToplantiID=@ToplantiID, Toplanti_Tarihi=@Toplanti_Tarihi, Toplanti_Adi=@Toplanti_Adi, Toplanti_Baslangic_Saati=@Toplanti_Baslangic_Saati,Toplanti_Bitis_Saati=@Toplanti_Bitis_Saati, Konu=@Konu, Konuklar=@Konuklar where ToplantiID=@ToplantiID";

        public DataTable GetMeeting()
        {
            var datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectQuery, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }
        public bool InsertMeeting(Meet meet)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(InsertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Salon", meet.Salon);
                    cmd.Parameters.AddWithValue("@ToplantiID", meet.ToplantiID);
                    cmd.Parameters.AddWithValue("@Toplanti_Tarihi", meet.Toplanti_Tarihi);
                    cmd.Parameters.AddWithValue("@Toplanti_Adi", meet.Toplanti_Adi);
                    cmd.Parameters.AddWithValue("@Toplanti_Baslangic_Saati", meet.Toplanti_Baslangic_Saati);
                    cmd.Parameters.AddWithValue("@Toplanti_Bitis_Saati", meet.Toplanti_Bitis_Saati);
                    cmd.Parameters.AddWithValue("@Konu", meet.Konu);
                    cmd.Parameters.AddWithValue("@Konuklar", meet.Konuklar);
                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
        public bool UpdatedeMeeting(Meet meet)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("@Salon", meet.Salon);
                    com.Parameters.AddWithValue("@ToplantiID", meet.ToplantiID);
                    com.Parameters.AddWithValue("@Toplanti_Tarihi", meet.Toplanti_Tarihi);
                    com.Parameters.AddWithValue("@Toplanti_Adi", meet.Toplanti_Adi);
                    com.Parameters.AddWithValue("@Toplanti_Baslangic_Saati", meet.Toplanti_Baslangic_Saati);
                    com.Parameters.AddWithValue("@Toplanti_Bitis_Saati", meet.Toplanti_Bitis_Saati);
                    com.Parameters.AddWithValue("@Konu", meet.Konu);
                    com.Parameters.AddWithValue("@Konuklar", meet.Konuklar);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
    }
}
