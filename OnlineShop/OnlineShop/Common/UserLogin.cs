using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Common
{
    [Serializable]
    public class UserLogin
    {
        public long UserID { get; set; }
        public string Username { get; set; }

    }
}