using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TallerApis.Apis.Models
{
    [Table("tblPublicacion")]
    public class tblPublicacion
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Usuario { get; set; }
        [MaxLength(200)]
        public string Descripcion { get; set; }
        [Required]
        public DateTime FechaPublicacion { get; set; }
        public int MeGusta { get; set; }
        public int MeDisGusta { get; set; }
        public int VecesCompartido { get; set; }
        [Required]
        public bool EsPrivada { get; set; }
    }
}