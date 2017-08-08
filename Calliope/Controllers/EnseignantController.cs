using Calliope.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calliope.Controllers
{
    public class EnseignantController : Controller
    {
        private ApplicationDbContext _dbContext;
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        public EnseignantController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Enseignant
        public ActionResult Index()
        {
            var Disciplines=_dbContext.Disciplines;

            return View(Disciplines);
        }
        public ActionResult Mes_Disciplines()
        {
            var Disciplines = _dbContext.Disciplines;

            return View(Disciplines);
        }
        public ActionResult Evaluations_individuelles()
        {
            return View();
        }
    }
}