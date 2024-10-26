using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NetStore.Models.Store;

[Table("Products", Schema = "Store")]
public class Product
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    
    [MaxLength(128)]
    public string Title { get; set; }
    
    [MaxLength(1024)]
    public string Description { get; set; }

    [Precision(8,2)]
    public decimal BasePrice { get; set; }

    public UInt16 DiscountPercentage { get; set; } = 0;
    
    public List<ProductImage> Images { get; set; }
    
    public int Stock { get; set; }

    [NotMapped]
    public bool IsAvailable => Stock > 0;

    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}