using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PoolApp.Models
{
    public class ServiceRecord
    {
        public int ID { get; set; }

        [Required]
        public int PoolID { get; set; }

        [Required]
        public string PoolTechID { get; set; }

        [Required]
        public DateTime ServiceDate { get; set; }

        public string Notes { get; set; } // Optional notes on service performed

        [ForeignKey("PoolID")]
        public Pool Pool { get; set; }

        [ForeignKey("PoolTechID")]
        public PoolTech PoolTech { get; set; }
    }
}
