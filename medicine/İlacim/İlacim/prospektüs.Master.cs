using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace İlacim
{
    public partial class prospektüs : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NewMethod1();
            string ilaçAdı = Request.QueryString["ilaçAdı"];
            
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[0].ConnectionString);

            string sorgu = "Select * from İlaçBilgileri inner join NasılKullanılır on ilaçID = id inner join YanEtkiler on YanEtkiler.ilaçID = id where ilaçAdı like '%" + ilaçAdı + "%'";

            SqlCommand cmd = new SqlCommand(sorgu, cnn);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            

            ilaclar.DataSource = dr;
            ilaclar.DataBind();

            cnn.Close();
        }

        private void NewMethod1()
        {
            string ilaçAdı = Request.QueryString["ilaçAdı"];

            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[0].ConnectionString);

            string sorgu = "Select * from İlaçBilgileri inner join Firmalar on firmaID = Firmalar.id  where ilaçAdı like '%" + ilaçAdı + "%' ";

            SqlCommand cmd = new SqlCommand(sorgu, cnn);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            sol.DataSource = dr;
            sol.DataBind();
            cnn.Close();
        }

        protected void butonArama_Click(object sender, EventArgs e)
        {
            Response.Redirect("arama.aspx?cumle=" + txtArama.Text.Trim());
        }
    }
}