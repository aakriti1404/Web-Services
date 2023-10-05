using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeListWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {
                    // Load the list of employees when the page first loads
                    RefreshEmployeeList();
                }
            }
        }

        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            string employeeName = txtEmployeeName.Text;
            EmployeeList list = new EmployeeList();
            string result = list.AddEmployee(employeeName);
            lblResult.Text = result;
            RefreshEmployeeList();
        }
    }
}