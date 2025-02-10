using System;

public static class MainClass {
    public static void Main() {
        Vec A = new Vec(2, 3, 4);
        Console.WriteLine($"A: {A}");
        Vec B = new Vec(-5, 6, 18);
        Console.WriteLine($"B: {B}");
        Vec C = new Vec(0.2, -0.0, -13.555);
        Console.WriteLine($"C: {C}");
        Vec DefaultVector = new Vec();
        Console.WriteLine($"Default vector: {DefaultVector}\n");

        Console.WriteLine($"A + B: {A + B}");
        Console.WriteLine($"A - B: {A - B}\n");

        Console.WriteLine($"5 * A: {5 * A}");
        Console.WriteLine($"A * 5: {A * 5}");
        Console.WriteLine($"A / 10: {A / 10}\n");

        Console.WriteLine($"A dot B via static method: {Vec.dot(A, B)}");
        Console.WriteLine($"A dot B via instance method: {A.dot(B)}");
        Console.WriteLine($"B dot A: {Vec.dot(B, A)}");
        Console.WriteLine($"A dot A: {Vec.dot(A, A)}\n");

        Console.WriteLine($"A cross B via static method: {Vec.cross(A, B)}");
        Console.WriteLine($"A cross B via instance method: {A.cross(B)}");
        Console.WriteLine($"B cross A: {Vec.cross(B, A)}\n");

        Console.WriteLine($"A dot (A cross B): {A.dot(A.cross(B))}");
        Console.WriteLine($"A cross (A cross B): {A.cross(A.cross(B))}");
        Console.WriteLine($"A cross (5 * B): {A.cross(5 * B)}\n");

        Console.WriteLine($"A == A: {A == A}");
        Console.WriteLine($"A == B: {A == B}");
        Console.WriteLine($"A != A: {A != A}");
        Console.WriteLine($"A != B: {A != B}\n");

        Console.WriteLine($"A approx A: {A.approx(A)}");
        Console.WriteLine($"A approx B: {A.approx(B)}");
        Console.WriteLine($"A !approx A: {!A.approx(A)}");
        Console.WriteLine($"A !approx B: {!A.approx(B)}\n");
    }
}