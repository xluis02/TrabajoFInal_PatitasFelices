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
    
    public partial class HistorialConsultas
    {
        public int HistorialId { get; set; }
        public Nullable<int> MascotaId { get; set; }
        public System.DateTime FechaConsulta { get; set; }
        public string Alergias { get; set; }
        public string Operaciones { get; set; }
        public string Tratamientos { get; set; }
        public string Enfermedades { get; set; }
        public string DescripcionConsulta { get; set; }
        public Nullable<int> VeterinarioId { get; set; }
    
        public virtual Mascotas Mascotas { get; set; }
        public virtual Veterinarios Veterinarios { get; set; }
    }
}