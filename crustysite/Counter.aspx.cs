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
            // When you click add it will send back 0 every time
            // Maintain a state (ViewState)
            // CounterOP.Text = Convert.ToString(0);

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
            /* 
             * This doesn't increase beyond 1 because the form uses postback
             * We need to capture the state between postbacks (using ViewState)
             */
            /* int value = Convert.ToInt32(CounterOP.Text);

            CounterOP.Text = Convert.ToString(++value);
            */

            // Implement the viewstate logic to explicitly store the count value instead
            int count = (int)ViewState["count"];

            ViewState["count"] = ++count;
            CounterOP.Text = count.ToString();
        }
    }
}