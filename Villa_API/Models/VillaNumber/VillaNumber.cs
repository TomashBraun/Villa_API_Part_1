using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Villa_API.Models.Villa;


namespace Villa_API.Models.VillaNumberModel
{
    public class VillaNumber
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None) ]
        [Required]
        public int VillaNo { get; set; }
        public string? SpecialDetails { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        //public int? VillaId { get; set; }

        //[ForeignKey("VillaId")]
        //public Villa.Villa? Villa { get; set; }

        [ForeignKey("Villa")]
        [Required]
        public int VillaId { get; set; }

        [Required]
        public Villa.Villa Villa { get; set; }


    }
}


