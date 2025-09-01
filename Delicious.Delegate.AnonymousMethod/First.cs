namespace Delicious.Delegate.AnonymousMethod;

public class First
{
    delegate int MyDelegate(int a, int b);
    delegate void MyDelegate2();

    public void Run()
    {
        MyDelegate dlg = delegate(int a, int b)
        {
            return a + b;
        };
        
        int result=dlg(100, 20);
        Console.WriteLine($"dlg value is : {result}");
        
        //MyDelegate dlg2=(x,y)=>x*y;
        MyDelegate dlg2=(x,y)=>
        {
            x = x + x;
            return x * y;
        };
        result=dlg2(100, 20);
        Console.WriteLine($"dlg2 value is : {result}");


        //MyDelegate2 dlg3 = ()=>Console.WriteLine("dlg3");
        MyDelegate2 dlg3 = ()=>
        {
            string name = "testing";
            Console.WriteLine($"dlg3 {name}");
        };
        dlg3();
        
        Console.ReadKey();
    }
}