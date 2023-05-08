using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLA
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "";
            while (resp != "Si" || resp != "si")
            {
                int opcion = 0;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Operaciones con entity framework");
                Console.WriteLine("1 consulta general");
                Console.WriteLine("2 insertar registro ");
                Console.WriteLine("3 Actualizar registro");
                Console.WriteLine("4 Eliminar ");
                Console.WriteLine("5 Otro actualizar ");
                Console.WriteLine("6 Eliminar por nombre  ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            ConsultaGeneral();
                            Console.WriteLine("Escribe si para salir");
                            resp = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Dame un nombre");
                            string nom = Console.ReadLine();
                            InsertarPersona(nom);
                            Console.WriteLine("nombre " + nom + " insertado ¿  Deseas insertar otro ?");
                            resp = Console.ReadLine();


                        }
                        break;

                    case 3:
                        {
                            string sal = "";

                            ConsultaGeneral();
                            Console.WriteLine("Dame un nombre  que quieras actualizar");
                            string nom = Console.ReadLine();
                            Console.WriteLine("Ahora dame el nuevo ");
                            string nuevo = Console.ReadLine();
                            Actualizar(nom, nuevo);
                            Console.WriteLine("Registro actualizado deseas actualizar otro ?");
                            sal = Console.ReadLine();


                            Console.WriteLine("Escribe si para salir de actualizar");
                            resp = Console.ReadLine();

                            break;
                        }

                    case 4:
                        {
                            ConsultaGeneral();
                            Console.WriteLine("Dame un id para eliminar");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Eliminar_Perosna(id);
                            Console.WriteLine("Persona borrada  " + " ¿  Deseas borrar otro ?");
                            resp = Console.ReadLine();
                            break;
                        }

                    case 5:
                        {
                            ConsultaGeneral();
                            Console.WriteLine("Dame un nombre para actualizar ");
                            string nombreviejo  = Console.ReadLine();
                            Console.WriteLine("Dame el nombre nuevo");
                            string nuevo = Console.ReadLine();
                            Otraformadeactualizar(nombreviejo, nuevo);
                            Console.WriteLine("Dato actualizado a " + nuevo);
                            resp = Console.ReadLine();
                            break;
                        }

                    case 6:
                        {

                            ConsultaGeneral();
                            Console.WriteLine("Dame un nombre para eliminar");
                            string persona =Console.ReadLine();
                            Eliminar_Perosna2(persona);
                            Console.WriteLine("Persona borrada  " + " ¿  Deseas borrar otro ?");
                            resp = Console.ReadLine();
                            break;
                       
                        }
                }
                Console.WriteLine("Consulta insertada ");
                Console.ReadKey();
            }
        }
        static void ConsultaGeneral()
        {
            using (var context = new ClaseDBcontext())
            {
                var personas = context.Persona.ToList();
                foreach (var per in personas)
                {
                    Console.WriteLine(" id " + per.id + " nombre " + per.nombre);
                }
            }

        }

        static void InsertarPersona(string nom)
        {
            using (var context = new ClaseDBcontext())
            {
                var persona = new Personas();
                persona.nombre = nom;
                context.Add(persona);
                context.SaveChanges();
            }
        }

        static void Actualizar(string nombre, string nuevo)
        {
            using (var context = new ClaseDBcontext())
            {
                var personas = context.Persona.ToList();// consulta general
                personas = context.Persona.Where(x => x.nombre == nombre).ToList();
                personas[0].nombre = nuevo;//Actualiza
                context.SaveChanges();
            }
        }
        static void Eliminar_Perosna(int id)
        {
            using (var context = new ClaseDBcontext())
            {
                var persona = context.Persona.Where(x => x.id == id).FirstOrDefault();
                context.Persona.Remove(persona);
                context.SaveChanges();
            }
        }
        static void Eliminar_Perosna2(string nombre)
        {
            using (var context = new ClaseDBcontext())
            {
                var persona = context.Persona.Where(x => x.nombre == nombre).FirstOrDefault();
                context.Persona.Remove(persona);
                context.SaveChanges();
            }
        }
        static void OTROACTUALIZAR(int ID, string nombre )
        {
            ClaseDBcontext context = new ClaseDBcontext(); //entidad de base de datos
            var oportunidad = context.Persona.Where(l => l.id == ID).FirstOrDefault(); //consultas por ID en la tabla 'lead'
            oportunidad.id = 13;  //actualizas las propiedades de 'oportunidad'
            oportunidad.nombre = nombre;
            context.SaveChanges();  //guardas cambios*/
            /* DatabaseEntities entities = new DatabaseEntities(); //entidad de base de datos
             var oportunidad = entities.lead.Where(l => l.id == oportunidad_id).FirstOrDefault(); //consultas por ID en la tabla 'lead'=
             oportunidad.lead_state_id = 13;  //actualizas las propiedades de 'oportunidad'
             oportunidad.observacion = observacion;
             entities.SaveChanges();  //guardas cambios*/
        }

        static void Otraformadeactualizar(string nombre, string nuevo_nombre)
        {
            using (var context = new ClaseDBcontext())
            {
                //var persona = context.Persona.ToList();
                var persona = context.Persona.Where(x => x.nombre == nombre).FirstOrDefault();
                persona.nombre = nuevo_nombre;
                context.SaveChanges();
            }
        }
        static void Extra()
        {
        }
    }
    class Personas
    {
        public string nombre { set; get;  }
        public int id { set; get; }
    }
}
