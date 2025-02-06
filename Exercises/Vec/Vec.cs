public class Vec {
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public Vec(double x, double y, double z) {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    // Unary plus and minus operators
    public static Vec operator +(Vec a) => a;
    public static Vec operator -(Vec a) => new Vec(-a.X, -a.Y, -a.Z);

    // Vector addition and subtraction
    public static Vec operator +(Vec a, Vec b) => new Vec(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    public static Vec operator -(Vec a, Vec b) => new Vec(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

    // Scalar - Vector multiplication and division
    public static Vec operator *(double s, Vec a) => new Vec(s * a.X, s * a.Y, s * a.Z);
    public static Vec operator *(Vec a, double s) => new Vec(s * a.X, s * a.Y, s * a.Z);
    public static Vec operator /(Vec a, double s) => new Vec(a.X / s, a.Y / s, a.Z / s);

    // Dot product
    public static double Dot(Vec vec1, Vec vec2) {
        return (vec1.X * vec2.X) + (vec1.Y * vec2.Y) + (vec1.Z * vec2.Z);
    }

    public double Dot(Vec other) {
        return Dot(this, other);
    }

    // Cross product
    public static Vec Cross(Vec vec1, Vec vec2) {
        double crossX = (vec1.Y * vec2.Z) - (vec1.Z * vec2.Y);
        double crossY = (vec1.Z * vec2.X) - (vec1.X * vec2.Z);
        double crossZ = (vec1.X * vec2.Y) - (vec1.Y * vec2.X);
        return new Vec(crossX, crossY, crossZ);
    }

    public Vec Cross(Vec other) {
        return Cross(this, other);
    }

    public override string ToString() {
        return $"({X}, {Y}, {Z})";
    }
}