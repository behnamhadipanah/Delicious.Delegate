namespace Delicious.Delegate.App.ParametersDelegate;

public class ParamDelegate
{
  /*  delegate void MyDelegate(int[] array);
    
    
    
    void Test(int[] array)
    {
        int tmp = 0;
        foreach (var item in array)
        {
            tmp += item;
        }

        Console.WriteLine($"temp value is: {tmp}");
    }

    public void Run()
    {
        MyDelegate myDelegate = Test;
        
        myDelegate(new int[] { 1, 2, 3 });
        
        
    }
    */
  
  delegate void MyDelegate(params int[] array);
  delegate void MyDelegate2(ref int num1,int  num2);
  delegate void MyDelegate3( int num2, int num3);
 /* void Test(params int[] array)
  {
      int tmp = 0;
      foreach (var item in array)
      {
          tmp += item;
      }

      Console.WriteLine($"temp value is: {tmp}");
  }*/
    
  void Test(int[] array)
  {
      int tmp = 0;
      foreach (var item in array)
      {
          tmp += item;
      }

      Console.WriteLine($"temp value is: {tmp}");
  }
  //---------------------------------------------------------------------

  void Test2(ref int num1,int num2)
  {
       num1=100;
    

      Console.WriteLine($"sum value is: {num1+num2}");
  }
//---------------------------------------------------------------------

  void Sum(int num1, int num2)
  {
      Console.WriteLine(num1 + num2);
  }

  void Test3(MyDelegate3 sum, int num1, int num2)
  {
      sum(num1, num2);
      Console.WriteLine(num1 * num2);
  }
  
  //---------------------------------------------------------------------

  public void Run()
  {
      MyDelegate myDelegate = Test;
        
      myDelegate( 1, 2, 3 );
       
      MyDelegate2 myDelegate2 = Test2;
      //myDelegate2( 10,20 ); error :  param in delegate and method used ref 
      //correct :

        int a = 10;
        myDelegate2(ref a,20 );
       
        //Send method in param with delegate
      MyDelegate3 myDelegate3 = Sum;
      Test3(myDelegate3, 10,30);
        
  }
}