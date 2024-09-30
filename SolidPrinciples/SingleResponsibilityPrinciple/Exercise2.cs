namespace SolidPrinciples.SIngleResponsibilityPrinciple;
//Dana jest klasa opisująca produkt (Title, Price)
//Podatek aktualnie dla tego produktu wynosi 20%, ale w każdej chwili może się zmienić
//Podatek nie jest cechą produktu, reguły obliczania podatku mogą się zmieniać
//(np. zamiast 20% ceny może być wynosić 0 dla cena  poniżej jakiegoś progu).
//Zaproponuj zmiany w klasie Product oraz nową klasę, aby przywrócić SRP - jedynym powodem zmiany w klasie Product jest zmiana 
//opisu produktu.
public class Product
{
    public string Title { get; init; }
    public decimal Price { get; init; }
    public decimal Tax => Price * 0.2m;
}