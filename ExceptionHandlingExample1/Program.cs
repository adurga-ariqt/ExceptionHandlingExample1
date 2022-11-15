// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
  try
  { 
    int a, b, c;
    Console.WriteLine("Enter a value:");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter b value:");
    b = Convert.ToInt32(Console.ReadLine());
    c = a / b;
    Console.WriteLine("Result is :"+ c);
   
    int d, e, f;
    Console.WriteLine("Enter d value:");
    d = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter e value:");
    e= Convert.ToInt32(Console.ReadLine());
    f = d / e;
    Console.WriteLine("Result is :"+f);
    Console.ReadLine();


}


   catch (DivideByZeroException)
   {
    Console.WriteLine("b must be not 0");
    }
    catch (FormatException)
    {
    Console.WriteLine("b must be an number");
    }
finally
{
    Console.WriteLine("this is the final block");
}

   
