using System;

public static class MainClass {
    public static void Main() {
        Vec A = new Vec(2, 3, 4);
        Console.WriteLine($"A: {A}");
        Vec B = new Vec(-5, 6, 18);
        Console.WriteLine($"B: {B}\n");

        Console.WriteLine($"A + B: {A + B}");
        Console.WriteLine($"A - B: {A - B}\n");

        Console.WriteLine($"5 * A: {5 * A}");
        Console.WriteLine($"A * 5: {A * 5}");
        Console.WriteLine($"A / 10: {A / 10}\n");

        Console.WriteLine($"A dot B via static method: {Vec.Dot(A, B)}");
        Console.WriteLine($"A dot B via instance method: {A.Dot(B)}");
        Console.WriteLine($"B dot A: {Vec.Dot(B, A)}\n");

        Console.WriteLine($"A cross B via static method: {Vec.Cross(A, B)}");
        Console.WriteLine($"A cross B via instance method: {A.Cross(B)}");
        Console.WriteLine($"B cross A: {Vec.Cross(B, A)}\n");

        Console.WriteLine($"A dot (A cross B): {A.Dot(A.Cross(B))}");
        Console.WriteLine($"A cross (A cross B): {A.Cross(A.Cross(B))}");
        Console.WriteLine($"A cross (5 * B): {A.Cross(5 * B)}");
    }
}