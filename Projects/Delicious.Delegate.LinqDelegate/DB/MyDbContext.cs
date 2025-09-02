
using Microsoft.EntityFrameworkCore;



namespace Delicious.Delegate.LinqDelegate.DB;

public class MyDbContext:DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
    {
        
    }

    public MyDbContext()
    {


}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Delegate;Integrated Security=true;TrustServerCertificate=True;Application Name=Delicious Delegate;");
        }
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Product> Products { get; set; }
}

public static class SeedData
{
    public static void Initialize(MyDbContext context)
    {
        try
        {
            if (!context.Persons.Any())
            {
                context.Persons.AddRange(
                    new Person {  Name  = "Alice" },
                    new Person {  Name = "Bob" }
                );
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product {  Title = "Coffee",Price = 10},
                    new Product {  Title = "Tea",Price = 20}
                );
            }

            context.SaveChanges();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }
}

