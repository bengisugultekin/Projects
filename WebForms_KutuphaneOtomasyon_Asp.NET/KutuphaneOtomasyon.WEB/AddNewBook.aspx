﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNewBook.aspx.cs" Inherits="KutuphaneOtomasyon.WEB.AddNewBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RED LIBRARY</title>

    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

    <style type="text/css">
        body {
            font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>RED LIBRARY</h1>

            <br />
            <div class="dropdown">
                <button class="btn btn-primary dropdown-toggle" type="button" data-toggle="dropdown">
                    Operations                  
                        <span class="caret"></span>
                </button>
                <ul class="dropdown-menu" role="menu">
                    <li><a href="AddNewBook.aspx">Add new book</a></li>
                    <li><a href="AddWriter.aspx">Add writer</a></li>
                    <li><a href="AddNewUser.aspx">Add new user</a></li>
                    <li><a href="BookList.aspx">All books</a></li>
                    <li><a href="UserList.aspx">All users</a></li>
                    <li><a href="WriterList.aspx">All writers</a></li>
                    <li><a href="AllRecords.aspx">All records</a></li>
                </ul>
            </div>
            <br />
            <h1>Add new book</h1>
            <table class="table table-bordered">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Book Name:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxBookName" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Subject:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxSubject" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Page Number:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxPage" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Shelf No:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxShelfNo" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Writer Name:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownListWriter" CssClass="form-control" runat="server"></asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td colspan="2">
                        <asp:Button ID="ButtonAdd" CssClass="btn btn-success btn-block" runat="server" Text="ADD" OnClick="ButtonAdd_Click" />
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
