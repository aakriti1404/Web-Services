using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            CalculatorService.CalculatorWebServiceSoapClient client = 
                new CalculatorService.CalculatorWebServiceSoapClient("CalculatorWebServiceSoap");
            int result = client.Add(Convert.ToInt32(txtFirstNumber.Text),
                                    Convert.ToInt32(txtFirstNumber.Text));
            lblResult.Text = result.ToString();
            //System.Console.WriteLine("Hello");
        }
    }
}