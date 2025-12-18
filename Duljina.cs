using System;

public class Duljina
{
    public Tocka A;
    public Tocka B;
    public Duljina(Tocka a, Tocka b)
    {
        this.A = a;
        this.B = b;
    }
    public double Duzina()
    {
        double x = B.X - A.X;
        double y = B.Y - A.Y;
        return Math.Sqrt(y * y + x * x);
    }
}