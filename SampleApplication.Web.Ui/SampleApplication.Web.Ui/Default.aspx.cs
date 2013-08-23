using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleApplication.Web.Ui
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CountyUpdateButton_Click(object sender, EventArgs e)
        {
            CountyLabel.Text = "Dublin";
            CountyLabel.ForeColor = Color.Blue;
        }
    }
}