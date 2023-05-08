using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCATRASADO.Models;
using System.Web.Mvc;

namespace MVCATRASADO.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()

        {


            try 
            {

                using (CLASE24Entities bd = new CLASE24Entities())
                {

                    List<Persona> lista = bd.Persona.Where(a => a.id >= 1).ToList();
                    return View(lista);
                }

            }
            catch (Exception t)
            {
                throw;
            }
 
        }
        [HttpGet]
        public ActionResult Agregar_persona() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Agregar_persona(Persona per)
        {
            
             try
                {
                using (CLASE24Entities bd = new CLASE24Entities())
                {
                    bd.Persona.Add(per);
                    bd.SaveChanges();
                    return RedirectToAction("Index");
;                }
            }
            catch (Exception t)
            {
                ModelState.AddModelError("Error al agregar a el registro ", t );
                return View();
            }
       
        }
        [HttpGet]
        public ActionResult Modificar_Persona(int id)
        {
            try
            {
                using (CLASE24Entities bd = new CLASE24Entities())
                {
                    Persona obj = bd.Persona.Find(id);  // Debe ser Orimary key afuerza
                    return View(obj);
                }
            }
            catch (Exception t)
            {
                ModelState.AddModelError("Error al actualizar persona ", t);
                return View();
            }


        }
        [HttpPost]

        public ActionResult Modificar_Persona (Persona obj)
        {
           
            try
            {
                using (CLASE24Entities bd = new CLASE24Entities())
                {
                    Persona obje = bd.Persona.Find(obj.id);
                    obje.nombre = obj.nombre;
                    bd.SaveChanges();
                    return RedirectToAction("Index");
                }

            }
            catch (Exception t)
            {
                ModelState.AddModelError("Error al actualizar persona ", t);
                return View();
            }
 
        }
        public ActionResult DetallesPersona(int id)
        {

            try
            {
                using (CLASE24Entities bd = new CLASE24Entities())
                {
                    Persona Existe = bd.Persona.Find(id);
                    return View(Existe);

                }


            }
            catch (Exception t)
            {
                ModelState.AddModelError("Error al mostrar ", t);
                return View();
            }
        }

        public ActionResult EliminarPersona(int id )
        {
            try
            {
                using (CLASE24Entities bd = new CLASE24Entities())
                {
                    Persona Existe = bd.Persona.Find(id);
                    bd.Persona.Remove(Existe);
                    bd.SaveChanges();
                    return RedirectToAction("Index");
                  }


            }
            catch (Exception t)
            {
                ModelState.AddModelError("Error al eliminar ", t);
                return View();
            }

        }
    }
     
}