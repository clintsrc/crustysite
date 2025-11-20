using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crustysite
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string Name = NameTxt.Text;
            string Email = EmailTxt.Text;

            NameOp.Text = "Name: " + Name;
            EmailOp.Text = "Email: " + Email;
        }
    }
}