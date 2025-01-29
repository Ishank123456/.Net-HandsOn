using Domain.Models;
using Wipro_OnlineMovieBookingApplication.Models;

namespace Services.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly WiproOnlineMovieBookingApplicationContext movieDbContext;

        public MovieRepository(WiproOnlineMovieBookingApplicationContext _movieDbContext)
        {
            movieDbContext = _movieDbContext;
        }

        public int AddMovie(Movie movie)
        {
            movieDbContext.Movies.Add(movie);
            return movieDbContext.SaveChanges();
        }

        public bool DeleteMovie(int id)
        {
            var filterData = movieDbContext.Movies.SingleOrDefault(m => m.MovieId == id);
            if (filterData != null)
            {
                movieDbContext.Movies.Remove(filterData);
                movieDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return movieDbContext.Movies.ToList();
        }

        public Movie GetMovie(int id)
        {
            return movieDbContext.Movies.SingleOrDefault(m => m.MovieId == id);
        }

        public bool MovieExists(int movieId)
        {
            return movieDbContext.Movies.Any(m => m.MovieId == movieId);
        }

        public int UpdateMovie(Movie movie)
        {
            movieDbContext.Movies.Update(movie);
            return movieDbContext.SaveChanges();
        }
    }
}
