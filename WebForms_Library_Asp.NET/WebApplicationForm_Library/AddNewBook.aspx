<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNewBook.aspx.cs" Inherits="WebApplicationForm_Library.AddNewBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <style type="text/css">
        body{
            font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
            <h1>Add new book</h1>
            <table class="table table-bordered" >
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
                        <asp:Label ID="Label5" runat="server" Text="Writer Name:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxWriterName" CssClass="form-control" runat="server"></asp:TextBox>
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
                        <asp:Label ID="Label3" runat="server" Text="Shelf No:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxShelfNo" CssClass="form-control" runat="server"></asp:TextBox>
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
                        <asp:Label ID="Label6" runat="server" Text="Rental State:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxRentalState" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td colspan="2">
                        <asp:Button ID="ButtonAdd" class="btn btn-success btn-block" runat="server" Text="ADD" OnClick="ButtonAdd_Click" />
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
