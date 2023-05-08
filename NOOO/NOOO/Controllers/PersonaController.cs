using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NOOO.Models;
using System.Data;
using NOOO.Controllers;

namespace NOOO.Controllers
{
    public class PersonaController : Controller
    {

        Repositorio bd = new Repositorio();
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Agregar_registro()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Agregar_registro(FormCollection fc)
        {
            Persona per = new Persona();
            per.propiedad_nombre = fc["Nom"];
            bd.Add_Registro(per);
            TempData["msg"] = "Insertado";
            return RedirectToAction("Mostrar_datos");

        }

        public ActionResult Mostrar_datos()
        {
            DataSet ds = bd.Mostrar_registros();
            ViewBag.per = ds.Tables[0];
            return View();
        }

        [HttpGet]
        public ActionResult Actualizar(int id)
        {
            DataSet ds = bd.MostrarPorID(id);
            ViewBag.per = ds.Tables[0];
            return View();

        }
        public ActionResult Actualizar(int id, FormCollection fc)
        {
            Persona per = new Persona();
            per.propiedad_id = Convert.ToInt32(id);
            per.propiedad_nombre = fc["Nom"];
            bd.update_Registro(per);
            TempData["msd"] = "Actualizado";
            return RedirectToAction("Mostrar_datos");
           // return View();
        }


        public  ActionResult Eliminar_registro(int id )
        {
            bd.Eliminar_registro(id);
            TempData["msg"] = "Eliminado";
            return RedirectToAction("Mostrar_datos");
        }

    }
}