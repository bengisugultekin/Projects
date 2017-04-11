<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateMovie.aspx.cs" Inherits="IMDB.WEB.UpdateMovie" %>

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
            <h1 class="alert alert-warning">Update Movie</h1>
            <br />
            <div class="table-responsive">
                <table class="table table-responsive table-hover table-condensed">
                    <tr>
                        <td class="auto-style1" style="font-weight: bold">
                            <asp:Label ID="Label1" runat="server" Text="Movie"></asp:Label></td>
                        <td>
                            <input id="MovieName" type="text" class="form-control" runat="server" autocomplete="off" required />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1" style="font-weight: bold">
                            <asp:Label ID="Label2" runat="server" Text="Director"></asp:Label></td>
                        <td>
                            <asp:DropDownList ID="DropDownListDirectorName" CssClass="form-control" runat="server"></asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td class="auto-style1" style="font-weight: bold">
                            <asp:Label ID="Label3" runat="server" Text="Genre"></asp:Label></td>
                        <td>
                            <asp:DropDownList ID="DropDownListGenre" CssClass="form-control" runat="server"></asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td class="auto-style1" style="font-weight: bold">
                            <asp:Label ID="Label4" runat="server" Text="Description"></asp:Label></td>
                        <td>
                            <input id="Description" type="text" class="form-control" runat="server" autocomplete="off" required /></td>
                    </tr>
                    <tr>
                        <td class="auto-style1" style="font-weight: bold">
                            <asp:Label ID="Label5" runat="server" Text="Release Date"></asp:Label></td>
                        <td>
                            <input id="ReleaseDate" type="number" class="form-control" runat="server" maxlength="4" min="1900" max="2030" required placeholder="e.g., 2012" /></td>
                    </tr>
                    <tr>
                        <td class="auto-style1" style="font-weight: bold">
                            <asp:Label ID="Label6" runat="server" Text="Score"></asp:Label></td>
                        <td>
                            
                            <input id="Score" max="10" min="1" step="0.10" autocomplete="off" class="form-control" type="number" runat="server" required /></td>
                    </tr>

                </table>
                <asp:Button ID="ButtonSave" CssClass="btn btn-default" runat="server" Text="SAVE" OnClick="ButtonSave_Click" />
            </div>

        </div>
    </form>
    
</body>
</html>
