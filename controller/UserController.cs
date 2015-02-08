using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.service;
using PayrollSystem.model;
using System.Windows.Forms;
using PayrollSystem.view;

namespace PayrollSystem.controller
{
    public class UserController : UserControllerInterface
    {
        private UserServiceInterface userService;

        public UserController()
        {
            userService = new UserService();
        }

        public void index()
        {
            Console.WriteLine(userService.fetchAllUsers());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        public List<User> viewAllUsers()
        {
            return userService.fetchAllUsers();
        }

        public bool authenticateCredentials(string username, string password)
        {
            User user = new User();
            user.username = username;
            user.password = password;
            return userService.validateUser(user);
        }

        public User addUser(User user)
        {
            return userService.createUser(user);
        }

        public User fetchUser(User user)
        {
            return userService.fetchUser(user);
        }

        public User updateUser(User user)
        {
            return userService.updateUser(user);
        }

        public User fetchUserByUsername(User user)
        {
            return userService.fetchUserByUsername(user);
        }
    }
}
