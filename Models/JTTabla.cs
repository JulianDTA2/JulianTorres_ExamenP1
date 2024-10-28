using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JulianTorres_ExamenP1.Models
{
    public class JTTabla
    {
        public int JTTablaId { get; set; }

        [Required]

        [StringLength(50, MinimumLength = 3)]
        public string? JTTablaObjeto { get; set; }
        


        [Range(1, 100)]
        public float JTCostoBruto { get; set; }
        

        public bool JTALaVenta { get; set; }

        [EmailAddress]
        public string? JTEmailAddress { get; set; }
        
        public DateTime JTFecha { get; set; }

        [DisplayName("Precio Locura")]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")] 
        public decimal? JTPVP { get; set; }
    }
}
