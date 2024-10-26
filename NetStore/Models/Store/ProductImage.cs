using System.ComponentModel.DataAnnotations.Schema;

namespace NetStore.Models.Store;

[Table("ProductImages", Schema = "Store")]
public class ProductImage
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public string ImageUrl { get; set; }

    public Guid ProductId { get; set; }
    public Product Product { get; set; }
}