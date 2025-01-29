using Domain.Models;
using Wipro_OnlineMovieBookingApplication.Models;

namespace Services.Repository
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAllMovies();
        Movie GetMovie(int id);
        int AddMovie(Movie movie);
        int UpdateMovie(Movie movie);
        bool DeleteMovie(int id);
        bool MovieExists(int movieId);
    }
}
