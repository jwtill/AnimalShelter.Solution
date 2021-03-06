using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AnimalShelter.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        [Required]
        [StringLength(23)]
        public string Name { get; set; }
        [Required]
        [StringLength(10)]
        public string Species { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        [Required]

        [DefaultValue(false)]
        public bool Adopted { get; set; }
    }
}