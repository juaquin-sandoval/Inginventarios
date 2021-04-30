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
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.DetalleEntrada = new HashSet<DetalleEntrada>();
            this.ProductoBodega = new HashSet<ProductoBodega>();
        }
    
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public string codigo { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<int> precio { get; set; }
        public string comentario { get; set; }
        public int id_proveedor { get; set; }
        public int id_categoria { get; set; }
        public int id_marca { get; set; }
        public int id_user { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleEntrada> DetalleEntrada { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductoBodega> ProductoBodega { get; set; }
    }
}
