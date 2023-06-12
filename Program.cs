Console.WriteLine("Hello, World!");

Point punto = new Point();
Console.WriteLine(punto.X);
Console.WriteLine(punto.Y);

public struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y) 
    {
        X = x;
        //Y = y;
    }
}



