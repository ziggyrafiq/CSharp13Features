namespace CSharp13Features;
public  class Tuples
{
    public static void DeconstructTuple()
    {
        var tuple = (1, "Dummay Eample");
        var (number, word) = tuple;
        Console.WriteLine($"{number}, {word}");
    }

}
