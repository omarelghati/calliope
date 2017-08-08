using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calliope.Models;
using Calliope.Models.App;
using System.Text.RegularExpressions;

namespace Calliope.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            //Regex regex = new Regex("^([\\+]?(?:00)?[0-9]{1,3}[\\s.-]?[0-9]{1,12})([\\s.-]?[0-9]{1,4}?)$");
            //if (regex.IsMatch(user.phone))
            //{

                if (ModelState.IsValid)
                {
                    using (ApplicationDbContext db = new ApplicationDbContext())
                    {
                        db.Users.Add(user);
                        db.SaveChanges();
                        ViewBag.Message = db.GetValidationErrors();
                        Session["id"] = user.Id;
                        Session["nomComplet"] = user.nomComplet;
                        Session["email"] = user.email;
                        Session["type"] = user.type;
                        ModelState.Clear();
                        return RedirectToAction("Index", "Home", new { area = "" });
                    }
                }
            //}
            //else
            //{
            //    ViewBag.Message = "fomat du numéro invalide";
            //}
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var usr = db.Users.SingleOrDefault(u => u.email.Equals(user.email) && u.password.Equals(user.password) && u.type.Equals(user.type));
                if (usr != null)
                {
                    Session["id"] = usr.Id;
                    Session["nomComplet"] = usr.nomComplet;
                    Session["email"] = usr.email;
                    return RedirectToAction("Index", "Enseignant",new { area = "" });
                }
                else
                {
                    ModelState.AddModelError("", "Informations invalides");
                }
            }
            return View();
        }
    }
}