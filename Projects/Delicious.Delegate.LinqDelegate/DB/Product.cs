using System.ComponentModel.DataAnnotations;

namespace Delicious.Delegate.LinqDelegate.DB;

public class Product
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public int Price { get; set; }
}