using System;
public class Program
{
    public static void Main(string[] args)
    {
        Tocka a = new Tocka(0, 0);
        Tocka b = new Tocka(1, 3);
        Tocka c = new Tocka(2, 4);
        Duljina ab = new Duljina(a, b);
        Trokut trokut = new Trokut(a, b, c);
        Kruznica k = new Kruznica(a, 10);   
        Console.WriteLine(ab.Duzina());
    }
}