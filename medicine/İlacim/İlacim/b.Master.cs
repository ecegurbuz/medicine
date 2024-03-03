using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace İlacim
{
    public partial class b : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[0].ConnectionString);

            string sorgu = "Select * from İlaçBilgileri inner join Alfabe on başHarfID = Alfabe.id where harf = 'B' ";

            SqlCommand cmd = new SqlCommand(sorgu, cnn);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            ilaclar.DataSource = dr;
            ilaclar.DataBind();
            cnn.Close();
        }

        protected void butonArama_Click(object sender, EventArgs e)
        {
            Response.Redirect("arama.aspx?cumle=" + txtArama.Text.Trim());
        }
    }
}