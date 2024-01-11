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
    public partial class randevuiptal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SqlConnection baglanti = new SqlConnection("Server=DESKTOP-P42KD85; Database=randevuDB; User Id=sa; Password=123; TrustServerCertificate=True");
                baglanti.Open();

                SqlCommand komut = new SqlCommand("select * from randevu", baglanti);
                SqlDataReader okuyucu = komut.ExecuteReader();

                ListBox1.DataSource = okuyucu;
                ListBox1.DataTextField = "hastatc";
                ListBox1.DataValueField = "hastatc";
                ListBox1.DataBind();
                baglanti.Close();
            }
        }

      

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                Button1.Enabled = true;
            }
            else
            {
                Button1.Enabled = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Server=DESKTOP-P42KD85; Database=randevuDB; User Id=sa; Password=123; TrustServerCertificate=True");
            baglanti.Open();

            SqlCommand komut = new SqlCommand("delete from randevu where hastatc=@p", baglanti);
            komut.Parameters.AddWithValue("@p", ListBox1.SelectedValue);

            try
            {
                komut.ExecuteNonQuery();
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex);
                Label1.Text = "Kayıt Silindi.";
                Label1.ForeColor=System.Drawing.Color.Green;

            }
            catch (Exception)
            {
                Label1.Text = "Hata. Kayıt Silinemedi!";
                Label1.ForeColor = System.Drawing.Color.Red;
                throw;

            }
        }


    }
}