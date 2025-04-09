using System;

public class Matrix {
    private double[,] data;
    public readonly int Rows, Columns;
    public Matrix(double[,] data) {
        this.Rows = data.GetLength(0);
        this.Columns = data.GetLength(1);
        this.data = data;
    }

    public double this[int i, int j] {
        get => data[i, j];
    }

    public Vector GetRow(int index) {
        if(index < 0) throw new ArgumentOutOfRangeException($"Negative indices not accepted. Passed index {index}.");
        if(index > Rows) throw new ArgumentOutOfRangeException($"Passed index {index} greater than number of rows {Rows}");
        double[] result = new double[Columns];
        for(int i=0; i<Columns; i++) { result[i] = this[index, i]; }
        return new Vector(result);
    }

    public Vector GetColumn(int index) {
        if(index < 0) throw new ArgumentOutOfRangeException($"Negative indices not accepted. Passed index {index}.");
        if(index > Rows) throw new ArgumentOutOfRangeException($"Passed index {index} greater than number of columns {Columns}");
        double[] result = new double[Rows];
        for(int i=0; i<Rows; i++) { result[i] = this[i, index]; }
        return new Vector(result);
    }

    public static Matrix operator +(Matrix a, Matrix b) {
        if(a.Columns != b.Columns || a.Rows != b.Rows) { throw new InvalidOperationException($"Operation on matrices of mismatched dimensions"); }
        double[,] result = new double[a.Rows, a.Columns];
        for(int i=0; i<a.Rows; i++) {
            for(int j=0; j<a.Columns; j++) {
                result[i, j] = a[i, j] + b[i, j];
            }
        }
        return new Matrix(result);
    }

    public static Matrix operator -(Matrix a, Matrix b) { return a + (-b); }

    public static Matrix operator -(Matrix a) {
        double[,] result = new double[a.Rows, a.Columns];
        for(int i=0; i<a.Rows; i++) {
            for(int j=0; j<a.Columns; j++) {
                result[i, j] = -a[i, j];
            }
        }
        return new Matrix(result);
    }

    public static Matrix operator *(double a, Matrix b) {
        double[,] result = new double[b.Rows, b.Columns];
        for(int i=0; i<b.Rows; i++) {
            for(int j=0; j<b.Columns; j++) {
                result[i, j] = a * b[i, j];
            }
        }
        return new Matrix(result);
    }

    public static Vector operator *(Matrix a, Vector b) {
        if(a.Columns != b.Size) { throw new InvalidOperationException($"Operation on matrices of mismatched dimensions"); }
        double[] result = new double[a.Rows];
        for(int i=0; i<a.Rows; i++) {
            double value = 0;
            for(int j=0; j<b.Size; j++) {
                value += a[i, j] * b[j];
            }
            result[i] = value;
        }
        return new Vector(result);
    }

    public static Matrix operator *(Matrix a, Matrix b) {
        if(a.Columns != b.Rows) { throw new InvalidOperationException($"Operation on matrices of mismatched dimensions"); }
        double[,] result = new double[a.Rows, b.Columns];
        
        for(int i=0; i<b.Columns; i++) // Loop over each column in b
        {
            for(int j=0; j<a.Rows; j++) // Loop over each row in a
            {
                double value = 0;
                for(int k=0; k<a.Columns; k++) // Loop over each column in a
                {
                    value += b[j, i] * a[j, k];
                }
                result[j, i] = value;
            }
        }

        return new Matrix(result);
    }

    public override string ToString() {
        string result = "";
        
        for(int i=0; i<this.Rows; i++) {
            result += GetRow(i).ToString() + "\n";
        }
        return result;
    }
}