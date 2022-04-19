using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicLibrary;
using System.Collections.Generic;

namespace unit_test_moive
{
    [TestClass]
    public class UnitTestUser
    {
        [TestMethod]
        public void TestUserClass()
        {
            // ARRANGE
            UserClass user = new UserClass("Ash", "pass", true);
            // ACT
            string username = user.Username;
            string password = user.Password;
            bool hasAuthority = user.HasAuthority;
            // ASSERT
            Assert.AreEqual(username, "Ash");
            Assert.AreEqual(password, "pass");
            Assert.AreEqual(hasAuthority, true);
        }

        [TestMethod]
        public void TestUserManager_CreateUser()
        {
            // ARRANGE
            UserClass user = new UserClass("Ash", "pass", true);
            MockUser mockUser = new MockUser();
            UserManager userManager = new UserManager(mockUser);
            // ACT
            userManager.CreateUser(user);
            int count = userManager.ReturnAllUsers().Count;
            // ASSERT
            Assert.AreEqual(count, 1);
        }

        [TestMethod]
        public void TestUserManager_DeleteUser()
        {
            // ARRANGEs
            UserClass user = new UserClass("Ash", "pass", true);
            MockUser mockUser = new MockUser();
            UserManager userManager = new UserManager(mockUser);
            // ACT
            userManager.CreateUser(user);
            userManager.DeleteUser(user.Id);
            int count = userManager.ReturnAllUsers().Count;
            // ASSERT
            Assert.AreEqual(count, 0);
        }

        [TestMethod]
        public void TestUserManager_ReturnAllUsers()
        {
            // ARRANGEs
            UserClass user1 = new UserClass("Ash", "pass", true);
            UserClass user2 = new UserClass("John", "doe", false);
            MockUser mockUser = new MockUser();
            UserManager userManager = new UserManager(mockUser);
            // ACT
            userManager.CreateUser(user1);
            userManager.CreateUser(user2);
            int count = userManager.ReturnAllUsers().Count;
            // ASSERT
            Assert.AreEqual(count, 2);
        }

        [TestMethod]
        public void TestUserManager_UpdateUser()
        {
            // ARRANGEs
            UserClass user = new UserClass("Ash", "pass", true);
            MockUser mockUser = new MockUser();
            UserManager userManager = new UserManager(mockUser);
            // ACT
            userManager.CreateUser(user);
            userManager.UpdateUser(user, "newUsername", "newPassword", false);
            string username = user.Username;
            string password = user.Password;
            bool hasAuthority = user.HasAuthority;
            // ASSERT
            Assert.AreEqual(username, "newUsername");
            Assert.AreEqual(password, "newPassword");
            Assert.AreEqual(hasAuthority, false);
        }

        [TestMethod]
        public void TestUserManager_Login()
        {
            // ARRANGEs
            UserClass user = new UserClass("Ash", "pass", true);
            MockUser mockUser = new MockUser();
            UserManager userManager = new UserManager(mockUser);
            // ACT
            userManager.CreateUser(user);
            UserClass testUser = userManager.Login("Ash", "pass");
            // ASSERT
            Assert.AreEqual(user, testUser);
        }
    }
}
