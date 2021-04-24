using System.ComponentModel.DataAnnotations;

namespace ECommerce.Shared
{
    public class BrandCreateRequest
    {
        [Required]
        public string Name { get; set; }
    }
}
