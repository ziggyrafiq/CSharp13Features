namespace CSharp13Features;

public class Numbers
{
    public static string CalculateHardwired()
    {
        Func<int, int, (int sum, int product)> calculate = (a, b) => (a + b, a * b);
        
        var result = calculate(47, 13);
        
        return $"Total: {result.sum}, Product: {result.product}";
    }
}
