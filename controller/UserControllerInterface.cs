using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.controller
{
    public interface UserControllerInterface
    {

        List<User> viewAllUsers();

        bool authenticateCredentials(string username, string password);

        User addUser(User user);

        User fetchUser(User user);

        User updateUser(User user);

        User fetchUserByUsername(User user);

        User updateUserAccountStatus(User user);
    }
}
