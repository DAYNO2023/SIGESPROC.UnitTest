﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbEmpleados_Bitacora
    {
        public int empl_Id { get; set; }
        public string empl_DNI { get; set; }
        public string empl_Nombre { get; set; }
        public string empl_Apellido { get; set; }
        public string empl_CorreoElectronico { get; set; }
        public string empl_Telefono { get; set; }
        public string empl_Sexo { get; set; }
        public DateTime empl_FechaNacimiento { get; set; }
        public decimal? empl_Salario { get; set; }
        public int ciud_Id { get; set; }
        public int civi_Id { get; set; }
        public int carg_Id { get; set; }
        public int? usua_Creacion { get; set; }
        public DateTime? empl_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? empl_FechaModificacion { get; set; }
        public bool? empl_Estado { get; set; }
        public int? frec_Id { get; set; }
        public string empl_NoBancario { get; set; }
        public int? banc_Id { get; set; }
        public string empl_Imagen { get; set; }
        public string empl_ObservacionActivar { get; set; }
        public string empl_ObservacionInactivar { get; set; }
        public decimal? empl_Prestaciones { get; set; }
        public decimal? empl_OtrasRemuneraciones { get; set; }
        public string accion { get; set; }
    }
}