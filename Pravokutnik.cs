    public class Pravokutnik : GeometrijskiLik
    {
    public Tocka a;
    public Tocka b;
    public Tocka c;
    public Tocka d;
    public Duljina ab;
    public Duljina bc;
    public Duljina cd;
    public Duljina da;
    public Pravokutnik(Tocka a, Tocka c)
    {
        this.a = a;
        this.c = c;
        this.b = new Tocka(c.X, a.Y);
        this.d = new Tocka(a.X, c.Y);

        ab = new Duljina(this.a, this.b);
        bc = new Duljina(this.b, this.c);
        cd = new Duljina(this.c, this.d);
        da = new Duljina(this.d, this.a);
    }

    public override double Opseg()
    {
        return ab.Duzina() + bc.Duzina() + cd.Duzina() + da.Duzina();
    }

    public override double Povrsina()
    {
        return ab.Duzina() * bc.Duzina();
    }
}
