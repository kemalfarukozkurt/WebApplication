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
    public partial class randevuduzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SqlConnection baglanti = new SqlConnection("Server=DESKTOP-P42KD85; Database=randevuDB; User Id=sa; Password=123; TrustServerCertificate=True");
                baglanti.Open();

                SqlCommand komut = new SqlCommand("select * from randevu", baglanti);
                SqlDataReader okuyucu = komut.ExecuteReader();
                GridView1.DataSource = okuyucu;
                GridView1.DataBind();
                baglanti.Close();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HiddenField1.Value = GridView1.SelectedRow.Cells[1].Text;
            TextBox1.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[2].Text);
            TextBox2.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[3].Text);
            TextBox3.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[4].Text);
            TextBox4.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[5].Text);
            TextBox5.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[6].Text);
            TextBox6.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[7].Text);
            TextBox7.Text = Server.HtmlDecode(GridView1.SelectedRow.Cells[8].Text);



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Server=DESKTOP-P42KD85; Database=randevuDB; User Id=sa; Password=123; TrustServerCertificate=True");
            baglanti.Open();

            SqlCommand komut = new SqlCommand("update randevu set hastaad=@p, hastasoyad=@a, il=@s, ilce=@d, klinik=@f, hastane=@g, tarih=@h where hastatc=@pk" , baglanti);
            komut.Parameters.AddWithValue("@p", TextBox1.Text);
            komut.Parameters.AddWithValue("@a", TextBox2.Text);
            komut.Parameters.AddWithValue("@s", TextBox3.Text);
            komut.Parameters.AddWithValue("@d", TextBox4.Text);
            komut.Parameters.AddWithValue("@f", TextBox5.Text);
            komut.Parameters.AddWithValue("@g", TextBox6.Text);
            komut.Parameters.AddWithValue("@h", TextBox7.Text);
            komut.Parameters.AddWithValue("@pk", HiddenField1.Value);

            try
            {
                komut.ExecuteNonQuery();
                Label1.Text = "Güncelleme Yapıldı.";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception)
            {
                Label1.Text = "Hata, Güncelleme Yapılamadı!";
                Label1.ForeColor = System.Drawing.Color.Red;
               
            }
        }
    }
}