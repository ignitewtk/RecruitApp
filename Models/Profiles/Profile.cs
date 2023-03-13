using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitApp.Models.Profiles
{
    public class Profile
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Name { get; set; }

        public DateTime ModifiedDate { get; set; }
        
        public string? Description { get; set; }

        [Range(1, 1000000)]
        [DataType(DataType.Currency)]
        public decimal? ExpectSalary { get; set; }

        public decimal? SuperannuactionRate { get; set; }
    }
}
