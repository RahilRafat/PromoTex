using System.ComponentModel.DataAnnotations.Schema;

namespace PromoTex.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public bool IsAvailable { get; set; } = true;
        public string? Brand { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }



        public int StoreId { get; set; }
        public Store Store { get; set; }

        public string UserId { get; set; }
        [NotMapped]
        public ApplicationUser User { get; set; }

    }
}
