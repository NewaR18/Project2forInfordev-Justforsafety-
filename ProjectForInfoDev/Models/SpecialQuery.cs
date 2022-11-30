using System.ComponentModel.DataAnnotations;

namespace ProjectForInfoDev.Models
{
    public class SpecialQuery
    {
        [Key]
        [Required]
        public int SpecialId { get; set; }
        [Required]
        [StringLength(50)]
        public string SpecialName { get; set; }
        [Required]
        [StringLength(50)]
        public string SpecialEmail { get; set; }
        [Required]
        [StringLength(50)]
        public string SpecialAddress { get; set; }
        public string SpecialMessage { get; set; }
    }
}
