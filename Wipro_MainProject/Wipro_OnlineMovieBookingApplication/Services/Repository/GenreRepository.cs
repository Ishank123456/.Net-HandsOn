using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class GenreRepository : IGenreRepository
    {
        private readonly OnlineMovieBookingApplicationContext genreRepository;
        public GenreRepository(OnlineMovieBookingApplicationContext _genreRepository)
        {
            genreRepository = _genreRepository;
        }

        //public int AddGenre(Genre genre)
        //{
        //    genreRepository.Genres.Add(genre);
        //    return genreRepository.SaveChanges();
        //}

        //public bool DeleteGenre(int id)
        //{
        //    var filterData = genreRepository.Genres.SingleOrDefault(g => g.GenreId == id);
        //    var result = genreRepository.Genres.Remove(filterData);
        //    genreRepository.SaveChanges();
        //    return result != null ? true : false;
        //}

        public IEnumerable<Genre> GetAllGenres()
        {
            return genreRepository.Genres.ToList();
        }

        public Genre GetGenre(int id)
        {
            return genreRepository.Genres.SingleOrDefault(g => g.GenreId == id);
        }

        //public int UpdateGenre(Genre genre)
        //{
        //    genreRepository.Genres.Update(genre);
        //    return genreRepository.SaveChanges();
        //}
    }
}
