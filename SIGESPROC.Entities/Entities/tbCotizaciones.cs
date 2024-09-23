﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIGESPROC.Entities.Entities
{
    public partial class tbCotizaciones
    {
        public tbCotizaciones()
        {
            tbCotizacionesDetalle = new HashSet<tbCotizacionesDetalle>();
            tbCotizacionesPorDocumentos = new HashSet<tbCotizacionesPorDocumentos>();
        }

        public int coti_Id { get; set; }
        public int? prov_Id { get; set; }
        public DateTime? coti_Fecha { get; set; }
        public int? empl_Id { get; set; }
        public int? usua_Creacion { get; set; }
        public DateTime? coti_FechaCreacion { get; set; }
        public int? usua_Modificacion { get; set; }
        public DateTime? coti_FechaModificacion { get; set; }
        public bool? coti_Estado { get; set; }
        public decimal? coti_Impuesto { get; set; }
        public bool? coti_Incluido { get; set; }

        [NotMapped]
        public int copd_Id { get; set; }

        [NotMapped]
        public string copd_Documento { get; set; }

        [NotMapped]
        public string copd_Descripcion { get; set; }
        [NotMapped]
        public bool coti_CompraDirecta { get; set; }

        [NotMapped]
        public string venta { get; set; }
        [NotMapped]
        public string medidaORenta { get; set; }
        [NotMapped]
        public int code_Renta { get; set; }

        [NotMapped]
        public string nombreCompleto { get; set; }

        [NotMapped]
        public string prov_Descripcion { get; set; }
        [NotMapped]
        public string fecha { get; set; }

        [NotMapped]
        public string impu_Porcentaje { get; set; }

        [NotMapped]
        public string coti_Documento { get; set; }



        [NotMapped]
        public string empleado { get; set; }

        [NotMapped]
        public string imp { get; set; }

        [NotMapped]
        public int codigo { get; set; }
        [NotMapped]
        public int id { get; set; }
        [NotMapped]
        public int idP { get; set; }
        [NotMapped]
        public string articulo { get; set; }

        [NotMapped]
        public string precio { get; set; }
        [NotMapped]
        public string fechaCreacion { get; set; }

        [NotMapped]
        public string categoria { get; set; }

        [NotMapped]
        public string cantidad { get; set; }


        [NotMapped]
        public string total { get; set; }

        [NotMapped]
        public string subtotal { get; set; }

        [NotMapped]
        public string impuesto { get; set; }

        [NotMapped]
        public int unme_Id { get; set; }

        [NotMapped]
        public string medida { get; set; }

        [NotMapped]
        public int unidad { get; set; }

        [NotMapped]
        public int code_Id { get; set; }

        [NotMapped]
        public bool agregadoACotizacion { get; set; }


        public virtual tbEmpleados empl { get; set; }
        public virtual tbProveedores prov { get; set; }
        public virtual tbUsuarios usua_CreacionNavigation { get; set; }
        public virtual tbUsuarios usua_ModificacionNavigation { get; set; }
        public virtual ICollection<tbCotizacionesDetalle> tbCotizacionesDetalle { get; set; }
        public virtual ICollection<tbCotizacionesPorDocumentos> tbCotizacionesPorDocumentos { get; set; }
    }
}