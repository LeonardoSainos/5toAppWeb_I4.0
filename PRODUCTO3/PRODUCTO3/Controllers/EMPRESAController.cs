using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PRODUCTO3.Models;

namespace PRODUCTO3.Controllers
{
    public class EMPRESAController : Controller
    {
        public object Configuration { get; private set; }

        // GET: EMPRESA
        // GET: Persona
        public ActionResult Index()
        {
            try
            {

                using (EMPRESAEntities5 bd = new EMPRESAEntities5())
                {

                    List<Rol> lista = bd.Rol.Where(a => a.idrol >= 0).ToList();
                    return View(lista);
                }

            }
            catch (Exception t)
            {
                throw  ;
            }

        }
        [HttpGet]
        public ActionResult Agregar_Rol()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Agregar_Rol(Rol per)
        {

            try
            {
                using (EMPRESAEntities5 bd = new EMPRESAEntities5())
                {
                    bd.Rol.Add(per);
                    bd.SaveChanges();
                    return RedirectToAction("Index");
                    
                }
            }
            catch (Exception t)
            {
                ModelState.AddModelError("Error al crear el Rol ", t);
                return View();
            }
        }
        [HttpGet]
        public ActionResult Modificar_Rol(int id)
        {
            try
            {
                using (EMPRESAEntities5 bd = new EMPRESAEntities5())
                {
                    Rol obj = bd.Rol.Find(id);  // Debe ser Orimary key afuerza
                    return View(obj);
                }
            }
            catch (Exception t)
            {
                ModelState.AddModelError("Error al actualizar el Rol ", t);
                return View();
            }


        }
        [HttpPost]

