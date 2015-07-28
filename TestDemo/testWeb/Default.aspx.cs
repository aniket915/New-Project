using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace testWeb
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string message = "Order Placed Successfully.";

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("<script type = 'text/javascript'>");

            string ab="testConnection";
         // sb=ab;
            sb = null;
            Response.Write(ab);
            Response.Write(sb);


            sb.Append("window.onload=function(){");

            sb.Append("alert('");

            sb.Append(message);

            sb.Append("')};");

            sb.Append("</script>");

            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }
        public void Add()
        {
            int a, b;
            a = 3;
            b = 3;
            a = a + b;
            Response.Write("float");
        }

        public void add(double a, double b)
        {
            a= a + b;
        }

        public void sub(double a, double b)
        {
            double c = a - b;
        }
               
     public void sub( string a, double b)

        {
            string c = a + b;
        }
    }
}
