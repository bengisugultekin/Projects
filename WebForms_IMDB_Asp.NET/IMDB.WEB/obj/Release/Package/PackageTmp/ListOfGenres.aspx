<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListOfGenres.aspx.cs" Inherits="IMDB.WEB.ListOfGenres" %>

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
            <h1 class="alert alert-warning">GENRES</h1>


            <h4>Love Dramas? Sci-Fi? Crime? Click on the genre links below to go to the biggest and best collection of films sorted by their type.</h4>
            <br />
            <div class="table-responsive">

                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <a href="GenreDetails.aspx?ID=<%#Eval("GenreID") %>"><%#Eval("GenreName") %></a><br />
                    </ItemTemplate>
                </asp:Repeater>

            </div>
        </div>
    </form>
</body>
</html>
