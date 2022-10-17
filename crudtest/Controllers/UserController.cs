using crudtest.Data;
using crudtest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crudtest.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            List<UserModel> Users = new List<UserModel>();

            UserDao userDao = new UserDao();

            Users = userDao.Fetchall();

            return View("Index", Users);
        }
    }
}