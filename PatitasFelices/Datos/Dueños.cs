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
    
    public partial class Dueños
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dueños()
        {
            this.Mascotas = new HashSet<Mascotas>();
        }
    
        public int DueñoId { get; set; }
        public string NombreCompleto { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string NumeroTelefonico { get; set; }
        public Nullable<int> UsuarioId { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mascotas> Mascotas { get; set; }
    }
}
