using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWebService1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            CalculatorService client = new CalculatorService();
            int result = client.Add(Convert.ToInt32(txtFirstNumber.Text),
                                    Convert.ToInt32(txtSecondNumber.Text));
            lblResult.Text = result.ToString();
        }
    }
}