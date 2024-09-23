﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbAgentesBienesRaices
    {
        public tbAgentesBienesRaices()
        {
            tbProcesosVentas = new HashSet<tbProcesosVentas>();
        }

        public int agen_Id { get; set; }
        public string agen_DNI { get; set; }
        public string agen_Nombre { get; set; }
        public string agen_Apellido { get; set; }
        public string agen_Telefono { get; set; }
        public string agen_Correo { get; set; }
        public int usua_Creacion { get; set; }
        public DateTime agen_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? agen_FechaModificacion { get; set; }
        public bool? agen_Estado { get; set; }
        public int? embr_Id { get; set; }

        [NotMapped]
        public int codigo { get; set; }
        [NotMapped]
        public string embr_Nombre { get; set; }
        [NotMapped]
        public string usuaCreacion { get; set; }
        [NotMapped]
        public string usuaModificacion { get; set; }

        public virtual tbEmpresasBienesRaices embr { get; set; }
        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
        public virtual ICollection<tbProcesosVentas> tbProcesosVentas { get; set; }
    }
}