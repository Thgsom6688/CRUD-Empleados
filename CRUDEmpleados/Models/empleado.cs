//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Web;

namespace CRUDEmpleados.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class empleado
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string Nombre { get; set; }
        public string Posicion { get; set; }
        public string Oficina { get; set; }
        public int Salario { get; set; }
        [DisplayName("Imagen")]
        public string RutaImagen { get; set; }

        [NotMapped]
        public HttpPostedFileBase CargaImagen { get; set; }

        public empleado()
        {
            RutaImagen = "~/CargaArchivos/Imagenes/default.png";
        }
    }
}