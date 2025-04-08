using System;
using System.Numerics;

public static class MainClass {
    private static bool approx(Complex a, Complex b, double acc=1e-9, double eps=1e-9) {
        Complex diff = a - b;
        if (diff.Real > acc || diff.Real / Math.Max(a.Magnitude, b.Magnitude) > eps) { return false; }
        if (diff.Imaginary > acc || diff.Imaginary / Math.Max(a.Magnitude, b.Magnitude) > eps) { return false; }
        return true;
    }


    public static void Main() {
        Complex i = new Complex(0, 1);
        double pi = Math.PI;

        Console.WriteLine($"(2+3i) == (2+i): {approx(new Complex(2, 3), new Complex(2, 1))}");
        Console.WriteLine($"(2+3i) == (2+3i): {approx(new Complex(2, 3), new Complex(2, 3))}");
        Console.WriteLine($"(2+3i) - (3i) == 2: {approx(new Complex(2, 3) - new Complex(0, 3), 2)}");
        Console.WriteLine($"sqrt(-1) == i: {approx(Complex.Sqrt(-1), i)}");
        Console.WriteLine($"ln(i) == i^pi/2: {approx(Complex.Log(i), new Complex(0, pi/2))}");
        Console.WriteLine($"Sin(i*pi) == 11.5487393572577i: {approx(Complex.Sin(i*pi), 11.5487393572577*i)}");
        
        Complex z = Math.Cos(pi/4) + i*Math.Sin(pi/4);
        Console.WriteLine($"sqrt(i) == cos(pi/4)+i*sin(pi/4): {approx(Complex.Sqrt(i), z)}");

        Console.WriteLine($"e^i == cos(1) + i*sin(1): {approx(Complex.Exp(i), Math.Cos(1) + i*Math.Sin(1))}");
        Console.WriteLine($"e^(i*pi) == cos(pi) + i*sin(pi): {approx(Complex.Exp(i*pi), Math.Cos(pi) + i*Math.Sin(pi))}");
        Console.WriteLine($"i^i == 0.208: {approx(Complex.Pow(i, i), 0.208)}");

        
    }
}