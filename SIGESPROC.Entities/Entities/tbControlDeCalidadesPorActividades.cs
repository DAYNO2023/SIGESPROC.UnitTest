﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbControlDeCalidadesPorActividades
    {
        public tbControlDeCalidadesPorActividades()
        {
            tbImagenesPorControlesDeCalidades = new HashSet<tbImagenesPorControlesDeCalidades>();
        }

        [NotMapped]
        public int coac_Id { get; set; }

        [NotMapped]
        public int codigo { get; set; }
        public int coca_Id { get; set; }
        public string coca_Descripcion { get; set; }
        public DateTime coca_Fecha { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime coca_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? coca_FechaModificacion { get; set; }
        public bool? coca_Estado { get; set; }

        public int? acet_Id { get; set; }
        public decimal? coca_MetrosTrabajados { get; set; }

        [NotMapped]
        public bool? coca_Aprobado { get; set; }
        [NotMapped]
        public decimal? coca_CantidadTrabajada { get; set; }

        public string coca_Resultado { get; set; }
        [NotMapped]
        public string acti_Descripcion { get; set; }
        [NotMapped]
        public int acet_Cantidad { get; set; }
        [NotMapped]
        public string usuaCreacion { get; set; }
        [NotMapped]
        public int etap_Id { get; set; }
        [NotMapped]
        public int etpr_Id { get; set; }
        [NotMapped]
        public string etap_Descripcion { get; set; }
        [NotMapped]
        public int proy_Id { get; set; }
        [NotMapped]
        public string proy_Descripcion { get; set; }
        [NotMapped]
        public string proy_Nombre { get; set; }
        [NotMapped]
        public string proy_FechaInicio { get; set; }
        [NotMapped]
        public string proy_FechaFin { get; set; }
        [NotMapped]
        public string usuaModificacion { get; set; }

        public virtual tbActividadesPorEtapas acet { get; set; }
        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
        public virtual ICollection<tbImagenesPorControlesDeCalidades> tbImagenesPorControlesDeCalidades { get; set; }
    }
}