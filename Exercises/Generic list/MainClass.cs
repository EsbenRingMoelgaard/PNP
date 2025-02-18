using System;

public static class MainClass {


    public static void Main() {
        char[] delimiters = {' ', '\t'};

        GenList<double[]> table = new GenList<double[]>();
        for(string line = Console.ReadLine(); line != null; line = Console.ReadLine()) {
            string[] elements = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            
            int rowLength = elements.Length;
            double[] row = new double[rowLength];
            for(int i=0; i < rowLength; i++) { row[i] = double.Parse(elements[i]); }
            
            table.Add(row);
        }

        for(int i=0; i < table.Size; i++) {
            foreach(double number in table[i]) { Console.Write($"{number : 0.00e+00; -0.00e+00} "); }
            Console.Write("\n");
        }

        Console.WriteLine("\nTest of Remove(...) method");
        table.Remove(1);
        for(int i=0; i < table.Size; i++) {
            foreach(double number in table[i]) { Console.Write($"{number : 0.00e+00; -0.00e+00} "); }
            Console.Write("\n");
        }
    }
}