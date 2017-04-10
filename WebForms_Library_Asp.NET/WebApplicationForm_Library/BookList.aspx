<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookList.aspx.cs" Inherits="WebApplicationForm_Library.BookList" %>

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


            <h1>LIST OF BOOKS</h1>
            <br />
            <a class="btn btn-primary" href="AddNewBook.aspx">Add New Book</a>
            <a class="btn btn-success" href="UserList.aspx">List of Users</a>
            <br />
            <br />

            <div class="table-responsive">

                <table class="table table-bordered">
                    <tr>
                        <th>ID</th>
                        <th>Book Name</th>
                        <th>Writer Name</th>
                        <th>Rental State</th>
                        <th>Edit</th>
                    </tr>

                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("BookID") %></td>
                                <td><%#Eval("BookName") %></td>
                                <td><%#Eval("WriterName") %></td>
                                <td><%#Eval("RentalState") %></td>
                                <td>
                                    <a href="RentBook.aspx?ID=<%#Eval("BookID") %>" id="rentRef" class="btn btn-info">Rent</a>
                                    <a class="btn btn-warning" href="UpdateBook.aspx?ID=<%#Eval("BookID") %>">Update</a>
                                    <a class="btn btn-danger" href="BookList.aspx?ID=<%#Eval("BookID") %>">Delete</a>
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
