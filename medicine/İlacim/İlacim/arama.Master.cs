using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace İlacim
{
    public partial class arama : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cumle = Request.QueryString["cumle"].ToString();
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[0].ConnectionString);
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from İlaçBilgileri where ilaçAdı like '%" + cumle + "%' or kategori like '%" + cumle + "%'", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();

        }

        protected void butonArama_Click(object sender, EventArgs e)
        {
            Response.Redirect("arama.aspx?cumle=" + txtArama.Text.Trim());
        }
    }
}