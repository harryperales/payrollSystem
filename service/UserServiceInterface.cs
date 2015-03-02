using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.service
{
    public interface UserServiceInterface
    {
        List<User> fetchAllUsers();

        bool validateUser(User user);

        User createUser(User user);

        User fetchUser(User user);

        User updateUser(User user);

        User fetchUserByUsername(User user);

        User updateUserAccountStatus(User user);
    }
}
