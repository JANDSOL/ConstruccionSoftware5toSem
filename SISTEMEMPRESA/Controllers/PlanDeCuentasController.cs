using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SISTEMEMPRESA.Models;

namespace SISTEMEMPRESA.Controllers
{
    public class PlanDeCuentasController : Controller
    {
        private ConnDbSISTEMAEMPRESA db = new ConnDbSISTEMAEMPRESA();
        // GET: PlanDeCuentas
        public ActionResult Index()
        {
            return View(db.CNTBPLANDECUENTA.ToList());
        }
    }
}