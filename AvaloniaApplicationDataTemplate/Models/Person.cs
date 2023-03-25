namespace AvaloniaApplicationDataTemplate.Models;

public abstract class Person
{
    public string FirstName { get; init; } = "Noname";
    public string LastName { get; init; } = "Nolastname";
    public int Age { get; init; } = 0;
    public Sex Sex { get; init; } = Sex.Diverse;

    public override string ToString()
    {
        return $"{FirstName} {LastName} (age {Age}, sex: {Sex})";
    }
}