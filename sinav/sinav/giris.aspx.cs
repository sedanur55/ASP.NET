using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.Net;
using HtmlAgilityPack;
using System.Text;

namespace sinav
{
    public partial class giris : Page
    {
        public String html;
        public Uri url;
        public string[] array = new string[10];
       



        protected void Page_Load(object sender, EventArgs e)
        {

            baslik.Items.Clear();
                verial();
            
                 
        }
        public void verial()
        {
             
            Uri url = new Uri("https://www.ensonhaber.com/");
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);


            HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes("//span[@class='ti']");
            
            int i = 0;
            string link;
            foreach (var title in titles)
            {


                if (i != 5)
                {

                    baslik.Items.Add(title.InnerText);
                    i++;

                }

            }

            i = 0;
           
           
            foreach (var nd in dokuman.DocumentNode.SelectNodes("//li"))
            {
                foreach (var fixture in nd.SelectNodes("//a[@class='link']"))
                {
                    
                        if (i != 5)
                        {
                            link = fixture.Attributes["href"].Value.ToString();
                            string link1 = link.ToString();
                            array[i] = "https://www.ensonhaber.com"+link1;
                            //baslik.Items.Add(array[i].ToString());

                            i++;
                        }

                    




                    



                }


            }

               

           


        }

        protected void baslik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (baslik.SelectedIndex.ToString() == "0")
            {

                Uri url1 = new Uri(array[0].ToString());
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string html = client.DownloadString(url1);
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);


