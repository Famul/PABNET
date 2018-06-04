using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Produkty.aspx?catid=" + Server.UrlEncode(DropDownListCategory.Text) + 
                "&cena1=" + TextBox1.Text + "&cena2=" + TextBox2.Text);
        }
    }
}