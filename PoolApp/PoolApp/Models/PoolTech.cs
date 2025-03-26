using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PoolApp.Models
{
    public class PoolTech : IdentityUser
    {
        [Required]
        public string FullName { get; set; }

        public ICollection<ServiceRecord> ServiceRecords { get; set; }
    }
}
