namespace SolidPrinciples.SingleResponsibilityPrinciple;
//Obie klasy zwierają pole z adresem mailowym
//Celem każdej klasy jest gromadzenie aby udostępniać informacje o osobie i firmie
//Klasy naruszają zasadę  SRP, bo zwracają szczegóły budowy adresu, który nie leży w odpowiedzialności klasy
//Jeśli zmienią się reguły budowy adresu, to należy zmieniać wszystkie klasy posiadające pole EmailAdress
//Jedynym powodem zmiany klasy jest np. dodanie nowej informacji o osobie lub zmiana formy jej udostepniania
//Często naruszanie jednej reguly powoduje naruszenie innej, w tym przypadku to DRY,  w obu klasach powtarza się ten sam kod 
//dostępu do 
public class InvalidExample
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string EmailAddress { get; init; }

    public string EmailAddressDomain => EmailAddress.Split("@")[1];
}

public class Producer
{
    public string  Name { get; init; }
    public string EmailAddress { get; init; }

    public string EmailAddressDomain => EmailAddress.Split("@")[1];
}