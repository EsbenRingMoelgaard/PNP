using System;

public class Vector {
    private double[] data;
    public int Size => data.Length;

    public double this[int i] {
        get => data[i];
    }

    public Vector(double[] values) {
        this.data = values;
    }

    public Vector(int size) {
        this.data = new double[size];
    }

    public static Vector operator *(double a, Vector b) {
        double[] result = new double[b.Size];
        for(int i=0; i<b.Size; i++) {
            result[i] = a * b[i];
        }
        return new Vector(result);
    }

    public static Vector operator +(Vector a, Vector b) {
        if(a.Size != b.Size) { throw new InvalidOperationException($"Operation on vectors of mismatched size"); }
        double[] result = new double[a.Size];
        for(int i=0; i<a.Size; i++) {
            result[i] = a[i] + b[i];
        }
        return new Vector(result);
    }

    public static Vector operator -(Vector a, Vector b) => a + (-b);

    public static Vector operator -(Vector a) {
        double[] result = new double[a.Size];
        for(int i=0; i<a.Size; i++) {
            result[i] = -a[i];
        }
        return new Vector(result);
    }

    public static double operator *(Vector a, Vector b) {
        if(a.Size != b.Size) { throw new InvalidOperationException($"Operation on vectors of mismatched size"); }
        double result = 0;
        for(int i=0; i<a.Size; i++) {
            result += a[i] * b[i];
        }
        return result;
    }

    public override string ToString() {
        string result = $"({this[0]}";
        for(int i=1; i<this.Size; i++) { result += $", {this[i]}"; }
        return result + ")";
    }
}