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

        public int Login(string username, string password)
        {
            var result = db.Users.SingleOrDefault(x => x.UserName == username);
            if (result == null)
            {
                return DefinedParam.LOGIN_NULL;
            }
            else
            {
                if (result.Status == false)
                {
                    return DefinedParam.LOGIN_FALSE;
                }
                else
                {
                    if (result.Password == password)
                    {
                        return DefinedParam.LOGIN_SUCCESS;
                    }
                    return DefinedParam.LOGIN_FALSE_PASSWORD;
                }
            }
        }
    }
}
