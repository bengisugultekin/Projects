<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenreDetails.aspx.cs" Inherits="IMDB.WEB.GenreDetails" %>

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
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
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
            <h1 id="GenreName" runat="server" class="alert alert-warning">Genre: </h1>

            <br />
            <div class="table-responsive">

                <table class="table table-bordered">
                    <tr>
                        <th>Movie</th>
                        <th>Director</th>
                        <th>Year</th>
                        <th>Score</th>
                    </tr>

                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><a href="MovieDetails.aspx?ID=<%#Eval("MovieID") %>"><%#Eval("MovieName") %></a><br />
                                </td>
                                <td><a href="DirectorDetails.aspx?ID=<%#Eval("DirectorID") %>"><%#Eval("DirectorName") %></a></td>
                                <td><%#Eval("ReleaseDate") %></td>
                                <td><%#Eval("Score") %></td>

                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
