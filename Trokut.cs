using System;

public class Trokut : GeometrijskiLik
{
    public Tocka a;
    public Tocka b;
    public Tocka c;

    public double s;

    public Duljina ab;
    public Duljina bc;
    public Duljina ca;
    public Trokut (Tocka a, Tocka b, Tocka c)
    {
        this.a = a;
        this.b = b;
        this.c = c;

        this.ab = new Duljina (this.a, this.b);
        this.bc = new Duljina(this.b, this.a);
        this.ca = new Duljina(this.a, this.c);
    }
    public bool Jednakostranican()
    {
    return ab.Duzina() == bc.Duzina() && bc.Duzina() == ca.Duzina();
    }  
    public bool Jednakokracan()
    {
        return ab.Duzina() == bc.Duzina() ||
                bc.Duzina() == ca.Duzina() ||
                ca.Duzina() == ab.Duzina();
    }
    public bool Pravokutan()
    {
        return Math.Round(Math.Pow(ab.Duzina(), 2),2) == Math.Round(Math.Pow(ca.Duzina(), 2), 2) + Math.Round(Math.Pow(bc.Duzina(), 2), 2) ||
            Math.Round(Math.Pow(bc.Duzina(), 2), 2) == Math.Round(Math.Pow(ca.Duzina(), 2), 2) + Math.Round(Math.Pow(ab.Duzina(), 2), 2) ||
            Math.Round(Math.Pow(ca.Duzina(), 2), 2) == Math.Round(Math.Pow(bc.Duzina(), 2), 2) + Math.Round(Math.Pow(ab.Duzina(), 2), 2);
    }
    public override double Opseg()
    {
        return ab.Duzina() + bc.Duzina() + ca.Duzina();
    }

    public override double Povrsina()
    {
        s = Opseg() / 2;
        return Math.Sqrt(s * (s-ab.Duzina()) * (s - bc.Duzina()) * (s - ca.Duzina()));
    }
}