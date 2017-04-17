<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCustomer.aspx.cs" Inherits="WebApplicationForm_CRUD.AddCustomer" %>

<!DOCTYPE html>

<head runat="server">
    <title>Add Customer</title>
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
            <h1>Add new customer</h1>
            <table class="table table-bordered">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxName" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Surname:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxSurname" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="PhoneNumber:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxPhone" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Address:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxAddress" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td colspan="2">
                        <asp:Button ID="ButtonSave" class="btn btn-primary btn-block" runat="server" Text="SAVE" OnClick="ButtonSave_Click" />
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
