using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

//namespace Toplanti_Takip 
/*{
    internal class classEklemeSilme
    { //ESG=EKLEME SİLME GÜNCELLEME KISALTMASI
        public static bool ESG(string sql, SqlCommand command)
        {//bağlantı kapalıysa bağlantıyı aç açıksa gerek yok
            if (Veritabani.baglanti.State == ConnectionState.Closed)
            {
                Veritabani.baglanti.Open();
            }
            command.Connection =  Veritabani.baglanti; //Komut Bağlantısı
            command.CommandText = sql; //Parametreyi tanımı
            command.ExecuteNonQuery(); //İşlemin Onaylanması

            try // Hata yakalamak için
            {
                return true;
            }
            catch
            {
                return false;
            }
            finally //Bağlantıyı Kapatır.
            {
                Veritabani.baglanti.Close();
            }
        }
        public static DataTable List(string sql) //Bağlantı açıp kapatmaya gerek yok listlemek için gridwiew kullanılıcak.
        {
            DataTable tbl = new DataTable(); //datatable olarak kullandım
            SqlDataAdapter adtr = new SqlDataAdapter(sql, Veritabani.baglanti); //datatableden yeni nesne üretir //Bağlantıyı çağırır.// dönen sonucu tbl olarak ayarlar
            adtr.Fill(tbl); //tabloya kayıtları doldurur.
            return tbl;
        }
    }
}*/
