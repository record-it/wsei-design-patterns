namespace SolidPrinciples.LiskovPrinciple;

public class Rectangle
{
    public double Width { get;  set; }
    public double Height { get;  set; }
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public override string ToString() => $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
}

public class Square : Rectangle
{
    public Square(double side) : base(side, side){}
}

public class LiskovDemo
{
    public static void Run()
    {
        Rectangle[] shapes = new Rectangle[2];
        shapes[0] = new Rectangle(10, 20) ;
        shapes[1] = new Square(40);
        //zmiana wysokości wszystkich wymiarów figur
        foreach (var shape in shapes)
        {
            if (shape is Rectangle)
            {
                shape.Height = 30;
            }
            //musimy dowiedzieć się czy shape jest kwadratem, bo wtedy musimy zmienić oba wymiary
            if (shape is Square)
            {
                shape.Height = 30;
                shape.Width = 30;
            }
            Console.WriteLine(shape);
        }
    }
}