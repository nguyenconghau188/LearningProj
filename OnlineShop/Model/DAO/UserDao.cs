using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.EF;

namespace Model.DAO
{
    public class UserDao
    {
        OnlineShopDbContext db = null;

        public UserDao()
        {
            db = new OnlineShopDbContext();
        }

        public long Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        public User GetByUsername(string username)
        {
            return db.Users.SingleOrDefault(x=>x.UserName == username);
        }

        public bool Login(string username, string password)
        {
            var result = db.Users.Count(x => x.UserName == username && x.Password == password);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}
