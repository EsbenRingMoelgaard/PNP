using System;
using System.IO;

public static class MainClass {
    public static void Main(string[] args) {
        string inputFile = null;
        string outputFile = null;
        
        foreach(string arg in args) {
            string[] parts = arg.Split(":");

            switch(parts[0]) {
                case "-input": 
                    inputFile = parts[1];
                    break;
                case "-output": 
                    outputFile = parts[1];
                    break;
            };
        }

        StreamReader inStream = new StreamReader(inputFile);
        StreamWriter outStream = new StreamWriter(outputFile);

        for(string line = inStream.ReadLine(); line != null; line = inStream.ReadLine()) {
            double x = double.Parse(line);
            outStream.WriteLine($"| {x} | {Math.Sin(x)} | {Math.Cos(x)} |");
        }

        inStream.Close();
        outStream.Close();
    }
}