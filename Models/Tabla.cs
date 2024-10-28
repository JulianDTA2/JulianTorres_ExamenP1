using System.ComponentModel.DataAnnotations;

namespace JulianTorres_ExamenP1.Models
{
    public class Tabla
    {
        public int TablaId { get; set; }
        [Required]
        public string TablaName { get; set;}
        public float TablaValue { get; set; }
        public bool IsTabla { get; set; }
        public DateOnly DateOnly { get; set; }
    }
}
