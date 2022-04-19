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
    public class UnitTestFilm
    {
        [TestMethod]
        public void TestFilmClass_Movie()
        {
            // ARRANGE
            List<LANGUAGE> languages = new List<LANGUAGE>();
            languages.Add(LANGUAGE.ENGLISH);
            languages.Add(LANGUAGE.GERMAN);
            Film movie = new Movie("Deapool", 2016, languages, 200);
            Movie testType = new Movie("Deapool", 2016, languages, 200);
            // ACT
            string title = movie.Title;
            int year = movie.Year;
            List<LANGUAGE> getLanguages = movie.Languages;
            var type = movie.GetType();
            int lenghtInMin = ((Movie)movie).LenghtInMin;
            // ASSERT
            Assert.AreEqual(title, "Deapool");
            Assert.AreEqual(year, 2016);
            Assert.AreEqual(languages, getLanguages);
            Assert.AreEqual(type, testType.GetType());
            Assert.AreEqual(lenghtInMin, 200);
        }
        [TestMethod]
        public void TestFilmClass_TVShow()
        {
            // ARRANGE
            List<LANGUAGE> languages = new List<LANGUAGE>();
            languages.Add(LANGUAGE.ENGLISH);
            languages.Add(LANGUAGE.GERMAN);
            languages.Add(LANGUAGE.DUTCH);
            Film tvShow = new TV_Show("Killing Eve", 2018, languages, 48);
            TV_Show testType = new TV_Show("Killing Eve", 2018, languages, 48);
            // ACT
            string title = tvShow.Title;
            int year = tvShow.Year;
            List<LANGUAGE> getLanguages = tvShow.Languages;
            var type = tvShow.GetType();
            // ASSERT
            Assert.AreEqual(title, "Killing Eve");
            Assert.AreEqual(year, 2018);
            Assert.AreEqual(languages, getLanguages);
            Assert.AreEqual(type, testType.GetType());
        }
        [TestMethod]
        public void TestFilmClass_Anime()
        {
            // ARRANGE
            List<LANGUAGE> languages = new List<LANGUAGE>();
            languages.Add(LANGUAGE.JANPANESE);
            languages.Add(LANGUAGE.MANDRAIN);
            Film anime = new Anime("K on!", 2009, languages, 27);
            // ACT
            string title = anime.Title;
            int year = anime.Year;
            List<LANGUAGE> getLanguages = anime.Languages;
            int numOfEpdsoide = ((Anime)anime).NumEpisode;
            // ASSERT
            Assert.AreEqual(title, "K on!");
            Assert.AreEqual(year, 2009);
            Assert.AreEqual(languages, getLanguages);
            Assert.AreEqual(numOfEpdsoide, 27);
        }
        [TestMethod]
        public void TestRateClass()
        {
             // ARRANGE
            Film movie = new Movie("Deadpool", 2016);
            UserClass user = new UserClass("Ash", "pass", true);
            Rate rate = new Rate(5, user, movie, "Very funny");
            //ACT
            int rating = rate.Rating;
            UserClass testUser = rate.User;
            Film testfilm = rate.Film;
            string comment = rate.Comment;
            //Assert
            Assert.AreEqual(rating, 5);
            Assert.AreEqual(testUser, user);
            Assert.AreEqual(testfilm, movie);
            Assert.AreEqual(comment, "Very funny");
        }
       
    }
}
