using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
