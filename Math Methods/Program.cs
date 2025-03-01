namespace Math_Methods;

class Program
{
    static void Main(string[] args)
    {
        int mySum = Sum(5, 6);
        int myDifference = Difference(92, 43);
        int myProduct = Product(10, 20);
        int myQuotient = Quotient(100, 20);
        
        Console.WriteLine($"Sum:\t\t{mySum}");
        Console.WriteLine($"Difference:\t{myDifference}");
        Console.WriteLine($"Product:\t{myProduct}");
        Console.WriteLine($"Quotient:\t{myQuotient}");
    }

    public static int Sum(int firstNum, int secondNum)
    {
        return firstNum + secondNum;
    }
    
    public static int Difference(int firstNum, int secondNum)
    {
        return firstNum - secondNum;
    }
    
    public static int Product(int firstNum, int secondNum)
    {
        return firstNum * secondNum;
    }
    
    public static int Quotient(int firstNum, int secondNum)
    {
        return firstNum/secondNum;
    }
}