<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="WebApplicationForm_Library.UserList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LIBRARY</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />

    <style type="text/css">
        body {
            font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">


            <h1>LIST OF USERS</h1>
            <br />


            <div class="table-responsive">

                <table class="table table-bordered">
                    <tr>
                        <th>ID</th>
                        <th>User Name</th>
                        <th>Address</th>
                        <th>Phone</th>                        
                    </tr>

                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("UserID") %></td>
                                <td><%#Eval("UserName") %></td>
                                <td><%#Eval("Address") %></td>
                                <td><%#Eval("PhoneNumber") %></td>                              
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
                <br />
                <a class="btn btn-primary" href="BookList.aspx">Back to Book List</a>
            </div>
        </div>
    </form>
</body>
</html>
