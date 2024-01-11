using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace WebApplication1
{
    public partial class randevuekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Server=DESKTOP-P42KD85; Database=randevuDB; User Id=sa; Password=123; TrustServerCertificate=True; Persist Security Info=True");
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into randevu(hastatc, hastaad, hastasoyad, il, ilce, klinik, hastane, tarih) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
            komut.Parameters.AddWithValue("@p1", TextBox1.Text);
            komut.Parameters.AddWithValue("@p2", TextBox2.Text);
            komut.Parameters.AddWithValue("@p3", TextBox3.Text);
            komut.Parameters.AddWithValue("@p4", TextBox4.Text);
            komut.Parameters.AddWithValue("@p5", TextBox5.Text);
            komut.Parameters.AddWithValue("@p6", TextBox6.Text);
            komut.Parameters.AddWithValue("@p7", TextBox7.Text);
            komut.Parameters.AddWithValue("@p8", TextBox8.Text);

            

            try 
            { 
                komut.ExecuteNonQuery();
                Label1.Text = "Kayıt yapıldı.";
                Label1.ForeColor = System.Drawing.Color.Green;
            } 
            catch (Exception)
            {
                Label1.Text = "Hata Oluştu!";
                Label1.ForeColor = System.Drawing.Color.Red;
             
                
            }

            baglanti.Close();

        }
    }
}