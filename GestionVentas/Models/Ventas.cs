//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionVentas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ventas
    {
        public int VentaId { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public int Cantidad { get; set; }
        public int Producto_Id { get; set; }
        public int Usuario_Id { get; set; }
        public int Cliente_Id { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Productos Productos { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
