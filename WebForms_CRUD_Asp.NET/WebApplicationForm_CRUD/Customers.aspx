<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="WebApplicationForm_CRUD.Customers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customers</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <asp:Image ID="Image1" runat="server" />

            <h1>Grocery Store Customers</h1>
            <br />
            <a class="btn btn-primary" href="AddCustomer.aspx">Add New Customer</a>
            <br />
            <br />
            <div class="table-responsive">
                <table class="table table-bordered">
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Surname</th>
                        <th>Phone</th>
                        <th>Address</th>
                        <th>Edit</th>
                    </tr>

                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("CustomerID") %></td>
                                <td><%#Eval("CustomerName") %></td>
                                <td><%#Eval("CustomerSurname") %></td>
                                <td><%#Eval("PhoneNumber") %></td>
                                <td><%#Eval("Address") %></td>
                                <td>
                                    <a class="btn btn-warning" href="UpdateCustomer.aspx?ID=<%#Eval("CustomerID") %>">Update</a>
                                    <a class="btn btn-danger" href="Customers.aspx?ID=<%#Eval("CustomerID") %>">Delete</a>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>

                </table>
            </div>

        </div>
    </form>
</body>
</html>
