using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EmployeeListWebService
{
    /// <summary>
    /// Summary description for EmployeeList
    /// </summary>
    [WebService(Namespace = "http://maersk.com/webservice")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EmployeeList : System.Web.Services.WebService
    {
        public static ArrayList employeeList = new ArrayList();
        [WebMethod]
        public string AddEmployee(string employeeName)
        {
            if (!string.IsNullOrEmpty(employeeName))
            {
                employeeList.Add(employeeName);
                return "Employee added successfully!";
            }
            else
            {
                return "Employee name cannot be empty.";
            }
        }

        [WebMethod]
        public string[] GetEmployees()
        {
            return (string[])employeeList.ToArray(typeof(string));
        }

        [WebMethod]
        public string UpdateEmployee(int index, string updatedName)
        {
            if (index >= 0 && index < employeeList.Count)
            {
                if (!string.IsNullOrEmpty(updatedName))
                {
                    employeeList[index] = updatedName;
                    return "Employee updated successfully!";
                }
                else
                {
                    return "Updated employee name cannot be empty.";
                }
            }
            else
            {
                return "Employee not found at the specified index.";
            }
        }

        [WebMethod]
        public string DeleteEmployee(int index)
        {
            if (index >= 0 && index < employeeList.Count)
            {
                employeeList.RemoveAt(index);
                return "Employee removed successfully!";
            }
            else
            {
                return "Employee not found at the specified index.";
            }
        }
    }
}
