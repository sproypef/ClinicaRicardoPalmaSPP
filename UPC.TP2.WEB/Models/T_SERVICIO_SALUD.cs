//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPC.TP2.WEB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_SERVICIO_SALUD
    {
        public T_SERVICIO_SALUD()
        {
            this.T_ESPECIALIDAD_SERVICIO = new HashSet<T_ESPECIALIDAD_SERVICIO>();
            this.T_RESERVA_SERVICIO_SALUD = new HashSet<T_RESERVA_SERVICIO_SALUD>();
        }
    
        public int id_servicio { get; set; }
        public string nombre_servicio { get; set; }
        public string tipo_servicio { get; set; }
    
        public virtual ICollection<T_ESPECIALIDAD_SERVICIO> T_ESPECIALIDAD_SERVICIO { get; set; }
        public virtual ICollection<T_RESERVA_SERVICIO_SALUD> T_RESERVA_SERVICIO_SALUD { get; set; }
    }
}
