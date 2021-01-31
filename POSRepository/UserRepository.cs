using POSData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSRepository
{
    public class UserRepository
    {
        private POSEntities _db;

        //Database instance
        public UserRepository()
        {
            _db = new POSEntities(); 
        }

        //Add User
        public void AddUser(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }

        //Remove User
        public void RemoveUser(int userId)
        {
            var user = _db.Users.FirstOrDefault(a => a.UserId == userId);

            if (user != null)
            {
                _db.Users.Remove(user);
                _db.SaveChanges();
            }
            else
            {
                throw new Exception("User not found.");
            }

        }

        //Update User
        public User UpdateUser(User user)
        {
            return null;
        }

        //Get by ID from User
        public User GetUser(int userId)
        {
            return _db.Users.FirstOrDefault(a => a.UserId == userId);
        }

        //Get All Users
        public List<User> GetUsers()
        {
            return _db.Users.ToList();
        }



    }
}
