using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLibrary;

namespace unit_test_moive
{
    [TestClass]
    public class UnitTestFilmManager
    {

        [TestMethod]
        public void TestFilmManager_AddFilm()
        {
            // ARRANGE
            List<LANGUAGE> languages = new List<LANGUAGE>();
            languages.Add(LANGUAGE.ENGLISH);
            languages.Add(LANGUAGE.GERMAN);
            Film film = new Movie("Deadpool", 2016, languages);
            IfilmDAL mockFilms = new MockFilms();
            FilmManager filmManager = new FilmManager(mockFilms);
            // ACT
            filmManager.AddFlim(film);
            string title = film.Title;
            int year = film.Year;
            int count = filmManager.GetAllFilms().Count;
            // ASSERT
            Assert.AreEqual(count, 1);
            Assert.AreEqual(title, "Deadpool");
            Assert.AreEqual(year, 2016);
        }

        [TestMethod]
        public void TestFilmManager_UpdateFilm()
        {
            // ARRANGE
            List<LANGUAGE> languages = new List<LANGUAGE>();
            languages.Add(LANGUAGE.ENGLISH);
            languages.Add(LANGUAGE.GERMAN);
            Film film = new Movie("Deadpool", 2016, languages);
            IfilmDAL mockFilms = new MockFilms();
            FilmManager filmManager = new FilmManager(mockFilms);
            // ACT
            filmManager.UpdateFilm(film, "Deadpool2", 2018, languages);
            string title = film.Title;
            int year = film.Year;
            // ASSERT
            Assert.AreEqual(title, "Deadpool2");
            Assert.AreEqual(year, 2018);
        }

        [TestMethod]
        public void TestFilmManager_DeleteFilm()
        {
            // ARRANGE
            Film film = new Movie("Deadpool", 2016);
            IfilmDAL mockFilms = new MockFilms();
            FilmManager filmManager = new FilmManager(mockFilms);
            // ACT
            filmManager.AddFlim(film);
            filmManager.DeleteMovies(film.ID);
            int count = filmManager.GetAllFilms().Count; //if GetAllFilms returns a DataTable, add . Colums to count
            // ASSERT
            Assert.AreEqual(count, 0);
        }

        [TestMethod]
        public void TestFilmManager_GetAllFilm()
        {
            // ARRANGE
            Film movie = new Movie("Deadpool", 2016);
            Film anime = new Anime("K on!", 2007);
            Film tvShow = new TV_Show("Killing Eve", 2018);
            IfilmDAL mockFilms = new MockFilms();
            FilmManager filmManager = new FilmManager(mockFilms);
            // ACT
            filmManager.AddFlim(movie);
            filmManager.AddFlim(anime);
            filmManager.AddFlim(tvShow);
            int count = filmManager.GetAllFilms().Count;
            // ASSERT
            Assert.AreEqual(count, 3);
        }

        [TestMethod]
        public void TestFilmManager_AddGetReview()
        {
            // ARRANGE
            Film movie = new Movie("Deadpool", 2016);
            UserClass user = new UserClass("Ash", "pass", true);
            Rate rate = new Rate(5, user, movie, "Very funny");
            IfilmDAL mockFilms = new MockFilms();
            FilmManager filmManager = new FilmManager(mockFilms);
            // ACT
            filmManager.UpdateReview(rate);
            filmManager.GetAllReviews();
            int count = filmManager.GetAllReviews().Count;
            // ASSERT
            Assert.AreEqual(count, 1);
        }
    }
}
