﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbPrestamos
    {
        public tbPrestamos()
        {
            tbAbonosPorPrestamos = new HashSet<tbAbonosPorPrestamos>();
        }

        public int pres_Id { get; set; }
        public decimal pres_Monto { get; set; }
        public string pres_Descripcion { get; set; }
        public string pres_UltimaFechaPago { get; set; }
        public DateTime pres_FechaPrimerPago { get; set; }
        [NotMapped]
        public DateTime fechaUltimoPago { get; set; }
        public int pres_Pagos { get; set; }
        public int? empl_Id { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime pres_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? pres_FechaModificacion { get; set; }
        public bool? pres_Estado { get; set; }
        public int? frec_Id { get; set; }
        public int? pres_PagosRestantes { get; set; }
        [NotMapped]
        public decimal? pres_Abonado { get; set; }
        [NotMapped]
        public decimal? pagosRestantes { get; set; }
        [NotMapped]
        public decimal? total { get; set; }
        [NotMapped]
        public decimal? cuota { get; set; }
        [NotMapped]
        public decimal? interes { get; set; }
        public decimal pres_TasaInteres { get; set; }


        [NotMapped]
        public List<tbAbonosPorPrestamos> abonos { get; set; }
        [NotMapped]
        public string ciud_Descripcion { get; set; }
        [NotMapped]
        public string codigo { get; set; }
        [NotMapped]
        public string empleado { get; set; }
        [NotMapped]
        public string empl_DNI { get; set; }
        [NotMapped]
        public string esta_Nombre { get; set; }
        [NotMapped]
        public string frec_Descripcion { get; set; }

        [NotMapped]
        public string pais_Nombre { get; set; }

        [NotMapped]
        public string usuaCreacion { get; set; }
        [NotMapped]
        public string usuaModificacion { get; set; }

        public virtual tbEmpleados empl { get; set; }
        public virtual tbFrecuencias frec { get; set; }
        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
        public virtual ICollection<tbAbonosPorPrestamos> tbAbonosPorPrestamos { get; set; }
    }
}