using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeListWebService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Load the list of employees when the page first loads
                RefreshEmployeeList();
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
        protected void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            int index;
            if (int.TryParse(txtUpdateIndex.Text, out index))
            {
                string updatedName = txtUpdatedName.Text;
                EmployeeList list = new EmployeeList();
                string result = list.UpdateEmployee(index, updatedName);
                lblResult.Text = result;
                RefreshEmployeeList();
            }
            else
            {
                lblResult.Text = "Invalid index. Please enter a valid index.";
            }
        }
        protected void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            int index;
            if (int.TryParse(txtDeleteIndex.Text, out index))
            {
                EmployeeList list = new EmployeeList();
                string result = list.DeleteEmployee(index);
                lblResult.Text = result;
                RefreshEmployeeList();
            }
            else
            {
                lblResult.Text = "Invalid index. Please enter a valid index.";
            }
        }
        private void RefreshEmployeeList()
        {
            // Call the web service to get the list of employees
            EmployeeList service = new EmployeeList();
            string[] employees = service.GetEmployees();

            // Clear existing items in the ListBox
            lstEmployees.Items.Clear();

            // Add each employee to the ListBox
            foreach (string employee in employees)
            {
                lstEmployees.Items.Add(new ListItem(employee));
            }
        }
    }
}