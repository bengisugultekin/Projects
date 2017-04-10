<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RentBook.aspx.cs" Inherits="WebApplicationForm_Library.RentBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rent a book</title>
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
            <h1>Rent a book</h1>
            <table class="table table-bordered" >
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Book Name:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelBookName" runat="server" ></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Writer Name:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelWriterName" runat="server"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Subject:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelSubject" runat="server"></asp:Label>
                    </td>
                </tr>
                
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Shelf No:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelShelfNo" runat="server"></asp:Label>
                    </td>
                </tr>
                
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Page Number:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelPage" runat="server"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Rental State:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelRentalState" runat="server"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label10" runat="server" Text="Rent Date:"></asp:Label>
                    </td>
                    <td>
                        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged" CellPadding="4" DayNameFormat="Shortest">
                            <DayHeaderStyle Font-Bold="True" Font-Size="7pt" BackColor="#CCCCCC" />
                            <NextPrevStyle VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#808080" />
                            <SelectedDayStyle BackColor="#666666" ForeColor="White" Font-Bold="True" />
                            <SelectorStyle BackColor="#CCCCCC" />
                            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <WeekendDayStyle BackColor="#FFFFCC" />
                        </asp:Calendar>                       
                        
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label11" runat="server" Text="Return Date:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelReturnDate" CssClass="label label-warning" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="User Name:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxUserName" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="Address:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxAddress" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Phone Number:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxPhone" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
               
                <tr>
                    <td colspan="2">
                        <asp:Button ID="ButtonRent" CssClass="btn btn-success btn-block" runat="server" Text="RENT" OnClick="ButtonRent_Click"  />
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
