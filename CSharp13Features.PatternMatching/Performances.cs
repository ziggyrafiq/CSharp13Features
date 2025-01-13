namespace CSharp13Features;
public class Performances
{
    public static void ProcessStackOnlyStruct()
    {
        var stackStruct = new StackOnlyStruct(10);
        Console.WriteLine(stackStruct.X);
    }

    public int AddNumbers(int a, int b) => a + b;

    public int MultiplyNumbers(int a, int b) => a * b;

}