                HtmlNodeCollection des = dokuman.DocumentNode.SelectNodes("//article");
                foreach (var titl in des)
                {
                    TextBox17.Text = (titl.InnerText).ToString();
                    
                }
                   
                
            }
            else if (baslik.SelectedIndex.ToString() == "1")
            {

                Uri url1 = new Uri(array[1].ToString());
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string html = client.DownloadString(url1);
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);


                HtmlNodeCollection des = dokuman.DocumentNode.SelectNodes("//article");
                foreach (var titl in des)
                {
                    TextBox17.Text = (titl.InnerText).ToString();

                }

            }
            else if (baslik.SelectedIndex.ToString() == "2")
            {
                Uri url1 = new Uri(array[2].ToString());
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string html = client.DownloadString(url1);
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);


                HtmlNodeCollection des = dokuman.DocumentNode.SelectNodes("//article");
                foreach (var titl in des)
                {
                    TextBox17.Text = (titl.InnerText).ToString();

                }
  
            }
            else if (baslik.SelectedIndex.ToString() == "3")
            {
                Uri url1 = new Uri(array[3].ToString());
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string html = client.DownloadString(url1);
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);


                HtmlNodeCollection des = dokuman.DocumentNode.SelectNodes("//article");
                foreach (var titl in des)
                {
                    TextBox17.Text = (titl.InnerText).ToString();

                }

            }
            else
            {
                Uri url1 = new Uri(array[4].ToString());
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string html = client.DownloadString(url1);
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);


                HtmlNodeCollection des = dokuman.DocumentNode.SelectNodes("//article");
                foreach (var titl in des)
                {
                    TextBox17.Text = (titl.InnerText).ToString();

                }

            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=SEDA\SQLEXPRESS; Initial Catalog=kullanicilar; Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO sinav (baslik, aciklama, soru1, sa, sb, sc, sd, soru2, s2a, s2b, s2c, s2d, soru3, s3a, s3b, s3c, s3d, soru4, s4a, s4b, 4c, s4d, s1cevap, s2cevap, s3cevap, s4cevap)  VALUES('" + baslik.SelectedValue + "','" + TextBox17.Text + "','" + TextBox18.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox19.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox20.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "','" + TextBox21.Text + "','" + TextBox13.Text + "','" + TextBox14.Text + "','" + TextBox15.Text + "','" + TextBox16.Text + "','" + DropDownList4.SelectedValue + "','" + DropDownList3.SelectedValue + "','" + DropDownList2.SelectedValue + "','" + DropDownList1.SelectedValue + "')", connection);
            /*
            SqlCommand cmd = new SqlCommand("INSERT INTO sinavsoru (baslik, aciklama, soru1,sa,sb,sc,sd,soru2,s2a,s2b,s2c,s2d,soru3,s3a,s3b,s3c,s3d,soru4,s4a,s4b,s4c,s4d,s1cevap,s2cevap,s3cevap,s4cevap) VALUES(@baslik, @aciklama, @soru1,@sa,@sb,@sc,@sd,@soru2,@s2a,@s2b,@s2c,@s2d,@soru3,@s3a,@s3b,@s3c,@s3d,@soru4,@s4a,@s4b,@s4c,@s4d,@s1cevap,@s2cevap,@s3cevap,@s4cevap)", connection);
            cmd.Parameters.AddWithValue("@baslik", baslik.SelectedValue);
            cmd.Parameters.AddWithValue("@aciklama", TextBox17.Text);
            cmd.Parameters.AddWithValue("@soru1", TextBox17.Text);
            cmd.Parameters.AddWithValue("@sa", TextBox1.Text);
            cmd.Parameters.AddWithValue("@sb", TextBox2.Text);
            cmd.Parameters.AddWithValue("@sc", TextBox3.Text);
            cmd.Parameters.AddWithValue("@sd", TextBox4.Text);
            cmd.Parameters.AddWithValue("@soru2", TextBox19.Text);
            cmd.Parameters.AddWithValue("@s2a", TextBox5.Text);
            cmd.Parameters.AddWithValue("@s2b", TextBox6.Text);
            cmd.Parameters.AddWithValue("@s2c", TextBox7.Text);
            cmd.Parameters.AddWithValue("@s2d", TextBox8.Text);
            cmd.Parameters.AddWithValue("@soru3", TextBox20.Text);
            cmd.Parameters.AddWithValue("@s3a", TextBox9.Text);
            cmd.Parameters.AddWithValue("@s3b", TextBox10.Text);
            cmd.Parameters.AddWithValue("@s3c", TextBox11.Text);
            cmd.Parameters.AddWithValue("@s3d", TextBox12.Text);
            cmd.Parameters.AddWithValue("@soru4", TextBox21.Text);
            cmd.Parameters.AddWithValue("@s4a", TextBox13.Text);
            cmd.Parameters.AddWithValue("@s4b", TextBox14.Text);
            cmd.Parameters.AddWithValue("@s4c", TextBox15.Text);
            cmd.Parameters.AddWithValue("@s4d", TextBox16.Text);
            cmd.Parameters.AddWithValue("@s1cevap", DropDownList4.SelectedValue);
            cmd.Parameters.AddWithValue("@s2cevap", DropDownList3.SelectedValue);
            cmd.Parameters.AddWithValue("@s3cevap", DropDownList2.SelectedValue);
            cmd.Parameters.AddWithValue("@s4cevap", DropDownList1.SelectedValue);




            SqlCommand cmd = new SqlCommand("INSERT INTO sinavsoru (baslik, aciklama, soru1,sa,sb,sc,sd,soru2,s2a,s2b,s2c,s2d,soru3,s3a,s3b,s3c,s3d,soru4,s4a,s4b,s4c,s4d,s1cevap,s2cevap,s3cevap,s4cevap) values ( '" + baslik.SelectedValue + "','" + TextBox17.Text + "','" + TextBox18.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox19.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox20.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "','" + TextBox21.Text + "','" + TextBox13.Text + "','" + TextBox14.Text + "','" + TextBox15.Text + "','" + TextBox16.Text + "','" + DropDownList4.SelectedValue + "','" + DropDownList3.SelectedValue + "','" + DropDownList2.SelectedValue + "','" + DropDownList1.SelectedValue + "')", connection);
            */
            cmd.ExecuteNonQuery();
            connection.Close();


        }
        

    }
}
