using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

public class Program
{
    static void Main(string[] args)
    {
        double l = double.Parse(Console.ReadLine());
        double w = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        Box box = new Box(l, w, h);

        Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}\nLateral Surface Area - {box.LateralSurfaceArea():f2}\nVolume - {box.Volume():f2}");
    }

}

class Box
{
    private double l;
    private double w;
    private double h;

    public Box(double l, double w, double h)
    {
        this.l = l;
        this.w = w;
        this.h = h;
    }

    public double Volume()
    {
        return this.l * this.h * this.w;
    }

    public double LateralSurfaceArea()
    {

        return 2 * this.l * this.h + 2 * this.w * this.h;
    }

    public double SurfaceArea()
    {
        return 2 * this.l * this.w + 2 * this.l * this.h + 2 * this.w * this.h;
    }

}