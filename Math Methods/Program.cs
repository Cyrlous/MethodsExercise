namespace Math_Methods;

class Program
{
    static void Main(string[] args)
    {
        int mySum = Sum(5, 6, 11, 16);
        int myDifference = Difference(253, 43, 67, 11);
        int myProduct = Product(10, 20, 36, 42);
        double myQuotient = Quotient(100, 20, 5, 36);
        
        Console.WriteLine($"Sum:\t\t{mySum:N0}");
        Console.WriteLine($"Difference:\t{myDifference:N0}");
        Console.WriteLine($"Product:\t{myProduct:N0}");
        Console.WriteLine($"Quotient:\t{myQuotient}");
    }

    public static int Sum(params int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
    
    public static int Difference(int firstNumber, params int[] numbers)
    {
        int difference = firstNumber;
        foreach (int number in numbers)
        {
            difference -= number;
        }
        return difference;
    }
    
    public static int Product(int firstNumber, params int[] numbers)
    {
        int product = firstNumber;
        foreach (int number in numbers)
        {
            product *= number;
        }
        return product;
    }
    
    public static double Quotient(double firstNumber, params double[] numbers)
    {
        double quotient = firstNumber;
        foreach (double number in numbers)
        {
            quotient /= number;
        }
        return quotient;
    }
}