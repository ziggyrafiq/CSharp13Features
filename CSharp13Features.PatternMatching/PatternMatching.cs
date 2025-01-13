namespace CSharp13Features.PatternMatching;

public static class PatternMatching
{
    public static string MatchListPattern(List<int> numbers)
    {
        return numbers switch
        {
        [1, 2, 3] => "We have found 1, 2, and 3",
        [int x, int y, ..] => $"We have found first two numbers: {x} and {y}",
        [.., int z] => $"The Last number we have found is {z}",
            _ => "The Pattern not matched sorry !"
        };
    }

    public static string MatchPerson(Person person)
    {
        return person switch
        {
            { FirstName: "Lisa", Age: 30 } => "Lisa  is 28 years old",
            { Age: < 18 } => "Underage person",
            { FullName: var fullName } => $"Person's name is {fullName}",
            _ => "Unknown person"
        };
    }


}
