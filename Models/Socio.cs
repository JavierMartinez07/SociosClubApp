using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SociosClubApp.Models
{
    public class Socio
    {
        [ScaffoldColumn(false)]
        public int SocioId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Cedula { get; set; }
        public string Imagen { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Celular { get; set; }
        public string Fax { get; set; }
        [Required]
        public TipoSexo Sexo { get; set; }
        [Required]
        public int Edad { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaNac { get; set; }
        [Required]
        [Display(Name ="Tipo Membresia")]
        public TipoM TipoMembresia { get; set; }
        [Display(Name ="Lugar de Trabajo")]
        public string LugarTrabajo { get; set; }
        [Display(Name ="Direccion Oficina")]
        public string DireccionOficina { get; set; }
        [Display(Name ="Telefono Oficina")]
        public string TelefonoOficina { get; set; }
        [Required]
        public bool Estado { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Fecha Ingreso")]
        public DateTime FechaIngreso { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Fecha Salida")]
        public DateTime FechaSalida { get; set; }
    }

    public enum TipoM
    {
        Gratis, Normal, Premiun
    }

    public enum TipoSexo
    {
        Hombre, Mujer
    }
}
