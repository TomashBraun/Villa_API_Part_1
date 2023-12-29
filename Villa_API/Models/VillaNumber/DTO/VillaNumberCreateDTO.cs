using System.ComponentModel.DataAnnotations;

namespace Villa_API.Models.VillaNumberModel
{
    public class VillaNumberCreateDTO
    {
        [Required]
        public int VillaNo { get; set; }
        public string SpecialDetails { get; set; }
        
        [Required]
        public int VillaId { get; set; }
    }
}
