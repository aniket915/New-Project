using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testWeb
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void add(float a, float b)
        {
            double c = a + b;
            Response.Write("float");

        }
        public void add(double a, double b)
        {
            double c = a + b;
        }
    }
}