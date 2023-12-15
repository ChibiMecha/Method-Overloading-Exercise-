namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(8,8));
            Console.WriteLine(Add(8.8m,777.7m));
            Console.WriteLine(Add(1m,0m,true));
        }
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static decimal Add(decimal x, decimal y)
    {
        return x + y;
    }
    
    public static string Add(decimal x, decimal y, bool notRich)
    {
        if (notRich && (x + y) >1)
        {
            return $"You have {x+y} dollars";
        }
        else if (notRich && (x + y) ==1)
        {
            return $"You have {x+y} dollar";
        }
        else
        {
            return $"YOU BROKE MY FRIEND!!!!";
        }

    }
    }
}
