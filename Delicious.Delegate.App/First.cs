namespace Delicious.Delegate.App;

public class First
{
    delegate void MyDelegate(int a, int b);


    void Sum(int a, int b)
    {
        Console.WriteLine($"first number: {a} and second number : {b}");
        Console.WriteLine($"Sum numbers: {a+b}");
    }

    void Minus(int a, int b)
    {
        Console.WriteLine($"first number: {a} and second number : {b}");
        Console.WriteLine($"Minus numbers: {a-b}");
        
    }
    void Divide(int a, int b)
    {
        Console.WriteLine($"first number: {a} and second number : {b}");
        Console.WriteLine($"Minus numbers: {a/b}");
        
    }
    public void Run()
    {
        
        //Type of definition delegate
        //MyDelegate myDelegate = new MyDelegate(Sum);    
        MyDelegate myDelegate = Sum; 
        
     //   myDelegate(10, 15);

        myDelegate += Minus;
       // myDelegate(100, 50);
        
        myDelegate += Divide;
        
        //For don't run sum added bottom code
        //myDelegate -= Sum;
        
        myDelegate(100, 50);
        // if method ( sum ,minus, divide )  returned value just print  last delegate method 
        Console.ReadKey();
    }
}