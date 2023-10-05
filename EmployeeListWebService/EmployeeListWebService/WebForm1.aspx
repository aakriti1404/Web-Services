<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EmployeeListWebService.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee List</title>
</head>
<body>
    <form id="form1" runat="server">
        <center><h2>Employee List</h2></center>
        <div>
            <table style="font-family:Arial">
               <tr>
                   <td>
                       <b>Enter Employee Name</b>
                   </td>
                   <td>
                       <asp:TextBox ID="txtEmployeeName" runat="server"></asp:TextBox>
                   </td>
                   <td>
                       <asp:Button ID="btnAdd" runat="server" Text="AddEmployeeName" OnClick="btnAdd_Click1" />
                   </td>
               </tr>
               <tr>
                   <td>
                       <b>Result</b>
                   </td>
                   <td>
                        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                   </td>
               </tr>
             </table>
        </div>
        <hr />
        <div>
            <h3>List of Employee</h3>
            <asp:ListBox ID="lstEmployees" runat="server" SelectionMode="Single" Height="150px" Width="200px"></asp:ListBox>
        </div>

        <hr />

        <div>
            <label for="txtUpdateIndex">Index to Update:</label>
            <asp:TextBox ID="txtUpdateIndex" runat="server"></asp:TextBox>
            <label for="txtUpdatedName">Updated Name:</label>
            <asp:TextBox ID="txtUpdatedName" runat="server"></asp:TextBox>
            <asp:Button ID="btnUpdateEmployee" runat="server" Text="Update Employee" OnClick="btnUpdateEmployee_Click" />
        </div>

        <hr />

        <div>
            <label for="txtDeleteIndex">Index to Delete:</label>
            <asp:TextBox ID="txtDeleteIndex" runat="server"></asp:TextBox>
            <asp:Button ID="btnDeleteEmployee" runat="server" Text="Delete Employee" OnClick="btnDeleteEmployee_Click" />
        </div>

        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
