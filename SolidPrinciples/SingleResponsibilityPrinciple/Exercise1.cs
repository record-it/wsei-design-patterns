namespace SolidPrinciples.SingleResponsibilityPrinciple;
//Dlaczego klasa GenderPerson narusza SRP?
//Popraw klasę, aby zachowac SRP


public class GenderPerson
{
    public string FirstName { get; set; }
    public DateTime Birthday { get; set; }
    public Gender Gender => FirstName.EndsWith("a") ? Gender.Female : Gender.Male;
}

public enum Gender
{
    Female, Male, Other
}