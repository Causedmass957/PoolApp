using System.ComponentModel.DataAnnotations;

namespace PoolApp.Models
{
    public class Pool
    {
        public int ID { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string client { get; set; } = null;
        [Required]
        public DateTime recentServiceDate { get; set; }
        [Required]
        public DateTime nextServiceDate { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Not a valid measurement")]
        public int chlorineLevel { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Not a valid measurement")]
        public int alkalinityLevel { get; set; }
        public bool recentVac { get; set; }
    }
}
