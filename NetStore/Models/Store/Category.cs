using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetStore.Models.Store;

[Table("Categories", Schema = "Store")]
public class Category
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    
    [MaxLength(64)] public string Name { get; set; }
    [MaxLength(128)] public string Description { get; set; }
    
}