
using System.Linq.Expressions;
using Delicious.Delegate.LinqDelegate.DB;

namespace Delicious.Delegate.LinqDelegate;

public class Second
{
    private readonly MyDbContext  _context;

    public Second(MyDbContext context)
    {
        _context = context;
    }

    public void GetPersons()
    {
        try
        {
            var persons =_context.Persons.ToList();
            foreach (var person in persons)
            {
                Console.WriteLine($"Id: {person.Id} Name: {person.Name}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void GetPersonsWithDelegate()
    {
        try
        {
            
            var person = _context.Persons.Where(FuncGetPersonWithIdOne).FirstOrDefault();
                Console.WriteLine($"Id: {person.Id} Name: {person.Name}");

                var result = MyQuery(x=>x.Id==1);
                foreach (var pers in result)
                {
                  Console.WriteLine($"Id: {person.Id} Name: {person.Name}");
                    
                }

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private bool FuncGetPersonWithIdOne(Person person)
    {
        
        //Get All data from database and in program set where
        if (person.Id == 1)
            return true;
        
        return false;
    }

    IEnumerable<Person> MyQuery(Expression<Func<Person,bool>> func)
    {
        
        //with Expression run set Where in database 
        using (var context = new MyDbContext())
        {
            var query=context.Persons.Where(func).ToList();
            return query;
        }
    }
    
    
}