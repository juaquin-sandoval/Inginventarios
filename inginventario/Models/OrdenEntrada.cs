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
    
    public partial class OrdenEntrada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdenEntrada()
        {
            this.DetalleEntrada = new HashSet<DetalleEntrada>();
        }
    
        public int id_orden { get; set; }
        public System.DateTime fecha { get; set; }
        public int id_user { get; set; }
        public string comentario { get; set; }
        public int num_factura { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleEntrada> DetalleEntrada { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
