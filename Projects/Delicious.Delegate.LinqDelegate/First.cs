namespace Delicious.Delegate.LinqDelegate;

public class First
{

    public void Run()
    {
    List<int> numbers = new List<int>(){1,2,3,4,3,5,6,7,3,8,9,3};
    var query = numbers.Where(x => x == 3);
    
    Func<int, bool> myFunc = Test;
    /*var query2 = numbers.Where(myFunc);
    foreach (var item in query2)
    {
        Console.WriteLine(item);
    }*/
    //Best practice: with .toList run all query then return to program
    var query2 = numbers.Where(myFunc).ToList();
    Console.WriteLine("********************************");
    
    //query 3 check index with number is equal
    //var query3 = numbers.Where((x,y) => x==y);
    var query3 = numbers.Where(TestQuery3);
    Console.WriteLine(query3);
    Console.WriteLine("********************************");

    var query4 = numbers.Any(Test);
    var query5 = numbers.Count(Test);
    
    Console.ReadKey();
    }

    bool TestQuery3(int x, int y)
    {
        if (x == y)
            return true;
        return false;
    }
    bool Test(int number)
    {
        if (number == 3)
            return true;
        return false;

    }
}