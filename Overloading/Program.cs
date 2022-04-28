// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args) { }
    
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static decimal Add(decimal a, decimal b)
    {
        return a + b;
    }
    
    public static string Add(int a, int b, bool usd)
    {
        int sum = a + b;
        return sum.ToString() + (usd ? sum == 1 ? " dollar" : " dollars" : "");
    }
    
    public static int Add(params int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers) { sum += number; }
        return sum;
    }
    
    public static double Add(params double[] numbers)
    {
        double sum = 0;
        foreach (double number in numbers) { sum += number; }
        return sum;
    }
}