//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdministradorDeSazon.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Adm_Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adm_Usuarios()
        {
            this.Adm_Negocios = new HashSet<Adm_Negocios>();
        }
    
        public System.Guid AIDUsuario { get; set; }
        public string ACorreoElectronico { get; set; }
        public string ANombreUsuario { get; set; }
        public string ANombre { get; set; }
        public short ANacimientoAgno { get; set; }
        public byte ANacimientoMes { get; set; }
        public string AAvatar { get; set; }
        public Nullable<System.Guid> AIDUsuarioPadre { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public Nullable<System.DateTime> FechaUltimaSesion { get; set; }
        public string Rol { get; set; }
        public short Permiso { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adm_Negocios> Adm_Negocios { get; set; }
    }
}
