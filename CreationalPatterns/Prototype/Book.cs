namespace CreationalPatterns.Prototype;
public class Book: ICloneable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public object Clone()
    {
        return this.MemberwiseClone();

    }

    public override string ToString()
    {
        return $"{nameof(Title)}: {Title}, {nameof(Author)}: {Author}, {nameof(Pages)}: {Pages}";
    }
}