public class MainClass {
    public static void Main() {
        Matrix ident = new Matrix(new double[,] {{1, 0, 0}, {0, 1, 0}, {0, 0, 1}});
        Vector ones = new Vector(new double[] {1, 1, 1});

        Vector vector = new Vector(new double[] {1, 4.5, -2});
        System.Console.WriteLine(ident.Columns);
        System.Console.WriteLine(ident.GetColumn(1));

        System.Console.WriteLine(ident * ones);
        System.Console.WriteLine(ident * vector);
        System.Console.WriteLine(ones * ones);
        System.Console.WriteLine(vector * ones);
        System.Console.WriteLine(ones + vector);
        System.Console.WriteLine(7.5 * ones);
    }
}