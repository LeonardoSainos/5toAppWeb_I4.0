//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tarjeta
    {
        public string numero_tarjeta { get; set; }
        public Nullable<int> cvc { get; set; }
        public Nullable<int> cvv { get; set; }
        public Nullable<double> saldo { get; set; }
        public Nullable<System.DateTime> fecha_vencimiento { get; set; }
        public int id_usuarioo { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
