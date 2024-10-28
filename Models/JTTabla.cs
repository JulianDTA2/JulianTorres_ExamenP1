using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JulianTorres_ExamenP1.Models
{
    public class JTTabla
    {
        public int JTTablaId { get; set; }

        [Required]

        [StringLength(50, MinimumLength = 3)]
        public string? JTTablaName { get; set; }
        


        [Range(1, 100)]
        public float JTTablaValue { get; set; }
        

        public bool JTIsTabla { get; set; }

        [EmailAddress]
        public string? JTEmailAddress { get; set; }
        
        public DateTime JTFecha { get; set; }

        [DisplayName("Price")]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")] 
        public decimal? JTTablaPrice { get; set; }
    }
}
