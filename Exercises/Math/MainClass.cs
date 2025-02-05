using static System.Math;

public static class MainClass {
    public static void Main() {
        SFuns.FGamma(5);
        System.Console.Write(checkSqrt());
        separate();
        System.Console.Write(checkPower());
        separate();
        System.Console.Write(checkExp());
        separate();
        System.Console.Write(checkPi());
        separate();
        for(int i=1; i<=10; i++) {
            System.Console.Write($"Gamma function evaluated to: {SFuns.FGamma(i)}\n");
            System.Console.Write($"Expected to be {SFuns.IntFactorial(i-1)}\n");
        }
        separate();
        for(int i=1; i<=10; i++) {
            System.Console.Write($"LnGamma function evaluated to: {SFuns.LnFGamma(i)}\n");
            System.Console.Write($"Expected to be {Log(SFuns.IntFactorial(i-1))}\n");
        }
    }

    static void separate() {
        System.Console.Write("------------------------\n");
    }

    static string checkSqrt() {
        double root = Sqrt(2);
        return $"sqrt(2) evaluated to: {root}\n" +
               $"sqrt(2)^2 evaluated to: {Pow(root, 2)}\n";
    }

    static string checkPower() {
        double result = Pow(2, 1.0/5.0);
        return $"2^(1/5) evaluated to: {result}\n" +
               $"2^(1/5)^5 evaluated to: {Pow(result, 5)}\n";
    }

    static string checkExp() {
        double result = Exp(PI);
        return $"e^pi evaluated to: {result}\n" + 
               $"ln(e^pi) evaluated to: {Log(result)}\n";
    }

    static string checkPi() {
        double result = Pow(PI, E);
        return $"pi^e evaluated to: {result}\n" + 
               $"log_pi(pi^e) evaluated to: {Log(result, PI)}\n";
    }
}