using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdministradorDeSazon.Controllers
{
    public class AdministradorController : Controller
    {
        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registro()
        {
            ViewBag.Message = "Registro de un nuevo Administrador y sus negocios.";

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