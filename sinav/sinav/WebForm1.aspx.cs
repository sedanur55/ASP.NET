using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sinav
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(@"Data Source=SEDA\SQLEXPRESS; Initial Catalog=kullanicilar; Integrated Security=True");
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("insert into tab1(Ad,Password) values ( '" + txtAd.Text + "'," + txtPas.Text + ")", connection);
            //cmd.ExecuteNonQuery();
            SqlConnection connection = new SqlConnection(@"Data Source=SEDA\SQLEXPRESS; Initial Catalog=kullanicilar; Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from tab1 Where Ad='" + txtAd.Text + "'and Password='" + txtPas.Text + "'", connection);
            SqlDataReader dr=cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["Ad"] = dr["Ad"].ToString();
                Response.Redirect("giris.aspx");
            }
            else
            {
                Response.Write("hatalı giriş yaptınız");
            }
        }
    }
}