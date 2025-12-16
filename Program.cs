using System;
public class Program
{
    public static void Main(string[] args)
    {
        Tocka a = new Tocka(0, 0);
        Tocka b = new Tocka(3, 4);
        Duljina ab = new Duljina(a, b);
        Console.WriteLine(ab.Duzina());
    }
}