using System;
public class Program
{
    public static void Main(string[] args)
    {
        Tocka a = new Tocka(0, 0);
        Tocka b = new Tocka(0, 4);
        Tocka c = new Tocka(4, 5);
        GeometrijskiLik[] likovi = new GeometrijskiLik[3];
        likovi[0] = new Kruznica(a, 10);
        likovi[1] = new Trokut(a, b, c);
        likovi[2] = new Pravokutnik(a, c);
        for(int i=0; i<3; i++) 
        {
        Console.WriteLine(likovi[i].Povrsina());
        Console.WriteLine(likovi[i].Opseg());
        }
    }
}