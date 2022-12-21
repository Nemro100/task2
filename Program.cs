// See https://aka.ms/new-console-template for more information


using System.Drawing;

Console.WriteLine("enter number");
double number = double.Parse(Console.ReadLine());


for (double i = 1; i <= number; i++)
{

    
    if (prime(i))
    {
       
        Console.WriteLine(" prime number >>>>> {0} ",i);
    }
    
}
static bool prime(double n)
{
   
    if (n == 1 || n == 0) return false ;

    
    for (double i = 2; i < n; i++)
    {
       
        if (n % i == 0) return false;
    }
    
    return true;
}


