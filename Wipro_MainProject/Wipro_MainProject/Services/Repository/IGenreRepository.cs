using Domain.Models;
using Wipro_OnlineMovieBookingApplication.Models;

namespace Services.Repository
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> GetAllGenres();
        Genre GetGenre(int id);
        //int AddGenre(Genre genre);
        //int UpdateGenre(Genre genre);
        //bool DeleteGenre(int id);
    }
}
