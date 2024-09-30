namespace SolidPrinciples.SingleResponsibilityPrinciple;
//Wydzielenie do osobnej klasy adresu mailowego powoduje zachowanie SRP
// - kontrakt budowy adresu zawarty jest w osobnej klasie,
// - zmiana budowy adresu i sposób wyznaczania domenu nie wpłypa na klasy ProperPerson i ProperProducer
// - unikamy potwarzania kodu wydzielania domeny
public class ProperPerson
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public EmailAddress EmailAddress { get; init; }
}

public class ProperProducer
{
    public string  Name { get; init; }
    public EmailAddress EmailAddress { get; init; }
}

public class EmailAddress
{
    public string Address { get; init; }
    public string EmailAddressDomain => Address.Split("@")[1];
}