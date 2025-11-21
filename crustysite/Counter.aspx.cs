using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crustysite
{
    public partial class Counter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CounterOP.Text = Convert.ToString(0);
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            // this won't increase beyond 1 because the form uses postback
            int value = Convert.ToInt32(CounterOP.Text);

            CounterOP.Text = Convert.ToString(++value);
        }
    }
}