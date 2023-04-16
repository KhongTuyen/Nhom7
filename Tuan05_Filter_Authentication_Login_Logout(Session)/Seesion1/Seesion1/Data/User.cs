using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Seesion1.Models;
using PagedList.Mvc;
using PagedList;

namespace Seesion1.Data
{
    public class User
    {
        DBContext db = new DBContext();
        public IEnumerable<Account> ListUser(int page , int pageSize)
        {
            return db.Accounts.OrderBy(p=>p.name).ToPagedList(page, pageSize);
        }
    }
}