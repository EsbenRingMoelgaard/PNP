using System;

public static class MainClass {
    public static void Main(string[] args) {
        foreach(string arg in args) {
            string[] parts = arg.Split(":");

            if (parts[0] == "-numbers") {
                string[] numbers = parts[1].Split(",");
                Console.WriteLine($"| x | Sin(x) | Cos(x) |");
                Console.WriteLine($"|---| ------ | ------ |");

                foreach(string number in numbers) {
                    double x = double.Parse(number);
                    Console.WriteLine($"| {x} | {Math.Sin(x)} | {Math.Cos(x)} |");
                }
            }
        }
    }
}