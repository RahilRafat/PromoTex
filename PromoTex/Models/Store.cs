using System.ComponentModel.DataAnnotations.Schema;

namespace PromoTex.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string StoreName { get; set; }
        public string Description { get; set; }
        public string? LogoUrl { get; set; }
        public bool IsVerified { get; set; } = false;

        public string UserId { get; set; }
        [NotMapped]
        public ApplicationUser User { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
