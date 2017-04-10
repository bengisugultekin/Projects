<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieDetails.aspx.cs" Inherits="IMDB.WEB.MovieDetails" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">

    <title>IMDb The Internet Movie Database</title>

    <link rel="shortcut icon" href="/favicon.ico" type="image/x-icon">
    <link rel="icon" href="/favicon.ico" type="image/x-icon">

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

    <style type="text/css">
        .auto-style1 {
            width: 169px;
        }
        .auto-style2 {
            width: 991px;
        }
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif
        }
        </style>

</head>
<body>
    <nav class="navbar navbar-inverse">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" href="ListOfMovies.aspx">IMDb</a>
            </div>
            <ul class="nav navbar-nav">
                <li class="dropdown"><a class="dropdown-toggle" data-toggle="dropdown" href="#">Movie<span class="caret"></span></a>
                    <ul class="dropdown-menu">
                        <li><a href="ListOfMovies.aspx">List of Movies</a></li>
                        <li><a href="AddMovie.aspx">Add Movie</a></li>
                    </ul>
                </li>

                <li class="dropdown"><a class="dropdown-toggle" data-toggle="dropdown" href="#">Director<span class="caret"></span></a>
                    <ul class="dropdown-menu">
                        <li><a href="ListOfDirectors.aspx">List of Directors</a></li>
                        <li><a href="AddDirector.aspx">Add Director</a></li>
                    </ul>
                </li>

                <li class="dropdown"><a class="dropdown-toggle" data-toggle="dropdown" href="#">Genre<span class="caret"></span></a>
                    <ul class="dropdown-menu">
                        <li><a href="ListOfGenres.aspx">List of Genres</a></li>
                        <li><a href="AddGenre.aspx">Add Genre</a></li>
                    </ul>
                </li>
            </ul>
        </div>
    </nav>
    <form id="form1" runat="server">
        <div class="container">
            <h1 class="alert alert-warning">Movie Details</h1>
            <br />
            <div class="table-responsive">
                <table class="table table-responsive table-hover table-condensed">
                    <tr>
                        <td class="auto-style1" style="font-weight: bold"><asp:Label ID="Label1" runat="server" Text="Movie"></asp:Label></td>                        
                        <td class="auto-style2"><asp:Label ID="LabelMovieName"  runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1" style="font-weight: bold"><asp:Label ID="Label2" runat="server" Text="Director"></asp:Label></td>
                        <td class="auto-style2"><asp:Label ID="LabelDirectorName" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1" style="font-weight: bold"><asp:Label ID="Label3" runat="server" Text="Genre"></asp:Label></td>
                        <td class="auto-style2"><asp:Label ID="LabelGenreName" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1" style="font-weight: bold"><asp:Label ID="Label4" runat="server" Text="Description"></asp:Label></td>
                        <td class="auto-style2"><asp:Label ID="LabelDescription" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1" style="font-weight: bold"><asp:Label ID="Label5" runat="server" Text="Release Date"></asp:Label></td>
                        <td class="auto-style2"><asp:Label ID="LabelReleaseDate" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1" style="font-weight: bold"><asp:Label ID="Label6" runat="server" Text="Score"></asp:Label></td>
                        <td class="auto-style2"><asp:Label ID="LabelScore" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1" style="font-weight: bold"><asp:Label ID="Label" runat="server" Text="Your Score"></asp:Label></td>
                        <td class="auto-style2"><asp:DropDownList ID="DropDownListScore" CssClass="form-control-static" runat="server" Width="56px">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            </asp:DropDownList>
                        <asp:Button ID="ButtonSubmit" runat="server" CssClass="btn btn-default" Text="Submit" OnClick="ButtonSubmit_Click" /></td>
                    </tr>
                    
                </table>
            </div>

        </div>
    </form>
</body>
</html>
