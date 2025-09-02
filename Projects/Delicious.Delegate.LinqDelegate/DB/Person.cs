using System.ComponentModel.DataAnnotations;

namespace Delicious.Delegate.LinqDelegate.DB;

public class Person
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    
}