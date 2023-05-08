using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda
{
    public class UsuarioRolModelo
    {
        //indentificador del usuario
        public string UsuarioId { get; set; }
        public string UsuarioNombre { get; set; }

        public bool EstaSeleccionado { get; set; }

    }
}