        public ActionResult Modificar_Rol(Rol obj)
        {

            try
            {
                using (EMPRESAEntities5 bd = new EMPRESAEntities5())
                {
                    Rol obje = bd.Rol.Find(obj.idrol);
                    obje.nombre = obj.nombre;
                    obje.estatus = obj.estatus;
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


        public ActionResult Eliminar_Rol(int id)
        {
            try
            {
                using (EMPRESAEntities5 bd = new EMPRESAEntities5())
                {
                    Rol Existe = bd.Rol.Find(id);
                    bd.Rol.Remove(Existe);
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

        public ActionResult DetallesRol(int id)
        {

            try
            {
                using (EMPRESAEntities5 bd = new EMPRESAEntities5())
                {
                    Rol Existe = bd.Rol.Find(id);
                    return View(Existe);

                }


            }
            catch (Exception t)
            {
                ModelState.AddModelError("Error al mostrar los datos de este registro ", t);
                return View();
            }
        }


        public ActionResult Asiste()
        {
            try
            {
                //this.Configuration.LazyLoadingEnabled = false;
                using (EMPRESAEntities5 bd = new EMPRESAEntities5())
                {
                    List<Asiste> lista = bd.Asiste.Where(a => a.idAsistencia >= 0).ToList();
                    return View(lista);
                }
            }
            catch (Exception t)
            {
                throw;
            }

        }

        [HttpGet]
        public ActionResult Dar_Asistencia()
        {
            return View();
        }
        [HttpPost]   
        public ActionResult Dar_Asistencia(Asiste asi)
        {

            try
            {
                using (EMPRESAEntities5 bd = new EMPRESAEntities5())
                {
                    bd.Asiste.Add(asi);
                    bd.SaveChanges();
                    return RedirectToAction("Asiste");

                }
            }
            catch (Exception t)
            {
                ModelState.AddModelError("Error al dar la asistencia ", t);
                return View();
            }

        }

        public ActionResult DetallesAsiste(int id)
        {

            try
            {
                using (EMPRESAEntities5 bd = new EMPRESAEntities5())
                {
                    Asiste Existe = bd.Asiste.Find(id);
                    return View(Existe);

                }


            }
            catch (Exception t)
            {
                ModelState.AddModelError("Error al mostrar los datos de este registro ", t);
                return View();
            }
        }

        public ActionResult BorrarAsistencia(int id)
        {
            try
            {
                using (EMPRESAEntities5 bd = new EMPRESAEntities5())
                {
                    Asiste Existe = bd.Asiste.Find(id);
                    bd.Asiste.Remove(Existe);
                    bd.SaveChanges();
                    return RedirectToAction("Asiste");
                }


            }
            catch (Exception t)
            {
                ModelState.AddModelError("Error al eliminar ", t);
                return View();
            }

        }

         

        public ActionResult Trabajador()
        {
            try
            {

                using (EMPRESAEntities5 bd = new EMPRESAEntities5())
                {

                    List<Trabajador> lista = bd.Trabajador.Where(a => a.id >= 0).ToList();
                    return View(lista);
                }

            }
            catch (Exception t)
            {
                throw;
            }

        }

        public ActionResult DetallesTrabajador(int id)
        {

            try
            {
                using (EMPRESAEntities5 bd = new EMPRESAEntities5())
                {
                    Trabajador Existe = bd.Trabajador.Find(id);
                    return View(Existe);

                }

            }
            catch (Exception t)
            {
                ModelState.AddModelError("Error al mostrar los datos de este registro ", t);
                return View();
            }
        }
        public ActionResult DarBaja(int id)
        {
            try
            {
                using (EMPRESAEntities5 bd = new EMPRESAEntities5())
                {
                    Trabajador Existe = bd.Trabajador.Find(id);
                    bd.Trabajador.Remove(Existe);
                    bd.SaveChanges();
                    return RedirectToAction("Trabajador");
                }
            }
            catch (Exception t)
            {
                ModelState.AddModelError("Error al eliminar ", t);
                return View();
            }
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Trabajador asi)
        {

            try
            {
                using (EMPRESAEntities5 bd = new EMPRESAEntities5())
                {
                    bd.Trabajador.Add(asi);
                    bd.SaveChanges();
                    return RedirectToAction("Login");

                }
            }
            catch (Exception t)
            {
                ModelState.AddModelError("Error al loguearse ", t);
                return View();
            }

        }

        [HttpGet]
        public ActionResult Modificar_Trabajador(int id)
        {
            try
            {
                using (EMPRESAEntities5 bd = new EMPRESAEntities5())
                {
                    Trabajador obj = bd.Trabajador.Find(id);  // Debe ser Orimary key afuerza
                    return View(obj);
                }
            }
            catch (Exception t)
            {
                ModelState.AddModelError("Error al actualizar el Rol ", t);
                return View();
            }


        }
        [HttpPost]

        public ActionResult Modificar_Trabajador(Trabajador obj)
        {

            try
            {
                using (EMPRESAEntities5 bd = new EMPRESAEntities5())
                {
                    Trabajador obje = bd.Trabajador.Find(obj.id);
                    obje.nombre = obj.nombre;
                    obje.apellidos = obj.apellidos;
                    obje.sexo = obj.sexo;
                    obje.correo = obj.correo;
                    obje.salario = obj.salario;
                    bd.SaveChanges();
                    return RedirectToAction("Trabajador");
                }

            }
            catch (Exception t)
            {
                ModelState.AddModelError("Error al actualizar persona ", t);
                return View();
            }

        }

        [HttpGet]
        public ActionResult Modificar_Asistencia(int id)
        {
            try
            {
                using (EMPRESAEntities5 bd = new EMPRESAEntities5())
                {
                    Asiste obj = bd.Asiste.Find(id);  // Debe ser Orimary key afuerza
                    return View(obj);
                }
            }
            catch (Exception t)
            {
                ModelState.AddModelError("Error al actualizar el Rol ", t);
                return View();
            }


        }
        [HttpPost]

        public ActionResult Modificar_Asistencia(Asiste obj)
        {

            try
            {
                using (EMPRESAEntities5 bd = new EMPRESAEntities5())
                {
                     Asiste obje = bd.Asiste.Find(obj.idAsistencia);
                    obje.valor = obj.valor;
                    
                    bd.SaveChanges();
                    return RedirectToAction("Asiste");
                }

            }
            catch (Exception t)
            {
                ModelState.AddModelError("Error al actualizar persona ", t);
                return View();
            }

        }
    }
}