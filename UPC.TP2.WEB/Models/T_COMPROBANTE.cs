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
    
    public partial class T_COMPROBANTE
    {
        public int id_comprobante { get; set; }
        public string numero { get; set; }
        public string descripcion { get; set; }
        public System.DateTime fecha_emision { get; set; }
        public Nullable<System.DateTime> fecha_pago { get; set; }
        public Nullable<int> moneda { get; set; }
        public Nullable<int> importe { get; set; }
        public Nullable<int> impuesto { get; set; }
        public string area_venta { get; set; }
        public decimal total { get; set; }
        public int codPersona { get; set; }
    
        public virtual T_PERSONA T_PERSONA { get; set; }
    }
}
