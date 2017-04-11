using IMDB.Entity.Model;
using IMDB.Entity.Model.DBConnection;
using IMDB.Entity.Model.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace IMDB.DAL
{
    public class MovieRepository
    {
        public static List<ViewMovie> GetAllMovies()
        {
            using (IMDbContext db = new IMDbContext())
            {
                return db.Movie
                    .Where(m => m.IsDeleted == false)
                    .Select(m => new ViewMovie
                    {
                        MovieID = m.MovieID,
                        MovieName = m.MovieName,
                        Description = m.Description,
                        ReleaseDate = m.ReleaseDate,
                        Score = m.Score,
                        ScoreCounter = m.ScoreCounter,
                        DirectorID = m.DirectorID,
                        GenreID = m.GenreID,

                        GenreName = m.Genre.GenreName,
                        DirectorName = m.Director.DirectorName,
                    })
                    .ToList();
            }
        }



        public static void AddMovie(ViewMovie vm)
        {
            using (IMDbContext db = new IMDbContext())
            {
                Movie newMovie = new Movie()
                {
                    MovieName = vm.MovieName,
                    Description = vm.Description,
                    ReleaseDate = vm.ReleaseDate,
                    Score = vm.Score,
                    ScoreCounter = vm.ScoreCounter,
                    totalScore = vm.TotalScore,
                    GenreID = db.Genre.FirstOrDefault(g => g.GenreName == vm.GenreName).GenreID,
                    DirectorID = db.Director.FirstOrDefault(d => d.DirectorName == vm.DirectorName).DirectorID
                };

                db.Movie.Add(newMovie);
                db.SaveChanges();
            }
        }

        public static ViewMovie GetViewMovie(int id)
        {
            using (IMDbContext db = new IMDbContext())
            {
                return db.Movie.Where(m => m.MovieID == id)
                    .Select(m => new ViewMovie
                    {
                        MovieID = m.MovieID,
                        MovieName = m.MovieName,
                        Description = m.Description,
                        ReleaseDate = m.ReleaseDate,
                        Score = m.Score,
                        ScoreCounter = m.ScoreCounter,

                        GenreName = m.Genre.GenreName,
                        DirectorName = m.Director.DirectorName,

                    }).FirstOrDefault();
            }
        }

        public static void DeleteMovie(int id)
        {
            using (IMDbContext db = new IMDbContext())
            {
                var result = db.Movie.Find(id);
                result.IsDeleted = true;
                db.SaveChanges();

            }
        }

        public static void UpdateMovie(ViewMovie vm)
        {
            using (IMDbContext db = new IMDbContext())
            {
                var uptadedMovie = db.Movie.Find(vm.MovieID);

                uptadedMovie.MovieName = vm.MovieName;

                uptadedMovie.DirectorID = db.Director.FirstOrDefault(d => d.DirectorName == vm.DirectorName).DirectorID;

                uptadedMovie.GenreID = db.Genre.FirstOrDefault(g => g.GenreName == vm.GenreName).GenreID;

                uptadedMovie.Description = vm.Description;
                uptadedMovie.ReleaseDate = vm.ReleaseDate;
                uptadedMovie.Score = vm.Score;
                uptadedMovie.totalScore = vm.TotalScore;
                uptadedMovie.ScoreCounter = vm.ScoreCounter;

                db.SaveChanges();
            }
        }

        public static void UpdateMovieScore(Movie movie)
        {
            using (IMDbContext db = new IMDbContext())
            {
                var uptadedMovie = db.Movie.Find(movie.MovieID);

                uptadedMovie.Score = movie.Score;
                uptadedMovie.totalScore = movie.totalScore;
                uptadedMovie.ScoreCounter = movie.ScoreCounter;

                db.SaveChanges();
            }
        }

        public static Movie GetMovie(int id)
        {
            using (IMDbContext db = new IMDbContext())
            {
                return db.Movie.Find(id);
            }
        }


        public static List<ViewMovie> GetAllMoviesByDirector(int directorID)
        {
            using (IMDbContext db = new IMDbContext())
            {
                return db.Movie
                    .Where(m => m.DirectorID == directorID && m.IsDeleted == false).
                    Select(m => new ViewMovie
                    {
                        DirectorID = m.DirectorID,
                        DirectorName = m.Director.DirectorName,

                        MovieID = m.MovieID,
                        MovieName = m.MovieName,
                        ReleaseDate = m.ReleaseDate,

                    }).ToList();
            }
        }

        public static List<ViewMovie> GetAllMoviesByGenre(int genreID)
        {
            using (IMDbContext db = new IMDbContext())
            {
                return db.Movie
                    .Where(m => m.GenreID == genreID && m.IsDeleted == false).
                    Select(m => new ViewMovie
                    {
                        DirectorID = m.DirectorID,
                        DirectorName = m.Director.DirectorName,

                        MovieID = m.MovieID,
                        MovieName = m.MovieName,
                        ReleaseDate = m.ReleaseDate,
                        Score = m.Score,

                    }).ToList();
            }
        }

        public static List<ViewMovie> GetAllMoviesByDescRating()
        {
            using (IMDbContext db = new IMDbContext())
            {
                return db.Movie
                    .Where(m => m.IsDeleted == false)
                    .OrderByDescending(m => m.Score)
                    .Select(m => new ViewMovie
                    {
                        MovieID = m.MovieID,
                        MovieName = m.MovieName,

                        DirectorID = m.DirectorID,
                        DirectorName = m.Director.DirectorName,

                        GenreID = m.GenreID,
                        GenreName = m.Genre.GenreName,

                        Score = m.Score,
                        ReleaseDate = m.ReleaseDate,

                    }).ToList();
            }
        }

        public static List<ViewMovie> GetAllMoviesByDescYear()
        {
            using (IMDbContext db = new IMDbContext())
            {
                return db.Movie
                    .Where(m => m.IsDeleted == false)
                    .OrderByDescending(m => m.ReleaseDate)
                    .Select(m => new ViewMovie
                    {
                        MovieID = m.MovieID,
                        MovieName = m.MovieName,

                        DirectorID = m.DirectorID,
                        DirectorName = m.Director.DirectorName,

                        GenreID = m.GenreID,
                        GenreName = m.Genre.GenreName,

                        Score = m.Score,
                        ReleaseDate = m.ReleaseDate,

                    }).ToList();
            }
        }

    }
}
