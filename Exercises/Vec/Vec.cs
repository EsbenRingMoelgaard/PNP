using System;

public class Vec {
    public double x { get; }
    public double y { get; }
    public double z { get; }

    public Vec() { }
    public Vec(double x, double y, double z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    // Unary plus and minus operators
    public static Vec operator +(Vec a) => a;
    public static Vec operator -(Vec a) => new Vec(-a.x, -a.y, -a.z);

    // Vector addition and subtraction
    public static Vec operator +(Vec a, Vec b) => new Vec(a.x + b.x, a.y + b.y, a.z + b.z);
    public static Vec operator -(Vec a, Vec b) => new Vec(a.x - b.x, a.y - b.y, a.z - b.z);

    // Scalar-Vector multiplication and division
    public static Vec operator *(double s, Vec a) => new Vec(s * a.x, s * a.y, s * a.z);
    public static Vec operator *(Vec a, double s) => new Vec(s * a.x, s * a.y, s * a.z);
    public static Vec operator /(Vec a, double s) => new Vec(a.x / s, a.y / s, a.z / s);

    // Equality
    public static bool operator ==(Vec a, Vec b) {
        if (a.x != b.x || a.y != b.y || a.y != b.y) return false;
        else return true;
    }
    public static bool operator !=(Vec a, Vec b) => !(a == b);

    private static bool approx(double a, double b, double acc=1e-9, double eps=1e-9) {
        double diff = Math.Abs(a - b);
        if (diff <= acc || diff / Math.Max(Math.Abs(a), Math.Abs(b)) <= eps) { return true; }
        else { return false; }
    }


    public static bool approx(Vec a, Vec b) {
        if (!approx(a.x, b.x) || !approx(a.y, b.y) || !approx(a.z, b.z)) { return false; }
        else { return true; }
    }

    public bool approx(Vec other) => approx(this, other);

    // Dot product
    public static double dot(Vec vec1, Vec vec2) {
        return (vec1.x * vec2.x) + (vec1.y * vec2.y) + (vec1.z * vec2.z);
    }

    public double dot(Vec other) => dot(this, other);

    // Cross product
    public static Vec cross(Vec vec1, Vec vec2) {
        double crossX = (vec1.y * vec2.z) - (vec1.z * vec2.y);
        double crossY = (vec1.z * vec2.x) - (vec1.x * vec2.z);
        double crossZ = (vec1.x * vec2.y) - (vec1.y * vec2.x);
        return new Vec(crossX, crossY, crossZ);
    }

    public Vec cross(Vec other) => cross(this, other);

    public override string ToString() {
        return $"({x}, {y}, {z})";
    }
}