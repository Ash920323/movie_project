using LogicLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_test_moive
{
    public class MockFilms : IfilmDAL
    {
        private List<Film> films;
        private List<LANGUAGE> languages;
        private List<string> filmNames;

        public MockFilms()
        {
            films = new List<Film>();
        }
        public bool AddFlim(Film f)
        {
            return true;
        }

        public bool DeleteFilm(int id)
        {
            return true;
        }

        public List<Film> GetAllFilms()
        {
            /*DataTable dataTable = new DataTable();
            return dataTable;*/
            return films;
        }

        public List<LANGUAGE> GetFilmLanguages(int movieId)
        {
            return languages;
        }

        public List<string> GetFilmNames()
        {
            return filmNames;
        }

        public bool UpdateFilm(Film f)
        {
            return true;
        }

        public bool AddReview(Rate rate)
        {
            return true;
        }

        public bool GetAllReviews()
        {
            return true;
        }
    }
}
