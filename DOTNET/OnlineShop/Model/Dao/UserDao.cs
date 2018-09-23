using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class UserDao
    {
        OnlineShopDbContext db = null;

        public UserDao()
        {
            db = new OnlineShopDbContext();
        }

        public long Insert(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return user.ID;
        }

        public bool Login(string username, string password)
        {
            int count = db.Users.Count(x => x.UserName == username && x.Password == password);
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        public User GetByUsername(string username)
        {
            return db.Users.SingleOrDefault(x => x.UserName == username);
        }

        public string CheckExist(string username, string email)
        {
            string error = "";
            if (db.Users.Count(x=>x.UserName == username) > 0)
            {
                error += "Username has already been taken!\n";
            }
            if (db.Users.Count(x=>x.Email == email) > 0)
            {
                error += "Email has already been taken!\n";
            }
            return error;
        }
    }
}
