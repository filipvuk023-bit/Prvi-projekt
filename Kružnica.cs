using System;

public class Kruznica : GeometrijskiLik
{
    public Tocka S;
    public double r;

    public Kruznica(Tocka s, double r)
    {
        this.S = s;
        this.r = r;
    }

    public override double Opseg()
    {
        return 2 * r * Math.PI;
    }

    public override double Povrsina()
    {
        return Math.Pow(r, 2) * Math.PI;
    }
}