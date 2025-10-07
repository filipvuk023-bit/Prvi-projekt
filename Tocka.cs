using System;

public class Tocka
{
    public double X;
    public double Y;

    public Tocka()
    {
        this.X = 0;
        this.Y = 0;
        Console.WriteLine("Default");
    }
    public Tocka(double x, double y)
    {
    this.X = x;
    this.Y = y;
    }
}