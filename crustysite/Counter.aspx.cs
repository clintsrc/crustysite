using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            /* 
             * This runs when the page first loads, not 
             * subsequent postbacks (like button clicks)
             */

            if (!IsPostBack) { 
                ViewState["count"] = 0;
                CounterOP.Text = "0";
            }
            
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            // Implement the viewstate logic to explicitly store the count value instead
            int count = (int)ViewState["count"];

            ViewState["count"] = ++count;
            CounterOP.Text = count.ToString();
        }
    }
}