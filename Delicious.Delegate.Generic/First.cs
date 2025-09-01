namespace Delicious.Delegate.Generic;

public class First
{
    delegate TResult MyDelegate<T1,T2,TResult>(T1 arg1, T2 arg2);
    
    

    public void Run()
    {
        MyDelegate<int, double, double> dlg1 = delegate(int a, double b)
        {
            return a / b;
        };
        double result=dlg1(10,2);

        Console.WriteLine($"result is {result}");
        Console.WriteLine("******************************************");
        //default delegate microsoft
        
        //Func with result 
       Func<int, double, double> dlg2 = delegate(int a, double b)
        {
            return a / b;
        };
       // Func<int, double, double> dlg2 =(a,b)=> a / b;
         result=dlg2(10,2);
        Console.WriteLine($"result is {result}");
        Console.WriteLine("******************************************");
        
        // Func without parameter
        Func<string> dlg3 = ()=>"without parameter";
        
        //Action without result
        
        Action<string> dlg4 = x=>Console.WriteLine("default delegate without result ");
        dlg4("action");
        
        //Predicate with one parameter and result is boolean
       // Predicate<int> dlg5 = x => x % 2 == 0;
       //Func<int,bool> dlg5 = PredicateMethod;
       //bool predicateDelegate=dlg5(10);
        
       Predicate<int> dlg5 = x => x % 2 == 0;
        bool predicateDelegate=dlg5(10);
        Console.WriteLine($"predicateDelegate  is {predicateDelegate}");
        
        Console.ReadKey();

    }

    bool PredicateMethod(int param)
    {
        return param % 2 == 0;
    }
}