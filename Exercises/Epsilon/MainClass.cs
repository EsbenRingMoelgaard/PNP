using System;

public static class MainClass {
    public static bool Approx(double a, double b, double acc=1e-9, double eps=1e-9) {
        double diff = Math.Abs(a - b);
        if (diff <= acc || diff / Math.Max(Math.Abs(a), Math.Abs(b)) <= eps) { return true; }
        else { return false; }
    }

    public static void Main() {
        int i = 0;
        while(i+1 > i) { i++; }
        Console.WriteLine($"My max int: {i}. The built-in max int: {int.MaxValue}");

        i = 0;
        while(i-1 < i) { i--; }
        Console.WriteLine($"My min int: {i}. The built-in min int: {int.MinValue}");

        double x=1; 
        while(1+x != 1) { x/=2; } 
        x*=2;
        Console.WriteLine($"The double epsilon is: {x}");
        Console.WriteLine($"For comparison, 2^-52: {Math.Pow(2, -52)}");

        float y=1F; 
        while(1F+y != 1F) { y/=2F; } 
        y*=2F;
        Console.WriteLine($"The float epsilon is: {y}");
        Console.WriteLine($"For comparison, 2^-23: {(float)Math.Pow(2, -23)}");

        double epsilon=Math.Pow(2,-52);
        double tiny = epsilon / 2;
        double a = 1 + tiny + tiny;
        double b = tiny + tiny + 1;
        double c = tiny + 1 + tiny;
        Console.WriteLine(
$@"
Tiny: {epsilon} is the smallest possible unit by which a double may be incremented. Hence
a = 1 + tiny/2 + tiny/2 evaluates as follows:
a = (1 + tiny/2) + tiny/2
a = (1) + tiny/2
a = 1
whereas
b = tiny/2 + tiny/2 + 1 evaluates as follows:
b = (tiny/2 + tiny/2) + 1
b = (tiny) + 1
"
        );
        Console.WriteLine($"a==b? {a==b}");
        Console.WriteLine($"a==c? {a==c}");
        Console.WriteLine($"c==b? {c==b}\n");

        double d1 = 0.1+0.1+0.1+0.1+0.1+0.1+0.1+0.1;
        double d2 = 8*0.1;

        Console.WriteLine($"d1==d2 ? => {d1==d2}");
        Console.WriteLine($"d1 approx d2 ? => {Approx(d1, d2)}");
        Console.WriteLine($"d1 approx (1e-20 precision) d2 ? => {Approx(d1, d2, 1e-20, 1e-20)}");
        Console.WriteLine("So Approx function works as intended :)");
    }
}