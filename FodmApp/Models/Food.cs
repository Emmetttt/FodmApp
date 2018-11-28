using System.ComponentModel.DataAnnotations;

namespace FodmApp.Models
{
    public class Food
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public FoodType Type { get; set; }
    }
}
