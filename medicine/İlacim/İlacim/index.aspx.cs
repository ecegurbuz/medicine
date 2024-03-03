using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace İlacim
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void butonArama_Click(object sender, EventArgs e)
        {
            Response.Redirect("arama.aspx?cumle=" + txtArama.Text.Trim());
        }
    }
}