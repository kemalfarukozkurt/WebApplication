using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.WebSockets;

namespace WebApplication1
{
    public partial class randevular : System.Web.UI.Page
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
    }
}