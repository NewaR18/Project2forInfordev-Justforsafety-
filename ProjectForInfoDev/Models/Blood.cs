using System.ComponentModel.DataAnnotations;

namespace ProjectForInfoDev.Models
{
    public class Blood
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string HospitalName { get; set; }
        public int Apositive { get; set; }
        public int Anegative { get; set; }
        public int Bpositive { get; set; }
        public int Bnegative { get; set; }
        public int ABpositive { get; set; }
        public int ABnegative { get; set; }
        public int Opositive { get; set; }
        public int Onegative { get; set; }
        [StringLength(30)]
        public string LastReviewed { get; set; }
    }
}
