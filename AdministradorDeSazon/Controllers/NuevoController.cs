using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdministradorDeSazon.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Administrador()
        {
            ViewBag.Message = "Inicia tu operación con Administrador del Sazón.";

            return View();
        }

        public ActionResult RegistroNegocio()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult RegistroSucursal()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}