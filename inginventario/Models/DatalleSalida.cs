//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace inginventario.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DatalleSalida
    {
        public int id_detalle { get; set; }
        public int id_stock { get; set; }
        public int cantidad { get; set; }
        public int id_orden { get; set; }
    
        public virtual OrdenSalida OrdenSalida { get; set; }
        public virtual ProductoBodega ProductoBodega { get; set; }
    }
}
