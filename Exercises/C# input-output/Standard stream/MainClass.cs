using System;

public static class MainClass {
    public static void Main(string[] args) {
        char[] delimiters = {' ','\t','\n'};

        for(string line = Console.ReadLine(); line != null; line = Console.ReadLine())
        {
	        string[] numbers = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
	        
            foreach(string number in numbers) 
            {
		        double x = double.Parse(number);
		        Console.Error.WriteLine($"| {x} | {Math.Sin(x)} | {Math.Cos(x)} |");
            }
        }
    }
}