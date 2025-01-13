namespace CSharp13Features;
public class Nullables
{
    #nullable enable
    public string? Detials { get; set; }

    #nullable disable
    public string GetNonNullableString()
    {
        return "Hi This is no Nullable"; // Here there is no nullable warning.
    }

}
