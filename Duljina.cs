using System;

public class Duljina
{
    public Tocka A;
    public Tocka B;
    public Duljina(Tocka a, Tocka b)
    {
        A = a;
        B = b;
    }
    public double Duzina()
    {
        double x = A.X - B.X;
        double y = A.Y - B.Y;
        return Math.Sqrt(y * y + x * x);
    }
}